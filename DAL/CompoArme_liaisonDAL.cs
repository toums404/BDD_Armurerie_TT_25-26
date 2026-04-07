using BDD_Armurerie_TT_25_26.Entites;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Armurerie_TT_25_26.DAL
{
    public class CompoArme_liaisonDAL
    {
        private string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\école\IS2\Q2\PROGRA EVENT\BDD_Armurerie_TT_25-26\ArmurerieDB.mdf"";Integrated Security = True";
        public List<CompoArme_liaison> GetLesCompoArme_liaisons()
        {
            List<CompoArme_liaison> listeCompoArme_liaisons = new List<CompoArme_liaison>();
            using (SqlConnection connexion = new SqlConnection(_connectionString))
            {
                string requete = "SELECT IdArme, IdPiece, QuantiteRequise FROM T_CompoArme_liaison";
                using (SqlCommand commande = new SqlCommand(requete, connexion))
                {
                    connexion.Open();
                    using (SqlDataReader lecteur = commande.ExecuteReader())
                    {
                        while (lecteur.Read())
                        {
                            CompoArme_liaison ca = new CompoArme_liaison();
                            ca.IdArme = Convert.ToInt32(lecteur["IdArme"]);
                            ca.IdPiece = Convert.ToInt32(lecteur["IdPiece"]);
                            ca.QuantiteRequise = Convert.ToInt32(lecteur["QuantiteRequise"]);
                            listeCompoArme_liaisons.Add(ca);
                        }
                    }
                }
            }
            return listeCompoArme_liaisons;
        }
    }
}
