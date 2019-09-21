using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLAM2_Henri_LibClasses;

namespace SLAM2_HENRI_TP3_Application_CentreLoisirs
{
    public partial class FormAccueil : Form
    {
        //static string login, mdp;
        private List<ClassActivite> lesActivites;
        private List<ClassEnfant> lesEnfants;
        public FormAccueil()
        {
            InitializeComponent();

            //Instanciation de la liste lesActivites et lesEnfants
            lesActivites = new List<ClassActivite>();
            lesEnfants = new List<ClassEnfant>();

        }

        //Ajout d'une Activité dans la collection lesActivités       
        public void Ajout_Activite(ClassActivite uneActivite)
        {
            lesActivites.Add(uneActivite);
        }

        //Ajout d'un Enfant dans la collection lesEnfants       
        public void Ajout_Enfant(ClassEnfant unEnfant)
        {
            lesEnfants.Add(unEnfant);
        }

        private void ajoutDuneActivitéToolStripMenuItem_Click(object sender, EventArgs e)
        {     
            if (Application.OpenForms["FormAjoutActivite"] == null)
            {                
                FormAjoutActivite FA = new FormAjoutActivite(lesActivites);
                FA.MdiParent = this;
                FA.Show();
            }
        }


        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult fermerPage = MessageBox.Show("Voulez-vous vraiment quitter ?","Attention",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (fermerPage == DialogResult.Yes)
                this.Close();
        }

        private void gestionDesActivitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            FormConnexion FA = new FormConnexion();
            FA.MdiParent = this;
            FA.Show();*/
        }

        private void listeDesActivitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormListeActivites"] == null)
            {
                FormListeActivites FA = new FormListeActivites(lesActivites);
                FA.MdiParent = this;
                FA.Show();
            }
        }

        private void modificationSuppressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormModifActivite"] == null)
            {
                FormModifActivite FA = new FormModifActivite(lesActivites);
                FA.MdiParent = this;
                FA.Show();
            }
        }

        private void ajoutDunEnfantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormAjoutEnfant"] == null)
            {
                FormAjoutEnfant FA = new FormAjoutEnfant(lesEnfants);
                FA.MdiParent = this;
                FA.Show();
            }
        }

        private void inscriptionÀUneActivitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormInscriptionActivite"] == null)
            {
                FormInscriptionActivite FA = new FormInscriptionActivite(lesActivites,lesEnfants);
                FA.MdiParent = this;
                FA.Show();
            }
        }

        private void FormAccueil_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
