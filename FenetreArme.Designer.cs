namespace BDD_Armurerie_TT_25_26
{
    partial class FenetreArme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreArme));
            this.txtNom = new System.Windows.Forms.TextBox();
            this.numPrix = new System.Windows.Forms.NumericUpDown();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.numAlerte = new System.Windows.Forms.NumericUpDown();
            this.bAjouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlerte)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(100, 45);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(173, 26);
            this.txtNom.TabIndex = 0;
            // 
            // numPrix
            // 
            this.numPrix.Location = new System.Drawing.Point(100, 109);
            this.numPrix.Name = "numPrix";
            this.numPrix.Size = new System.Drawing.Size(173, 26);
            this.numPrix.TabIndex = 1;
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(100, 179);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(173, 26);
            this.numStock.TabIndex = 2;
            // 
            // numAlerte
            // 
            this.numAlerte.Location = new System.Drawing.Point(100, 247);
            this.numAlerte.Name = "numAlerte";
            this.numAlerte.Size = new System.Drawing.Size(173, 26);
            this.numAlerte.TabIndex = 3;
            // 
            // bAjouter
            // 
            this.bAjouter.Location = new System.Drawing.Point(100, 302);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(173, 71);
            this.bAjouter.TabIndex = 4;
            this.bAjouter.Text = "Ajouter l\'arme";
            this.bAjouter.UseVisualStyleBackColor = true;
            this.bAjouter.Click += new System.EventHandler(this.bAjouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom de l\'arme :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pirx de vente de l\'arme : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantité dans le stock :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alerte de recommande :";
            // 
            // FenetreArme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAjouter);
            this.Controls.Add(this.numAlerte);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.numPrix);
            this.Controls.Add(this.txtNom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FenetreArme";
            this.Text = "Ajout d\'une arme";
            ((System.ComponentModel.ISupportInitialize)(this.numPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlerte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.NumericUpDown numPrix;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.NumericUpDown numAlerte;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}