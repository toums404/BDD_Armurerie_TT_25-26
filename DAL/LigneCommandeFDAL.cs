using BDD_Armurerie_TT_25_26.Entites;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Armurerie_TT_25_26.DAL
{
    public class LigneCommandeFDAL
    {
        private string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\école\IS2\Q2\PROGRA EVENT\BDD_Armurerie_TT_25-26\ArmurerieDB.mdf"";Integrated Security = True";
        public List<LigneCommandeF> GetLesLignesCommandesF()
        {
            List<LigneCommandeF> listeCommandeF = new List<LigneCommandeF>();
            using (SqlConnection connexion = new SqlConnection(_connectionString))
            {
                string requete = "SELECT IdLigneF, IdCommandeF, IdPiece, QuantiteCommande FROM T_LignesCommandeF";
                using (SqlCommand commande = new SqlCommand(requete, connexion))
                {
                    connexion.Open();
                    using (SqlDataReader lecteur = commande.ExecuteReader())
                    {
                        while (lecteur.Read())
                        {
                            LigneCommandeF lc = new LigneCommandeF();
                            lc.IdLigneF = Convert.ToInt32(lecteur["IdLigneF"]);
                            lc.IdCommandeF = Convert.ToInt32(lecteur["IdCommandeF"]);
                            lc.IdPiece = Convert.ToInt32(lecteur["IdPiece"]);
                            lc.QuantiteCommande = Convert.ToInt32(lecteur["QuantiteCommande"]);
                            listeCommandeF.Add(lc);
                        }
                    }
                }
            }
            return listeCommandeF;
        }
    }
}
