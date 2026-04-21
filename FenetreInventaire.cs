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
    public partial class FenetreInventaire : Form
    {
        public FenetreInventaire()
        {
            InitializeComponent();
        }

        private void FenetreInventaire_Load(object sender, EventArgs e)
        {
            try
            {
                ArmeDAL aDAL = new ArmeDAL();
                dgvArme.DataSource = aDAL.GetLesArmes();

                dgvArme.Columns["IdArme"].Visible = false;
                dgvArme.Columns["PrixVente"].HeaderText = "Prix de vente";
                dgvArme.Columns["QuantiteStock"].HeaderText = "Quantité en stock";
                dgvArme.Columns["SeuilAlerte"].HeaderText = "Seuil d'alerte de recommande";

                PieceDAL pDAL = new PieceDAL();
                dgvPiece.DataSource = pDAL.GetLesPieces();
                dgvPiece.Columns["IdPiece"].Visible = false;
                dgvPiece.Columns["IdFournisseur"].Visible = false;
                dgvPiece.Columns["QuantiteStock"].HeaderText = "Quantité en stock";
                dgvPiece.Columns["SeuilAlerte"].HeaderText = "Seuil d'alerte de recommande";
                dgvPiece.Columns["PrixAchat"].HeaderText = "Prix d'achat de la pièce";


                AjusterDesignTableau(dgvArme);
                AjusterDesignTableau(dgvPiece);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement de l'inventaire : " + ex.Message);
            }
        }
        private void AjusterDesignTableau(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
        }
    }
}
