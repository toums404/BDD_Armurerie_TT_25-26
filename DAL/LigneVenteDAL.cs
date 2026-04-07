using BDD_Armurerie_TT_25_26.Entites;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Armurerie_TT_25_26.DAL
{
    public class LigneVenteDAL
    {
        private string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\école\IS2\Q2\PROGRA EVENT\BDD_Armurerie_TT_25-26\ArmurerieDB.mdf"";Integrated Security = True";
        public List<LigneVente> GetLesLignesVente()
        {
            List<LigneVente> listeLignesVente = new List<LigneVente>();
            using (SqlConnection connexion = new SqlConnection(_connectionString))
            {
                string requete = "SELECT IdLigneV, IdVente, IdArme, Quantite, PrixUnitaire FROM T_LigneVente";
                using (SqlCommand commande = new SqlCommand(requete, connexion))
                {
                    connexion.Open();
                    using (SqlDataReader lecteur = commande.ExecuteReader())
                    {
                        while (lecteur.Read())
                        {
                            LigneVente lv = new LigneVente();
                            lv.IdLigneV = Convert.ToInt32(lecteur["IdLigneVente"]);
                            lv.IdVente = Convert.ToInt32(lecteur["IdVente"]);
                            lv.IdArme = Convert.ToInt32(lecteur["IdProduit"]);
                            lv.Quantite = Convert.ToInt32(lecteur["Quantite"]);
                            lv.PrixUnitaire = Convert.ToDecimal(lecteur["PrixUnitaire"]);
                            listeLignesVente.Add(lv);
                        }
                    }
                }
            }
            return listeLignesVente;
        }
    }
}
