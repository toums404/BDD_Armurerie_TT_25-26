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
            var armesEnAlerte = _stockManager.ObtenirArmesSeuil();
            var piecesEnAlerte = _stockManager.ObtenirPiecesSeuil();
            var alertesCombinees = new List<Object>();
            foreach (var arme in armesEnAlerte)
            {
                alertesCombinees.Add(new { Type = "Arme", Article = arme.Nom, Quantite = arme.QuantiteStock, Seuil = arme.SeuilAlerte });
            }

            foreach (var piece in piecesEnAlerte)
            {
                alertesCombinees.Add(new { Type = "Pièce", Article = piece.Nom, Quantite = piece.QuantiteStock, Seuil = piece.SeuilAlerte });
            }
            dgvAlertes.DataSource = alertesCombinees;

            decimal ca = _venteManager.CalculerChiffreAffairesHebdo();
            lblChiffreAffaires.Text = $"{ca} €";
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
        private void msQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bRVente_Click(object sender, EventArgs e)
        {
            FenetreVente fenetreVente = new FenetreVente();
            fenetreVente.ShowDialog();
        }

        private void bRAssemblage_Click(object sender, EventArgs e)
        {
            FenetreAssemblage fenetreAssemblage = new FenetreAssemblage();
            fenetreAssemblage.ShowDialog();
        }

        private void bRCommande_Click(object sender, EventArgs e)
        {
            FenetreCommande fenetreCommande = new FenetreCommande();
            fenetreCommande.ShowDialog();
        }

        private void bRQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouterUneCompositionDarmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FenetreComposition fenetreComposition = new FenetreComposition();
            fenetreComposition.ShowDialog();
        }

        private void miHistoriqueDeVente_Click(object sender, EventArgs e)
        {
            FenetreHistorique fenetreHistorique = new FenetreHistorique();
            fenetreHistorique.ShowDialog();
        }

        private void inventaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FenetreInventaire fenetreInventaire = new FenetreInventaire();
            fenetreInventaire.ShowDialog();
        }
    }
}
