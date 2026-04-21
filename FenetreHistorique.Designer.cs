namespace BDD_Armurerie_TT_25_26
{
    partial class FenetreHistorique
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreHistorique));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvVentes = new System.Windows.Forms.DataGridView();
            this.bGenererFacture = new System.Windows.Forms.Button();
            this.dgvCommandes = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bGenererFacture);
            this.tabPage1.Controls.Add(this.dgvVentes);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Historique des ventes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvCommandes);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Commande fournisseur";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvVentes
            // 
            this.dgvVentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVentes.Location = new System.Drawing.Point(3, 3);
            this.dgvVentes.Name = "dgvVentes";
            this.dgvVentes.RowHeadersWidth = 62;
            this.dgvVentes.RowTemplate.Height = 28;
            this.dgvVentes.Size = new System.Drawing.Size(786, 335);
            this.dgvVentes.TabIndex = 2;
            // 
            // bGenererFacture
            // 
            this.bGenererFacture.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bGenererFacture.Location = new System.Drawing.Point(3, 344);
            this.bGenererFacture.Name = "bGenererFacture";
            this.bGenererFacture.Size = new System.Drawing.Size(786, 70);
            this.bGenererFacture.TabIndex = 3;
            this.bGenererFacture.Text = "Générer une facture au format .txt";
            this.bGenererFacture.UseVisualStyleBackColor = true;
            this.bGenererFacture.Click += new System.EventHandler(this.bGenererFacture_Click);
            // 
            // dgvCommandes
            // 
            this.dgvCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommandes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCommandes.Location = new System.Drawing.Point(3, 3);
            this.dgvCommandes.Name = "dgvCommandes";
            this.dgvCommandes.RowHeadersWidth = 62;
            this.dgvCommandes.RowTemplate.Height = 28;
            this.dgvCommandes.Size = new System.Drawing.Size(786, 411);
            this.dgvCommandes.TabIndex = 0;
            // 
            // FenetreHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FenetreHistorique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historique de vente";
            this.Load += new System.EventHandler(this.FenetreHistorique_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bGenererFacture;
        private System.Windows.Forms.DataGridView dgvVentes;
        private System.Windows.Forms.DataGridView dgvCommandes;
    }
}