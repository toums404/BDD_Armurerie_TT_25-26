using BDD_Armurerie_TT_25_26.BLL;
using BDD_Armurerie_TT_25_26.DAL;
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
    public partial class FenetreCommande : Form
    {
        public FenetreCommande()
        {
            InitializeComponent();
        }

        private void FenetreCommande_Load(object sender, EventArgs e)
        {
            FournisseurDAL fDAL = new FournisseurDAL();
            cmbFournisseur.DataSource = fDAL.GetLesFournisseurs();
            cmbFournisseur.DisplayMember = "NomSociete";
            cmbFournisseur.ValueMember = "IdFournisseur";

            PieceDAL pDAL = new PieceDAL();
            cmbPiece.DataSource = pDAL.GetLesPieces();
            cmbPiece.DisplayMember = "Nom";
            cmbPiece.ValueMember = "IdPiece";
        }

        private void bCommander_Click(object sender, EventArgs e)
        {
            try
            {
                int idFournisseurChoisi = (int)cmbFournisseur.SelectedValue;
                int idPieceChoisie = (int)cmbPiece.SelectedValue;
                int quantite = (int)numQuantite.Value;

                string nomFournisseur = cmbFournisseur.Text;
                string nomPiece = cmbPiece.Text;

                CommandeManager manager = new CommandeManager();

                string bordereau = manager.PasserCommande(idFournisseurChoisi, idPieceChoisie, quantite, nomPiece, nomFournisseur);

                MessageBox.Show(bordereau, "Bordereau de Commande", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}
