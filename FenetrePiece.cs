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
    public partial class FenetrePiece : Form
    {
        public FenetrePiece()
        {
            InitializeComponent();
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            Piece nouvellePiece = new Piece
            {
                Nom = txtNom.Text,
                Description = txtDescription.Text,
                QuantiteStock = (int)numStock.Value,
                SeuilAlerte = (int)numAlerte.Value,
                PrixAchat = numPrix.Value,
                IdFournisseur = (int)cmbFournisseur.SelectedValue
            };
            PieceManager manager = new PieceManager();
            string msg = manager.CreerPiece(nouvellePiece);

            MessageBox.Show(msg);
            if (msg.Contains("succès")) this.Close();
        }

        private void FenetrePiece_Load(object sender, EventArgs e)
        {
            FournisseurDAL fournisseurDAL = new FournisseurDAL();
            var liste = fournisseurDAL.GetLesFournisseurs();

            cmbFournisseur.DataSource = liste;
            cmbFournisseur.DisplayMember = "NomSociete";//ce qui est montrer dans la cb
            cmbFournisseur.ValueMember = "IdFournisseur";//la vraie valeur reprise
        }
    }
}
