using BDD_Armurerie_TT_25_26.Entites;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Armurerie_TT_25_26.DAL
{
    public class FournisseurDAL
    {
        private string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\école\IS2\Q2\PROGRA EVENT\BDD_Armurerie_TT_25-26\ArmurerieDB.mdf"";Integrated Security = True";

        public List<Fournisseur> GetLesFournisseurs() 
        {
            List<Fournisseur> listeFournisseurs = new List<Fournisseur>();
            using (SqlConnection connexion = new SqlConnection(_connectionString))
            {
                string requete = "SELECT IdFournisseur, NomSociete, ContactNom, Telephone FROM T_Fournisseurs";
                using (SqlCommand commande = new SqlCommand(requete, connexion))
                {
                    connexion.Open();
                    using (SqlDataReader lecteur = commande.ExecuteReader())
                    {
                        while (lecteur.Read())
                        {
                            Fournisseur f = new Fournisseur();
                            f.IdFournisseur = Convert.ToInt32(lecteur["IdFournisseur"]);
                            f.NomSociete = lecteur["NomSociete"].ToString();
                            f.ContactNom = lecteur["ContactNom"].ToString();
                            f.Telephone = lecteur["Telephone"].ToString();
                            listeFournisseurs.Add(f);
                        }
                    }
                }
            }
            return listeFournisseurs;
        }
    }
}
