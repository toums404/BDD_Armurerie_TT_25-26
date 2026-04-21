namespace BDD_Armurerie_TT_25_26
{
    partial class FenetreCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreCommande));
            this.cmbFournisseur = new System.Windows.Forms.ComboBox();
            this.cmbPiece = new System.Windows.Forms.ComboBox();
            this.numQuantite = new System.Windows.Forms.NumericUpDown();
            this.bCommander = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFournisseur
            // 
            this.cmbFournisseur.FormattingEnabled = true;
            this.cmbFournisseur.Location = new System.Drawing.Point(138, 65);
            this.cmbFournisseur.Name = "cmbFournisseur";
            this.cmbFournisseur.Size = new System.Drawing.Size(157, 28);
            this.cmbFournisseur.TabIndex = 0;
            // 
            // cmbPiece
            // 
            this.cmbPiece.FormattingEnabled = true;
            this.cmbPiece.Location = new System.Drawing.Point(137, 133);
            this.cmbPiece.Name = "cmbPiece";
            this.cmbPiece.Size = new System.Drawing.Size(158, 28);
            this.cmbPiece.TabIndex = 1;
            // 
            // numQuantite
            // 
            this.numQuantite.Location = new System.Drawing.Point(138, 204);
            this.numQuantite.Name = "numQuantite";
            this.numQuantite.Size = new System.Drawing.Size(157, 26);
            this.numQuantite.TabIndex = 2;
            // 
            // bCommander
            // 
            this.bCommander.Location = new System.Drawing.Point(137, 261);
            this.bCommander.Name = "bCommander";
            this.bCommander.Size = new System.Drawing.Size(158, 72);
            this.bCommander.TabIndex = 3;
            this.bCommander.Text = "Commander";
            this.bCommander.UseVisualStyleBackColor = true;
            this.bCommander.Click += new System.EventHandler(this.bCommander_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choix du fournisseur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choix de la pièce :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantitée désirée :";
            // 
            // FenetreCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCommander);
            this.Controls.Add(this.numQuantite);
            this.Controls.Add(this.cmbPiece);
            this.Controls.Add(this.cmbFournisseur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FenetreCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commande a un fournisseur ";
            this.Load += new System.EventHandler(this.FenetreCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFournisseur;
        private System.Windows.Forms.ComboBox cmbPiece;
        private System.Windows.Forms.NumericUpDown numQuantite;
        private System.Windows.Forms.Button bCommander;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}