namespace BDD_Armurerie_TT_25_26
{
    partial class FenetreVente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreVente));
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bVClient = new System.Windows.Forms.Button();
            this.cmbArme = new System.Windows.Forms.ComboBox();
            this.numQuantite = new System.Windows.Forms.NumericUpDown();
            this.bVVente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(69, 47);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(237, 26);
            this.txtNom.TabIndex = 0;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(69, 131);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(237, 26);
            this.txtPrenom.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(69, 299);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(69, 215);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(237, 26);
            this.txtAdresse.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adresse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email : ";
            // 
            // bVClient
            // 
            this.bVClient.Location = new System.Drawing.Point(69, 367);
            this.bVClient.Name = "bVClient";
            this.bVClient.Size = new System.Drawing.Size(237, 44);
            this.bVClient.TabIndex = 8;
            this.bVClient.Text = "Valider le client";
            this.bVClient.UseVisualStyleBackColor = true;
            this.bVClient.Click += new System.EventHandler(this.bVClient_Click);
            // 
            // cmbArme
            // 
            this.cmbArme.FormattingEnabled = true;
            this.cmbArme.Location = new System.Drawing.Point(440, 131);
            this.cmbArme.Name = "cmbArme";
            this.cmbArme.Size = new System.Drawing.Size(121, 28);
            this.cmbArme.TabIndex = 9;
            // 
            // numQuantite
            // 
            this.numQuantite.Location = new System.Drawing.Point(440, 215);
            this.numQuantite.Name = "numQuantite";
            this.numQuantite.Size = new System.Drawing.Size(120, 26);
            this.numQuantite.TabIndex = 10;
            // 
            // bVVente
            // 
            this.bVVente.Location = new System.Drawing.Point(440, 299);
            this.bVVente.Name = "bVVente";
            this.bVVente.Size = new System.Drawing.Size(120, 48);
            this.bVVente.TabIndex = 11;
            this.bVVente.Text = "Valider la vente";
            this.bVVente.UseVisualStyleBackColor = true;
            this.bVVente.Click += new System.EventHandler(this.bVVente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Arme à vendre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quantité :";
            // 
            // FenetreVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bVVente);
            this.Controls.Add(this.numQuantite);
            this.Controls.Add(this.cmbArme);
            this.Controls.Add(this.bVClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FenetreVente";
            this.Text = "Nouvelle Vente";
            this.Load += new System.EventHandler(this.FenetreVente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bVClient;
        private System.Windows.Forms.ComboBox cmbArme;
        private System.Windows.Forms.NumericUpDown numQuantite;
        private System.Windows.Forms.Button bVVente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}