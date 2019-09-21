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
    public partial class FormAjoutActivite : Form
    {
        static int numAct;
        ClassActivite UneActivite;
        public FormAjoutActivite(List<ClassActivite> listeDesActivites)
        {
            InitializeComponent();
            if (listeDesActivites.Count() == 0)
                numAct = 1;
            else
                numAct = (listeDesActivites.Count()+1);
            textBox_numAct.Text = numAct.ToString();
            //rad = 0;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            //On vérifie si les champs ont bien étés saisies
            if (textBox_lblAct.Text != "")
            {
                string resume = "L'ajout s'est bien passé récapitulatif : \n ";

                //Instanciation avec les valeurs saisies de l'objet ClassActivite
                UneActivite = new ClassActivite(int.Parse(textBox_numAct.Text), textBox_lblAct.Text, datePicker_dateAct.Value.ToShortDateString());

                //On vérifie si les autres champs ont étés saisies et on les ajoute à ClassActivite
                resume += "\nNuméro de l'activité : "+ UneActivite.getNum() + "\nLibelllé de l'activité : " + UneActivite.getLibelle() + "\nDate de l'activité : " + UneActivite.getDateAct();
                if (comboBox_anim.SelectedIndex != -1)
                {
                    UneActivite.setAnimateur(comboBox_anim.SelectedText);
                    resume += ("\nAnimateur : " + comboBox_anim.SelectedItem.ToString());
                }

                if (radioBtn_t1.Checked)
                {
                    UneActivite.setTrancheAge(1);
                    resume += ("\nTranche d'âge : 3-6 ans");
                }
                else if (radioBtn_t2.Checked)
                {
                    UneActivite.setTrancheAge(2);
                    resume += ("\nTranche d'âge : 7-11 ans");
                }
                else if (radioBtn_t3.Checked)
                {
                    UneActivite.setTrancheAge(3);
                    resume += ("\nTranche d'âge : 12-15 ans");
                }
                else if (radioBtn_t4.Checked)
                {
                    UneActivite.setTrancheAge(4);
                    resume += ("\nTranche d'âge : +15 ans");
                }
                
                if (numUpDown_nbMax.Value>=0)
                {
                    UneActivite.setNbMaxPart((int)numUpDown_nbMax.Value);
                    resume += ("\nNombre de Places Max : ") + numUpDown_nbMax.Value;
                }
                
                //Résume du renseignement des champs de saisie
                DialogResult resumeAct = MessageBox.Show(resume, "Résume de l'activité", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //Ajout de l'activité dans le Form Accueil
                ((FormAccueil)(this.MdiParent)).Ajout_Activite(UneActivite);

                //Réinitialisation des champs de saisie
                Reset();
                numAct += 1;
                textBox_numAct.ResetText();
                textBox_numAct.Text = numAct.ToString();

            }
            else
            {
                DialogResult resumeAct = MessageBox.Show("Le libellé n'a pas été saisie", "Erreur de Saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Reset()
        {
            textBox_lblAct.ResetText();

            radioBtn_t1.Checked = false;
            radioBtn_t2.Checked = false;
            radioBtn_t3.Checked = false;
            radioBtn_t4.Checked = false;

            comboBox_anim.SelectedIndex = -1;

            datePicker_dateAct.Value = DateTime.Today;

            numUpDown_nbMax.Value = 0;

            textBox_lblAct.Focus();
        }
    }
}
