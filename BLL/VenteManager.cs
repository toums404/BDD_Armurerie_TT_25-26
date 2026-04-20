using BDD_Armurerie_TT_25_26.DAL;
using BDD_Armurerie_TT_25_26.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Armurerie_TT_25_26.BLL
{
    public class VenteManager
    {
        private ArmeDAL _armeDAL = new ArmeDAL();
        private VenteDAL _venteDAL = new VenteDAL();

        public string ValiderVente(int IdClient, int IdArme, int QuantiteVendue)
        {
            if (QuantiteVendue <= 0) { return "La quantité vendue doit être supérieure à zéro."; }

            Arme armeAVendre = _armeDAL.GetLesArmes().Find(a => a.IdArme == IdArme);
            
            if (armeAVendre == null) { return "L'arme sélectionnée n'existe pas."; }
            
            if (armeAVendre.QuantiteStock < QuantiteVendue) { return $"Stock insuffisant pour l'arme '{armeAVendre.Nom}'. Besoin : {QuantiteVendue}, Stock disponible : {armeAVendre.QuantiteStock}."; }
            
            _armeDAL.DiminuerStock(IdArme, QuantiteVendue);
            decimal MontantTotal = armeAVendre.PrixVente * QuantiteVendue;
            _venteDAL.AjouterVente(IdClient, DateTime.Now, "Facture", (int) MontantTotal);

            string facture = $"===== FACTURE AUTOMATIQUE =====\n" +
                             $"Date : {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}\n" +
                             $"Client ID : {IdClient}\n" +
                             $"-------------------------------\n" +
                             $"Article : {armeAVendre.Nom}\n" +
                             $"Quantité : {QuantiteVendue}\n" +
                             $"Prix unitaire : {armeAVendre.PrixVente} €\n" +
                             $"-------------------------------\n" +
                             $"TOTAL À PAYER : {MontantTotal} €\n" +
                             $"===============================";

            return facture;
        }
        public decimal CalculerChiffreAffairesHebdo()
        {
            List<Vente> toutesLesVentes = _venteDAL.GetLesVentes();
            decimal chiffreAffaires = 0;

            //date limite a 7j
            DateTime dateLimite = DateTime.Now.AddDays(-7);

            foreach (var vente in toutesLesVentes)
            {
                if (vente.DateVente >= dateLimite)
                {
                    
                    chiffreAffaires += vente.MontantTotal; 
                }
            }

            return chiffreAffaires;
        }
    }

    
}
