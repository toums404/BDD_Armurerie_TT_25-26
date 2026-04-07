using BDD_Armurerie_TT_25_26.Entites;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Armurerie_TT_25_26.DAL
{
    public class PieceDAL
    {
        private string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\école\IS2\Q2\PROGRA EVENT\BDD_Armurerie_TT_25-26\ArmurerieDB.mdf"";Integrated Security = True";
        public List<Piece> GetLesPieces()
        {
            List<Piece> listePieces = new List<Piece>();
            using (SqlConnection connexion = new SqlConnection(_connectionString))
            {
                string requete = "SELECT IdPiece, Nom, Description, QuantiteStock, SeuilAlerte, PrixAchat, IdFournisseur  FROM T_Piece";
                using (SqlCommand commande = new SqlCommand(requete, connexion))
                {
                    connexion.Open();
                    using (SqlDataReader lecteur = commande.ExecuteReader())
                    {
                        while (lecteur.Read())
                        {
                            Piece p = new Piece();
                            p.IdPiece = Convert.ToInt32(lecteur["IdPiece"]);
                            p.Nom = lecteur["NomPiece"].ToString();
                            p.Description = lecteur["Description"].ToString();
                            p.QuantiteStock = Convert.ToInt32(lecteur["QuantiteStock"]);
                            p.SeuilAlerte = Convert.ToInt32(lecteur["SeuilAlerte"]);
                            p.PrixAchat = Convert.ToDecimal(lecteur["PrixAchat"]);
                            p.IdFournisseur = Convert.ToInt32(lecteur["IdFournisseur"]);
                            listePieces.Add(p);
                        }
                    }
                }
            }
            return listePieces;
        }
    }
}
