namespace BDD_Armurerie_TT_25_26
{
    partial class FenetreComposition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreComposition));
            this.cmbArme = new System.Windows.Forms.ComboBox();
            this.cmbPiece1 = new System.Windows.Forms.ComboBox();
            this.cmbPiece3 = new System.Windows.Forms.ComboBox();
            this.cmbPiece2 = new System.Windows.Forms.ComboBox();
            this.cmbPiece4 = new System.Windows.Forms.ComboBox();
            this.numQte1 = new System.Windows.Forms.NumericUpDown();
            this.numQte2 = new System.Windows.Forms.NumericUpDown();
            this.numQte3 = new System.Windows.Forms.NumericUpDown();
            this.numQte4 = new System.Windows.Forms.NumericUpDown();
            this.bAddPiece = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstRecetteTemp = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bValiderPanier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQte3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQte4)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbArme
            // 
            this.cmbArme.FormattingEnabled = true;
            this.cmbArme.Location = new System.Drawing.Point(119, 51);
            this.cmbArme.Name = "cmbArme";
            this.cmbArme.Size = new System.Drawing.Size(142, 28);
            this.cmbArme.TabIndex = 0;
            // 
            // cmbPiece1
            // 
            this.cmbPiece1.FormattingEnabled = true;
            this.cmbPiece1.Location = new System.Drawing.Point(49, 115);
            this.cmbPiece1.Name = "cmbPiece1";
            this.cmbPiece1.Size = new System.Drawing.Size(159, 28);
            this.cmbPiece1.TabIndex = 1;
            // 
            // cmbPiece3
            // 
            this.cmbPiece3.FormattingEnabled = true;
            this.cmbPiece3.Location = new System.Drawing.Point(49, 221);
            this.cmbPiece3.Name = "cmbPiece3";
            this.cmbPiece3.Size = new System.Drawing.Size(159, 28);
            this.cmbPiece3.TabIndex = 2;
            // 
            // cmbPiece2
            // 
            this.cmbPiece2.FormattingEnabled = true;
            this.cmbPiece2.Location = new System.Drawing.Point(49, 172);
            this.cmbPiece2.Name = "cmbPiece2";
            this.cmbPiece2.Size = new System.Drawing.Size(159, 28);
            this.cmbPiece2.TabIndex = 3;
            // 
            // cmbPiece4
            // 
            this.cmbPiece4.FormattingEnabled = true;
            this.cmbPiece4.Location = new System.Drawing.Point(49, 272);
            this.cmbPiece4.Name = "cmbPiece4";
            this.cmbPiece4.Size = new System.Drawing.Size(159, 28);
            this.cmbPiece4.TabIndex = 4;
            // 
            // numQte1
            // 
            this.numQte1.Location = new System.Drawing.Point(233, 116);
            this.numQte1.Name = "numQte1";
            this.numQte1.Size = new System.Drawing.Size(120, 26);
            this.numQte1.TabIndex = 5;
            // 
            // numQte2
            // 
            this.numQte2.Location = new System.Drawing.Point(233, 173);
            this.numQte2.Name = "numQte2";
            this.numQte2.Size = new System.Drawing.Size(120, 26);
            this.numQte2.TabIndex = 6;
            // 
            // numQte3
            // 
            this.numQte3.Location = new System.Drawing.Point(233, 222);
            this.numQte3.Name = "numQte3";
            this.numQte3.Size = new System.Drawing.Size(120, 26);
            this.numQte3.TabIndex = 7;
            // 
            // numQte4
            // 
            this.numQte4.Location = new System.Drawing.Point(233, 273);
            this.numQte4.Name = "numQte4";
            this.numQte4.Size = new System.Drawing.Size(120, 26);
            this.numQte4.TabIndex = 8;
            // 
            // bAddPiece
            // 
            this.bAddPiece.Location = new System.Drawing.Point(119, 336);
            this.bAddPiece.Name = "bAddPiece";
            this.bAddPiece.Size = new System.Drawing.Size(142, 88);
            this.bAddPiece.TabIndex = 9;
            this.bAddPiece.Text = "Ajouter au panier";
            this.bAddPiece.UseVisualStyleBackColor = true;
            this.bAddPiece.Click += new System.EventHandler(this.bAddPiece_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pièce et quantité :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Arme a composer :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pièce et quantité :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pièce et quantité :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pièce et quantité :";
            // 
            // lstRecetteTemp
            // 
            this.lstRecetteTemp.FormattingEnabled = true;
            this.lstRecetteTemp.ItemHeight = 20;
            this.lstRecetteTemp.Location = new System.Drawing.Point(392, 38);
            this.lstRecetteTemp.Name = "lstRecetteTemp";
            this.lstRecetteTemp.Size = new System.Drawing.Size(246, 264);
            this.lstRecetteTemp.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Panier :";
            // 
            // bValiderPanier
            // 
            this.bValiderPanier.Location = new System.Drawing.Point(444, 336);
            this.bValiderPanier.Name = "bValiderPanier";
            this.bValiderPanier.Size = new System.Drawing.Size(142, 88);
            this.bValiderPanier.TabIndex = 17;
            this.bValiderPanier.Text = "Valider le panier";
            this.bValiderPanier.UseVisualStyleBackColor = true;
            this.bValiderPanier.Click += new System.EventHandler(this.bValiderPanier_Click);
            // 
            // FenetreComposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.bValiderPanier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstRecetteTemp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAddPiece);
            this.Controls.Add(this.numQte4);
            this.Controls.Add(this.numQte3);
            this.Controls.Add(this.numQte2);
            this.Controls.Add(this.numQte1);
            this.Controls.Add(this.cmbPiece4);
            this.Controls.Add(this.cmbPiece2);
            this.Controls.Add(this.cmbPiece3);
            this.Controls.Add(this.cmbPiece1);
            this.Controls.Add(this.cmbArme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FenetreComposition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Composer une nouvelle arme";
            this.Load += new System.EventHandler(this.FenetreComposition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQte2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQte3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQte4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbArme;
        private System.Windows.Forms.ComboBox cmbPiece1;
        private System.Windows.Forms.ComboBox cmbPiece3;
        private System.Windows.Forms.ComboBox cmbPiece2;
        private System.Windows.Forms.ComboBox cmbPiece4;
        private System.Windows.Forms.NumericUpDown numQte1;
        private System.Windows.Forms.NumericUpDown numQte2;
        private System.Windows.Forms.NumericUpDown numQte3;
        private System.Windows.Forms.NumericUpDown numQte4;
        private System.Windows.Forms.Button bAddPiece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstRecetteTemp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bValiderPanier;
    }
}