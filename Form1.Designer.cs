namespace BDD_Armurerie_TT_25_26
{
    partial class FenetrePrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetrePrincipale));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msCatalogue = new System.Windows.Forms.ToolStripMenuItem();
            this.opérationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.miFournisseur = new System.Windows.Forms.ToolStripMenuItem();
            this.miArme = new System.Windows.Forms.ToolStripMenuItem();
            this.miPiece = new System.Windows.Forms.ToolStripMenuItem();
            this.miVente = new System.Windows.Forms.ToolStripMenuItem();
            this.miAssembler = new System.Windows.Forms.ToolStripMenuItem();
            this.miCommandeFournisseur = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAlertes = new System.Windows.Forms.DataGridView();
            this.lblAlerte = new System.Windows.Forms.Label();
            this.lblChiffre = new System.Windows.Forms.Label();
            this.lblChiffreAffaires = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCatalogue,
            this.opérationToolStripMenuItem,
            this.msQuitter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1387, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msCatalogue
            // 
            this.msCatalogue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFournisseur,
            this.miArme,
            this.miPiece});
            this.msCatalogue.Name = "msCatalogue";
            this.msCatalogue.Size = new System.Drawing.Size(108, 29);
            this.msCatalogue.Text = "Catalogue";
            // 
            // opérationToolStripMenuItem
            // 
            this.opérationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miVente,
            this.miAssembler,
            this.miCommandeFournisseur});
            this.opérationToolStripMenuItem.Name = "opérationToolStripMenuItem";
            this.opérationToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.opérationToolStripMenuItem.Text = "Opération";
            // 
            // msQuitter
            // 
            this.msQuitter.Name = "msQuitter";
            this.msQuitter.Size = new System.Drawing.Size(83, 29);
            this.msQuitter.Text = "Quitter";
            // 
            // miFournisseur
            // 
            this.miFournisseur.Name = "miFournisseur";
            this.miFournisseur.Size = new System.Drawing.Size(283, 34);
            this.miFournisseur.Text = "Gérer les fournisseurs";
            this.miFournisseur.Click += new System.EventHandler(this.miFournisseur_Click);
            // 
            // miArme
            // 
            this.miArme.Name = "miArme";
            this.miArme.Size = new System.Drawing.Size(283, 34);
            this.miArme.Text = "Gérer les armes";
            this.miArme.Click += new System.EventHandler(this.miArme_Click);
            // 
            // miPiece
            // 
            this.miPiece.Name = "miPiece";
            this.miPiece.Size = new System.Drawing.Size(283, 34);
            this.miPiece.Text = "Gérer les pièces";
            this.miPiece.Click += new System.EventHandler(this.miPiece_Click);
            // 
            // miVente
            // 
            this.miVente.Name = "miVente";
            this.miVente.Size = new System.Drawing.Size(330, 34);
            this.miVente.Text = "Nouvelle vente";
            this.miVente.Click += new System.EventHandler(this.miVente_Click);
            // 
            // miAssembler
            // 
            this.miAssembler.Name = "miAssembler";
            this.miAssembler.Size = new System.Drawing.Size(330, 34);
            this.miAssembler.Text = "Assembler une arme";
            this.miAssembler.Click += new System.EventHandler(this.miAssembler_Click);
            // 
            // miCommandeFournisseur
            // 
            this.miCommandeFournisseur.Name = "miCommandeFournisseur";
            this.miCommandeFournisseur.Size = new System.Drawing.Size(330, 34);
            this.miCommandeFournisseur.Text = "Commander au fournisseur";
            this.miCommandeFournisseur.Click += new System.EventHandler(this.miCommandeFournisseur_Click);
            // 
            // dgvAlertes
            // 
            this.dgvAlertes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlertes.Location = new System.Drawing.Point(12, 110);
            this.dgvAlertes.Name = "dgvAlertes";
            this.dgvAlertes.RowHeadersWidth = 62;
            this.dgvAlertes.RowTemplate.Height = 28;
            this.dgvAlertes.Size = new System.Drawing.Size(523, 681);
            this.dgvAlertes.TabIndex = 1;
            // 
            // lblAlerte
            // 
            this.lblAlerte.AutoSize = true;
            this.lblAlerte.Location = new System.Drawing.Point(154, 87);
            this.lblAlerte.Name = "lblAlerte";
            this.lblAlerte.Size = new System.Drawing.Size(229, 20);
            this.lblAlerte.TabIndex = 2;
            this.lblAlerte.Text = "Alerte Stock ( a recommander )";
            // 
            // lblChiffre
            // 
            this.lblChiffre.AutoSize = true;
            this.lblChiffre.Location = new System.Drawing.Point(862, 87);
            this.lblChiffre.Name = "lblChiffre";
            this.lblChiffre.Size = new System.Drawing.Size(279, 20);
            this.lblChiffre.TabIndex = 3;
            this.lblChiffre.Text = "Chiffre d\'affaires des 7 derniers jours : ";
            // 
            // lblChiffreAffaires
            // 
            this.lblChiffreAffaires.Location = new System.Drawing.Point(862, 110);
            this.lblChiffreAffaires.Name = "lblChiffreAffaires";
            this.lblChiffreAffaires.Size = new System.Drawing.Size(500, 681);
            this.lblChiffreAffaires.TabIndex = 4;
            this.lblChiffreAffaires.Text = "label2";
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 803);
            this.Controls.Add(this.lblChiffreAffaires);
            this.Controls.Add(this.lblChiffre);
            this.Controls.Add(this.lblAlerte);
            this.Controls.Add(this.dgvAlertes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FenetrePrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Armurerie TomCorp";
            this.Load += new System.EventHandler(this.FenetrePrincipale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msCatalogue;
        private System.Windows.Forms.ToolStripMenuItem miFournisseur;
        private System.Windows.Forms.ToolStripMenuItem miArme;
        private System.Windows.Forms.ToolStripMenuItem miPiece;
        private System.Windows.Forms.ToolStripMenuItem opérationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msQuitter;
        private System.Windows.Forms.ToolStripMenuItem miVente;
        private System.Windows.Forms.ToolStripMenuItem miAssembler;
        private System.Windows.Forms.ToolStripMenuItem miCommandeFournisseur;
        private System.Windows.Forms.DataGridView dgvAlertes;
        private System.Windows.Forms.Label lblAlerte;
        private System.Windows.Forms.Label lblChiffre;
        private System.Windows.Forms.Label lblChiffreAffaires;
    }
}

