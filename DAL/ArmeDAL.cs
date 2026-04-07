using BDD_Armurerie_TT_25_26.Entites;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Armurerie_TT_25_26.DAL
{
    public class ArmeDAL
    {
        private string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\école\IS2\Q2\PROGRA EVENT\BDD_Armurerie_TT_25-26\ArmurerieDB.mdf"";Integrated Security = True";

        public List<Arme> GetLesArmes()
        { 
            List<Arme> listeArmes = new List<Arme>();
            using (SqlConnection connexion = new SqlConnection(_connectionString))
            {
                string requete = "SELECT IdArme, Nom, Type, Calibre FROM T_Arme";
                using (SqlCommand commande = new SqlCommand(requete, connexion))
                {
                    connexion.Open();
                    using (SqlDataReader lecteur = commande.ExecuteReader())
                    {
                        while (lecteur.Read())
                        {
                            Arme a = new Arme();
                            a.IdArme = Convert.ToInt32(lecteur["IdArme"]);
                            a.Nom = lecteur["Nom"].ToString();
                            a.PrixVente = Convert.ToDecimal(lecteur["PrixVente"]);
                            a.QuantiteStock = Convert.ToInt32(lecteur["QuantiteStock"]);
                            a.SeuilAlerte = Convert.ToInt32(lecteur["SeuilAlerte"]);
                            listeArmes.Add(a);
                        }
                    }
                }
            }
            return listeArmes;
        }
    }
}
