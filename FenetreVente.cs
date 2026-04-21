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
    public partial class FenetreVente : Form
    {
        private int _idClientSelectionne = -1;
        public FenetreVente()
        {
            InitializeComponent();
        }

        private void FenetreVente_Load(object sender, EventArgs e)
        {
            ArmeDAL armeDAL = new ArmeDAL();
            cmbArme.DataSource = armeDAL.GetLesArmes();
            cmbArme.DisplayMember = "Nom";
            cmbArme.ValueMember = "IdArme";

            cmbArme.Enabled = false;
            numQuantite.Enabled = false;
            bVVente.Enabled = false;
        }

        private void bVClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrenom.Text))
            {
                MessageBox.Show("Le Nom et le Prénom sont obligatoires !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Client c = new Client
            {
                Nom = txtNom.Text.Trim(),
                Prenom = txtPrenom.Text.Trim(),
                Adresse = txtAdresse.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };
            ClientManager manager = new ClientManager();
            var resultat = manager.VerifierOuCreerClient(c);
            _idClientSelectionne = resultat.idClient;

            MessageBox.Show(resultat.message, "Information Client", MessageBoxButtons.OK, MessageBoxIcon.Information);


            cmbArme.Enabled = true;
            numQuantite.Enabled = true;
            bVVente.Enabled = true;

            
            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
            txtAdresse.Enabled = false;
            txtEmail.Enabled = false;
            bVClient.Enabled = false;
        }

        private void bVVente_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idClientSelectionne == -1) return;

                int idArmeChoisie = (int)cmbArme.SelectedValue;
                int quantiteVendue = (int)numQuantite.Value;

                VenteManager manager = new VenteManager();

                string facture = manager.ValiderVente(_idClientSelectionne, idArmeChoisie, quantiteVendue);

                if (facture.Contains("FACTURE"))
                {
                    MessageBox.Show(facture, "Vente Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(facture, "Erreur de Vente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la vente : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
