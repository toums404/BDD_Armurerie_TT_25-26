using BDD_Armurerie_TT_25_26.BLL;
using BDD_Armurerie_TT_25_26.DAL;
using BDD_Armurerie_TT_25_26.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDD_Armurerie_TT_25_26
{
    public partial class FenetreComposition : Form
    {
        private List<CompoArme_liaison> _panierRecette = new List<CompoArme_liaison>();
        public FenetreComposition()
        {
            InitializeComponent();
        }

        private void FenetreComposition_Load(object sender, EventArgs e)
        {
            ArmeDAL armeDAL = new ArmeDAL();
            cmbArme.DataSource = armeDAL.GetLesArmes();
            cmbArme.DisplayMember = "Nom";
            cmbArme.ValueMember = "IdArme";

            PieceDAL pieceDAL = new PieceDAL();
            var pieces = pieceDAL.GetLesPieces();
            RemplirCmbPieces(cmbPiece1, pieces);
            RemplirCmbPieces(cmbPiece2, pieces);
            RemplirCmbPieces(cmbPiece3, pieces);
            RemplirCmbPieces(cmbPiece4, pieces);


        }
        private void RemplirCmbPieces(ComboBox cmb, List<Piece> listeBase)
        {
            cmb.DataSource = new List<Piece>(listeBase);
            cmb.DisplayMember = "Nom";
            cmb.ValueMember = "IdPiece";
        }
        private void TraiterLigne(ComboBox cmb, NumericUpDown num) 
        {
            int qte = (int)num.Value;
            if (qte <= 0) return;
            
            int idPiece = (int)cmb.SelectedValue;
            string nomPiece = cmb.Text;

            _panierRecette.Add(new CompoArme_liaison { IdPiece = idPiece, QuantiteRequise = qte });
            lstRecetteTemp.Items.Add($"{nomPiece} x {qte}");
        }

        private void bAddPiece_Click(object sender, EventArgs e)
        {
            TraiterLigne(cmbPiece1, numQte1);
            TraiterLigne(cmbPiece2, numQte2);
            TraiterLigne(cmbPiece3, numQte3);
            TraiterLigne(cmbPiece4, numQte4);

            numQte1.Value = 0;
            numQte2.Value = 0;
            numQte3.Value = 0;
            numQte4.Value = 0;
        }

        private void bValiderPanier_Click(object sender, EventArgs e)
        {
            int idArme = (int)cmbArme.SelectedValue;
            StockManager manager = new StockManager();
            string resultat = manager.CreerRecetteComplete(idArme, _panierRecette);
            MessageBox.Show(resultat);
            this.Close();
            if (resultat.Contains("succès"))
            {
                this.Close();
            }
        }
    }
}
