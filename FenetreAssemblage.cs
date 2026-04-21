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
    public partial class FenetreAssemblage : Form
    {
        public FenetreAssemblage()
        {
            InitializeComponent();
        }

        private void FenetreAssemblage_Load(object sender, EventArgs e)
        {
            ArmeDAL armeDAL = new ArmeDAL();
            cmbArme.DataSource = armeDAL.GetLesArmes();
            cmbArme.DisplayMember= "Nom";
            cmbArme.ValueMember = "IdArme";
        }

        private void bAssembler_Click(object sender, EventArgs e)
        {
            try
            {
                int idArmeChoisie= (int)cmbArme.SelectedValue;
                int quantiteAAssembler = (int)numQuantite.Value;

                StockManager manager = new StockManager();

                string resultat = manager.AssemblerArme(idArmeChoisie, quantiteAAssembler);

                if (resultat.Contains("succès"))
                {
                    MessageBox.Show(resultat, "Assemblage réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(resultat, "Erreur d'assemblage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'assemblage : " + ex.Message);
            }
        }

        private void cmbArme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArme.SelectedValue is int idArmeChoisie)
            {
                StockManager manager = new StockManager();
                lstRecette.DataSource = manager.ObtenirTexteRecette(idArmeChoisie);
            }
        }
    }
}
