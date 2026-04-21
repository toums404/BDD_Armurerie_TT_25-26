namespace BDD_Armurerie_TT_25_26
{
    partial class FenetreAssemblage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreAssemblage));
            this.cmbArme = new System.Windows.Forms.ComboBox();
            this.numQuantite = new System.Windows.Forms.NumericUpDown();
            this.bAssembler = new System.Windows.Forms.Button();
            this.lstRecette = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbArme
            // 
            this.cmbArme.FormattingEnabled = true;
            this.cmbArme.Location = new System.Drawing.Point(48, 76);
            this.cmbArme.Name = "cmbArme";
            this.cmbArme.Size = new System.Drawing.Size(142, 28);
            this.cmbArme.TabIndex = 0;
            this.cmbArme.SelectedIndexChanged += new System.EventHandler(this.cmbArme_SelectedIndexChanged);
            // 
            // numQuantite
            // 
            this.numQuantite.Location = new System.Drawing.Point(48, 216);
            this.numQuantite.Name = "numQuantite";
            this.numQuantite.Size = new System.Drawing.Size(142, 26);
            this.numQuantite.TabIndex = 1;
            // 
            // bAssembler
            // 
            this.bAssembler.Location = new System.Drawing.Point(47, 345);
            this.bAssembler.Name = "bAssembler";
            this.bAssembler.Size = new System.Drawing.Size(143, 85);
            this.bAssembler.TabIndex = 2;
            this.bAssembler.Text = "Assembler l\'arme";
            this.bAssembler.UseVisualStyleBackColor = true;
            this.bAssembler.Click += new System.EventHandler(this.bAssembler_Click);
            // 
            // lstRecette
            // 
            this.lstRecette.FormattingEnabled = true;
            this.lstRecette.ItemHeight = 20;
            this.lstRecette.Location = new System.Drawing.Point(237, 46);
            this.lstRecette.Name = "lstRecette";
            this.lstRecette.Size = new System.Drawing.Size(215, 384);
            this.lstRecette.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Arme a assembler :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantité :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pièces nécessaires : ";
            // 
            // FenetreAssemblage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRecette);
            this.Controls.Add(this.bAssembler);
            this.Controls.Add(this.numQuantite);
            this.Controls.Add(this.cmbArme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FenetreAssemblage";
            this.Text = "Assembleur d\'arme";
            this.Load += new System.EventHandler(this.FenetreAssemblage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbArme;
        private System.Windows.Forms.NumericUpDown numQuantite;
        private System.Windows.Forms.Button bAssembler;
        private System.Windows.Forms.ListBox lstRecette;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}