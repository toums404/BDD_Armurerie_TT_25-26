using BDD_Armurerie_TT_25_26.Entites;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Armurerie_TT_25_26.DAL
{
    public class ClientDAL
    {
        private string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\école\IS2\Q2\PROGRA EVENT\BDD_Armurerie_TT_25-26\ArmurerieDB.mdf"";Integrated Security = True";
        public List<Client> GetLesClients() 
        {
            List<Client> listeClients = new List<Client>();
            using (SqlConnection connexion = new SqlConnection(_connectionString))
            {
                string requete = "SELECT IdClient, Nom, Prenom, Adresse, Email FROM T_Client";
                using (SqlCommand commande = new SqlCommand(requete, connexion)) 
                {
                    connexion.Open();
                    using (SqlDataReader lecteur = commande.ExecuteReader())
                    {
                        while (lecteur.Read()) 
                        {
                            Client c = new Client();
                            c.IdClient = Convert.ToInt32(lecteur["IdClient"]);
                            c.Nom = lecteur["Nom"].ToString();
                            c.Prenom = lecteur["Prenom"].ToString();
                            c.Adresse = lecteur["Adresse"].ToString();
                            c.Email = lecteur["Email"].ToString();
                            listeClients.Add(c);
                        }
                        
                    }
                }

            }
            return listeClients;
        }
    }
}
