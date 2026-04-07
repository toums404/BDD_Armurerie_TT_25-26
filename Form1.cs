using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDD_Armurerie_TT_25_26.DAL;
using BDD_Armurerie_TT_25_26.Entites;

namespace BDD_Armurerie_TT_25_26
{
    public partial class FenetrePrincipale : Form
    {
        public FenetrePrincipale()
        {
            InitializeComponent();
        }

        private void FenetrePrincipale_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    // 1. On instancie la DAL
            //    FournisseurDAL dalTest = new FournisseurDAL();

            //    // 2. On tente de récupérer les données
            //    List<Fournisseur> liste = dalTest.GetLesFournisseurs();

            //    // 3. On affiche le résultat dans une petite boîte de dialogue
            //    if (liste.Count > 0)
            //    {
            //        MessageBox.Show($"SUCCÈS TOTAL ! 🎉\nLa connexion marche et j'ai trouvé {liste.Count} fournisseur(s) !\nLe premier est : {liste[0].NomSociete}");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Connexion réussie ! 🟢\nMais la table est vide, tu n'as pas ajouté de données de test.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // Si la connexion plante, l'application ne crashera pas, elle affichera l'erreur ici !
            //    MessageBox.Show("Aïe, erreur de connexion 🔴 :\n\n" + ex.Message);
            //}

        }
    }
}
