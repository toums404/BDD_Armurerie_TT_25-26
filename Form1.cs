using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDD_Armurerie_TT_25_26.BLL;
using BDD_Armurerie_TT_25_26.DAL;
using BDD_Armurerie_TT_25_26.Entites;

namespace BDD_Armurerie_TT_25_26
{
    public partial class FenetrePrincipale : Form
    {
        private StockManager _stockManager = new StockManager();
        private VenteManager _venteManager = new VenteManager();
        public FenetrePrincipale()
        {
            InitializeComponent();
        }

        private void FenetrePrincipale_Load(object sender, EventArgs e)
        {
            dgvAlertes.DataSource = _stockManager.ObtenirArmesSeuil();
            decimal ca = _venteManager.CalculerChiffreAffairesHebdo();
            lblChiffreAffaires.Text = $"Chiffre d'affaires hebdomadaire : {ca} €";
        }

        private void miFournisseur_Click(object sender, EventArgs e)
        {
            FenetreFournisseur fenetreFournisseur = new FenetreFournisseur();
            fenetreFournisseur.ShowDialog();
        }
        private void miArme_Click(object sender, EventArgs e)
        {
            FenetreArme fenetreArme = new FenetreArme();
            fenetreArme.ShowDialog();
        }
        private void miPiece_Click(object sender, EventArgs e)
        {
            FenetrePiece fenetrePiece = new FenetrePiece();
            fenetrePiece.ShowDialog();
        }

        private void miVente_Click(object sender, EventArgs e)
        {
            FenetreVente fenetreVente = new FenetreVente();
            fenetreVente.ShowDialog();
        }
        private void miAssembler_Click(object sender, EventArgs e)
        {
            FenetreAssemblage fenetreAssemblage = new FenetreAssemblage();
            fenetreAssemblage.ShowDialog();
        }
        private void miCommandeFournisseur_Click(object sender, EventArgs e)
        {
            FenetreCommande fenetreCommande = new FenetreCommande();
            fenetreCommande.ShowDialog();
        }
    }
}
