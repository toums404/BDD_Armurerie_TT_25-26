using BDD_Armurerie_TT_25_26.BLL;
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
    public partial class FenetreArme : Form
    {
        public FenetreArme()
        {
            InitializeComponent();
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                Arme nouvelleArme = new Arme
                {
                    Nom = txtNom.Text,
                    QuantiteStock = (int)numStock.Value,
                    SeuilAlerte = (int)numAlerte.Value,
                    PrixVente = numPrix.Value
                };
                ArmeManager manager = new ArmeManager();
                string resultat = manager.CreerArme(nouvelleArme);
                MessageBox.Show(resultat, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (resultat.Contains("succès") || resultat.Contains("catalogue"))
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de l'arme : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FenetreArme_Load(object sender, EventArgs e)
        {

        }
    }
}
