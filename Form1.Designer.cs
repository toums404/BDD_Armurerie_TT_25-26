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
            this.miFournisseur = new System.Windows.Forms.ToolStripMenuItem();
            this.miArme = new System.Windows.Forms.ToolStripMenuItem();
            this.miPiece = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneCompositionDarmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opérationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miVente = new System.Windows.Forms.ToolStripMenuItem();
            this.miAssembler = new System.Windows.Forms.ToolStripMenuItem();
            this.miCommandeFournisseur = new System.Windows.Forms.ToolStripMenuItem();
            this.miHistoriqueDeVente = new System.Windows.Forms.ToolStripMenuItem();
            this.msQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAlertes = new System.Windows.Forms.DataGridView();
            this.lblAlerte = new System.Windows.Forms.Label();
            this.lblChiffre = new System.Windows.Forms.Label();
            this.lblChiffreAffaires = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bRQuitter = new System.Windows.Forms.Button();
            this.bRAssemblage = new System.Windows.Forms.Button();
            this.bRVente = new System.Windows.Forms.Button();
            this.bRCommande = new System.Windows.Forms.Button();
            this.inventaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertes)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1256, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msCatalogue
            // 
            this.msCatalogue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFournisseur,
            this.miArme,
            this.miPiece,
            this.ajouterUneCompositionDarmeToolStripMenuItem});
            this.msCatalogue.Name = "msCatalogue";
            this.msCatalogue.Size = new System.Drawing.Size(108, 29);
            this.msCatalogue.Text = "Catalogue";
            // 
            // miFournisseur
            // 
            this.miFournisseur.Name = "miFournisseur";
            this.miFournisseur.Size = new System.Drawing.Size(371, 34);
            this.miFournisseur.Text = "Gérer les fournisseurs";
            this.miFournisseur.Click += new System.EventHandler(this.miFournisseur_Click);
            // 
            // miArme
            // 
            this.miArme.Name = "miArme";
            this.miArme.Size = new System.Drawing.Size(371, 34);
            this.miArme.Text = "Gérer les armes";
            this.miArme.Click += new System.EventHandler(this.miArme_Click);
            // 
            // miPiece
            // 
            this.miPiece.Name = "miPiece";
            this.miPiece.Size = new System.Drawing.Size(371, 34);
            this.miPiece.Text = "Gérer les pièces";
            this.miPiece.Click += new System.EventHandler(this.miPiece_Click);
            // 
            // ajouterUneCompositionDarmeToolStripMenuItem
            // 
            this.ajouterUneCompositionDarmeToolStripMenuItem.Name = "ajouterUneCompositionDarmeToolStripMenuItem";
            this.ajouterUneCompositionDarmeToolStripMenuItem.Size = new System.Drawing.Size(371, 34);
            this.ajouterUneCompositionDarmeToolStripMenuItem.Text = "Ajouter une composition d\'arme";
            this.ajouterUneCompositionDarmeToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneCompositionDarmeToolStripMenuItem_Click);
            // 
            // opérationToolStripMenuItem
            // 
            this.opérationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miVente,
            this.miAssembler,
            this.miCommandeFournisseur,
            this.miHistoriqueDeVente,
            this.inventaireToolStripMenuItem});
            this.opérationToolStripMenuItem.Name = "opérationToolStripMenuItem";
            this.opérationToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.opérationToolStripMenuItem.Text = "Opération";
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
            // miHistoriqueDeVente
            // 
            this.miHistoriqueDeVente.Name = "miHistoriqueDeVente";
            this.miHistoriqueDeVente.Size = new System.Drawing.Size(330, 34);
            this.miHistoriqueDeVente.Text = "Historique de vente";
            this.miHistoriqueDeVente.Click += new System.EventHandler(this.miHistoriqueDeVente_Click);
            // 
            // msQuitter
            // 
            this.msQuitter.Name = "msQuitter";
            this.msQuitter.Size = new System.Drawing.Size(83, 29);
            this.msQuitter.Text = "Quitter";
            this.msQuitter.Click += new System.EventHandler(this.msQuitter_Click);
            // 
            // dgvAlertes
            // 
            this.dgvAlertes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlertes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAlertes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlertes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAlertes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlertes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAlertes.Location = new System.Drawing.Point(13, 111);
            this.dgvAlertes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAlertes.Name = "dgvAlertes";
            this.dgvAlertes.RowHeadersWidth = 62;
            this.dgvAlertes.RowTemplate.Height = 28;
            this.dgvAlertes.Size = new System.Drawing.Size(789, 561);
            this.dgvAlertes.TabIndex = 1;
            // 
            // lblAlerte
            // 
            this.lblAlerte.AutoSize = true;
            this.lblAlerte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerte.Location = new System.Drawing.Point(7, 74);
            this.lblAlerte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlerte.Name = "lblAlerte";
            this.lblAlerte.Size = new System.Drawing.Size(344, 32);
            this.lblAlerte.TabIndex = 2;
            this.lblAlerte.Text = "Alerte Stock ( a recommander )";
            // 
            // lblChiffre
            // 
            this.lblChiffre.AutoSize = true;
            this.lblChiffre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChiffre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiffre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblChiffre.Location = new System.Drawing.Point(0, 0);
            this.lblChiffre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChiffre.Name = "lblChiffre";
            this.lblChiffre.Size = new System.Drawing.Size(425, 32);
            this.lblChiffre.TabIndex = 3;
            this.lblChiffre.Text = "Chiffre d\'affaires des 7 derniers jours : ";
            // 
            // lblChiffreAffaires
            // 
            this.lblChiffreAffaires.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiffreAffaires.ForeColor = System.Drawing.Color.Teal;
            this.lblChiffreAffaires.Location = new System.Drawing.Point(4, 28);
            this.lblChiffreAffaires.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChiffreAffaires.Name = "lblChiffreAffaires";
            this.lblChiffreAffaires.Size = new System.Drawing.Size(170, 78);
            this.lblChiffreAffaires.TabIndex = 4;
            this.lblChiffreAffaires.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.bRQuitter);
            this.panel1.Controls.Add(this.bRAssemblage);
            this.panel1.Controls.Add(this.bRVente);
            this.panel1.Controls.Add(this.lblChiffreAffaires);
            this.panel1.Controls.Add(this.lblChiffre);
            this.panel1.Controls.Add(this.bRCommande);
            this.panel1.Location = new System.Drawing.Point(847, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 561);
            this.panel1.TabIndex = 5;
            // 
            // bRQuitter
            // 
            this.bRQuitter.BackColor = System.Drawing.Color.Crimson;
            this.bRQuitter.Location = new System.Drawing.Point(187, 421);
            this.bRQuitter.Name = "bRQuitter";
            this.bRQuitter.Size = new System.Drawing.Size(121, 58);
            this.bRQuitter.TabIndex = 9;
            this.bRQuitter.Text = "➜] Quitter";
            this.bRQuitter.UseVisualStyleBackColor = false;
            this.bRQuitter.Click += new System.EventHandler(this.bRQuitter_Click);
            // 
            // bRAssemblage
            // 
            this.bRAssemblage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bRAssemblage.Location = new System.Drawing.Point(187, 275);
            this.bRAssemblage.Name = "bRAssemblage";
            this.bRAssemblage.Size = new System.Drawing.Size(121, 95);
            this.bRAssemblage.TabIndex = 7;
            this.bRAssemblage.Text = "🔧 Assembler une Arme";
            this.bRAssemblage.UseVisualStyleBackColor = false;
            this.bRAssemblage.Click += new System.EventHandler(this.bRAssemblage_Click);
            // 
            // bRVente
            // 
            this.bRVente.BackColor = System.Drawing.Color.SpringGreen;
            this.bRVente.Location = new System.Drawing.Point(15, 275);
            this.bRVente.Name = "bRVente";
            this.bRVente.Size = new System.Drawing.Size(121, 95);
            this.bRVente.TabIndex = 8;
            this.bRVente.Text = "+ Nouvelle Vente";
            this.bRVente.UseVisualStyleBackColor = false;
            this.bRVente.Click += new System.EventHandler(this.bRVente_Click);
            // 
            // bRCommande
            // 
            this.bRCommande.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bRCommande.Location = new System.Drawing.Point(15, 384);
            this.bRCommande.Name = "bRCommande";
            this.bRCommande.Size = new System.Drawing.Size(144, 95);
            this.bRCommande.TabIndex = 6;
            this.bRCommande.Text = "📦 Commander du Stock";
            this.bRCommande.UseVisualStyleBackColor = false;
            this.bRCommande.Click += new System.EventHandler(this.bRCommande_Click);
            // 
            // inventaireToolStripMenuItem
            // 
            this.inventaireToolStripMenuItem.Name = "inventaireToolStripMenuItem";
            this.inventaireToolStripMenuItem.Size = new System.Drawing.Size(330, 34);
            this.inventaireToolStripMenuItem.Text = "Inventaire";
            this.inventaireToolStripMenuItem.Click += new System.EventHandler(this.inventaireToolStripMenuItem_Click);
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1256, 740);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAlerte);
            this.Controls.Add(this.dgvAlertes);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FenetrePrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Armurerie TomCorp";
            this.Load += new System.EventHandler(this.FenetrePrincipale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bRQuitter;
        private System.Windows.Forms.Button bRAssemblage;
        private System.Windows.Forms.Button bRVente;
        private System.Windows.Forms.Button bRCommande;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneCompositionDarmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miHistoriqueDeVente;
        private System.Windows.Forms.ToolStripMenuItem inventaireToolStripMenuItem;
    }
}

