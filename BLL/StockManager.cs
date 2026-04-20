using BDD_Armurerie_TT_25_26.DAL;
using BDD_Armurerie_TT_25_26.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Armurerie_TT_25_26.BLL
{
    public class StockManager
    {
        private ArmeDAL _armeDAL = new ArmeDAL();
        private PieceDAL _pieceDAL = new PieceDAL();
        public List<Arme> ObtenirArmesSeuil()
        {
            List<Arme> toutesArmes = _armeDAL.GetLesArmes();
            List<Arme> ArmesAlertes = new List<Arme>();

            foreach (Arme a in toutesArmes)
            {
                if (a.QuantiteStock <= a.SeuilAlerte)
                {
                    ArmesAlertes.Add(a);
                }
            }
            return ArmesAlertes;
        }

        public List<Piece> ObtenirPiecesSeuil()
        {
            List<Piece> toutesPieces = _pieceDAL.GetLesPieces();
            List<Piece> PiecesAlertes = new List<Piece>();
            foreach (Piece p in toutesPieces)
            {
                if (p.QuantiteStock <= p.SeuilAlerte)
                {
                    PiecesAlertes.Add(p);
                }
            }
            return PiecesAlertes;
        }
    }
    
}
