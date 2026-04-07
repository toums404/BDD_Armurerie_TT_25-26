using BDD_Armurerie_TT_25_26.Entites;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDD_Armurerie_TT_25_26.DAL
{
    public class VenteDAL
    {
        private string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\école\IS2\Q2\PROGRA EVENT\BDD_Armurerie_TT_25-26\ArmurerieDB.mdf"";Integrated Security = True";
        public List<Vente> GetLesVentes()
        {
            List<Vente> listeVentes = new List<Vente>();
            using (SqlConnection connexion = new SqlConnection(_connectionString))
            {
                string requete = "SELECT IdVente, DateVente, IdClient, TypeDocument FROM T_Vente";
                using (SqlCommand commande = new SqlCommand(requete, connexion))
                {
                    connexion.Open();
                    using (SqlDataReader lecteur = commande.ExecuteReader())
                    {
                        while (lecteur.Read())
                        {
                            Vente v = new Vente();
                            v.IdVente = Convert.ToInt32(lecteur["IdVente"]);
                            v.DateVente = Convert.ToDateTime(lecteur["DateVente"]);
                            v.IdClient = Convert.ToInt32(lecteur["IdClient"]);
                            v.TypeDocument = lecteur["TypeDocument"].ToString();
                            listeVentes.Add(v);
                        }
                    }
                }
            }
            return listeVentes;
        }
    }
}
