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
    public partial class FenetreHistorique : Form
    {
        public FenetreHistorique()
        {
            InitializeComponent();
        }

        private void FenetreHistorique_Load(object sender, EventArgs e)
        {
            try
            {
                VenteDAL vDAL = new VenteDAL();
                dgvVentes.DataSource = vDAL.GetLesVentes();
                dgvVentes.Columns["IdClient"].Visible = false;
                dgvVentes.Columns["IdVente"].Visible = false;
                dgvVentes.Columns["NomClientAffichage"].HeaderText = "Client";
                dgvVentes.Columns["TypeDocument"].HeaderText = "Type de document";
                dgvVentes.Columns["DateVente"].HeaderText = "Date de la vente";

                CommandeFournisseurDAL cmdDAL = new CommandeFournisseurDAL();
                dgvCommandes.DataSource = cmdDAL.GetLesCommandesFournisseur();
                dgvCommandes.Columns["IdFournisseur"].Visible = false;
                dgvCommandes.Columns["NomFournisseurAffichage"].HeaderText = "Fournisseur";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement de l'historique : " + ex.Message);
            }
        }

        private void bGenererFacture_Click(object sender, EventArgs e)
        {
            if (dgvVentes.CurrentRow != null)
            {
                try
                {
                    int idVenteSelectionnee = Convert.ToInt32(dgvVentes.CurrentRow.Cells["IdVente"].Value);

                    SaveFileDialog fenetreSauvegarde = new SaveFileDialog();
                    fenetreSauvegarde.Filter = "Fichiers Texte (*.txt)|*.txt";
                    fenetreSauvegarde.FileName = $"Facture_Vente_{idVenteSelectionnee}.txt";
                    fenetreSauvegarde.Title = "Où voulez-vous enregistrer la facture ?";

                    if (fenetreSauvegarde.ShowDialog() == DialogResult.OK)
                    {
                        
                        VenteManager manager = new VenteManager();
                        manager.ExporterFactureTexte(idVenteSelectionnee, fenetreSauvegarde.FileName);

                        MessageBox.Show("La facture a été générée avec succès !", "Export réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la génération de la facture : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez d'abord sélectionner une vente dans le tableau.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
