using BDD_Armurerie_TT_25_26.Entites;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Armurerie_TT_25_26.DAL
{
    public class CommandeFournisseurDAL
    {
        private string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\école\IS2\Q2\PROGRA EVENT\BDD_Armurerie_TT_25-26\ArmurerieDB.mdf"";Integrated Security = True";

        public List<CommandeFournisseur> GetLesCommandesFournisseur()
        {
        List<CommandeFournisseur> listeCommandesFournisseur = new List<CommandeFournisseur>();
            using (SqlConnection connexion = new SqlConnection(_connectionString))
            {
                string requete = "SELECT IdCommandeF, IdFournisseur, DateCommande, Statut FROM T_CommandeFournisseur";
                using (SqlCommand commande = new SqlCommand(requete, connexion))
                {
                    connexion.Open();
                    using (SqlDataReader lecteur = commande.ExecuteReader())
                    {
                        while (lecteur.Read())
                        {
                            CommandeFournisseur cf = new CommandeFournisseur();
                            cf.IdCommandeF = Convert.ToInt32(lecteur["IdCommandeF"]);
                            cf.IdFournisseur = Convert.ToInt32(lecteur["IdFournisseur"]);
                            cf.DateCommande = Convert.ToDateTime(lecteur["DateCommande"]);
                            cf.Statut = lecteur["Statut"].ToString();
                            listeCommandesFournisseur.Add(cf);
                        }
                    }
                }
            }
            return listeCommandesFournisseur;
        }
    }
}
