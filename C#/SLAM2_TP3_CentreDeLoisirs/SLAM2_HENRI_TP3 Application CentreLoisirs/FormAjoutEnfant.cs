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
    public partial class FormAjoutEnfant : Form
    {
        static string resume;
        static int t_age, numE;
        ClassEnfant unEnfant;
        RadioButton rb;

        public FormAjoutEnfant(List<ClassEnfant> listeLesEnfants)
        {
            InitializeComponent();

            if (listeLesEnfants.Count() == 0)
                numE = 1;
            else
                numE = (listeLesEnfants.Count() + 1);
            txtBox_numE.Text = numE.ToString();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            DialogResult resumeEnfant;

            //On vérifie si les champs ont bien étés saisies
            if (txtBox_nomE.Text == "")
            {
                resumeEnfant = MessageBox.Show("Le nom de l'enfant n'a pas été saisi", "Erreur de Saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtBox_prenomE.Text == "")
            {
                resumeEnfant = MessageBox.Show("Le prénom de l'enfant n'a pas été saisi", "Erreur de Saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //On cherche quel bouton radio est check
                foreach (Control c in grpBox_trancheAge.Controls)
                {
                    if (c.GetType() == typeof(RadioButton))
                    {
                        rb = c as RadioButton;
                        if (rb.Checked)
                        {
                            switch(rb.Text)
                            {
                                case "3-6 ans":
                                    t_age = 1;
                                    break;
                                case "7-11 ans":
                                    t_age = 2;
                                    break;
                                case "12-15 ans":
                                    t_age = 3;
                                    break;
                                case "+15 ans":
                                    t_age = 4;
                                    break;

                            }
                        }
                    }
                }

                //Instanciation avec les valeurs saisies de l'objet ClassEnfant
                unEnfant = new ClassEnfant(int.Parse(txtBox_numE.Text), txtBox_nomE.Text, txtBox_prenomE.Text, t_age);

                resume += "\n Numéro de l'enfant : " + unEnfant.getNum() + "\n Nom de l'enfant : " + unEnfant.getNom() + "\n Prénom de l'enfant : " + unEnfant.getPrenom()+ "\n Tranche d'âge : " + unEnfant.donneTrancheAge();
            
                //Résume du renseignement des champs de saisie
                resumeEnfant = MessageBox.Show(resume, "Résume de l'Inscription", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Ajout de l'enfant dans le Form Accueil
                ((FormAccueil)(this.MdiParent)).Ajout_Enfant(unEnfant);

                //Réinitialisation du numéro de l'enfant
                Reset();
                numE += 1;
                txtBox_numE.ResetText();
                txtBox_numE.Text = numE.ToString();

                resume = "";
        }
    }
        public void Reset()
        {
            txtBox_nomE.ResetText();
            txtBox_prenomE.ResetText();

            rb.Checked = false;
            radioBtn_t1.Checked = true;
            
            txtBox_nomE.Focus();
        }
    }
}
