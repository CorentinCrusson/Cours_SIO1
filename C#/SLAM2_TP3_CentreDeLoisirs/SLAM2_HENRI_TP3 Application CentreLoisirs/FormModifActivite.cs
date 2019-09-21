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
    public partial class FormModifActivite : Form
    {
        private List<ClassActivite> listeActivite;
        private string rowActivite;

        public FormModifActivite(List<ClassActivite> lesActivites)
        {
            InitializeComponent();
            this.listeActivite = lesActivites;            
        }

        private void FormModifActivite_Load(object sender, EventArgs e)
        {
            //On vide la combo box
            cb_Activite.Items.Clear();

            //On initialise les forms avec les valeurs dans la liste Activite
            int tailleListeActivite = listeActivite.Count();
            if (tailleListeActivite == 0)
            {
                cb_Activite.Items.Add("Aucune activité enregistrée");
                grpBoxChoix.Visible = false;
                grpBoxInfos.Visible = false;
            }
            else
            {
                //GroupBox de l'Activité
                foreach (ClassActivite uneActivite in listeActivite)
                {
                    rowActivite = uneActivite.getNum() + " - " + uneActivite.getLibelle() + " - en datant du " + uneActivite.getDateAct() + " - " + uneActivite.getNbParticipants() + "/" + uneActivite.getNbMaxParticipants() + " participants";
                    cb_Activite.Items.Add(rowActivite);
                }
            }
        }

        /* ----------------------------------------
                ENREGISTRER LES MODIFICATIONS
           ---------------------------------------- */
        private void btn_Enregistrer_Click(object sender, EventArgs e)
        {
            if (cb_Activite.SelectedIndex != -1)
            {
                string resume = "La modification s'est bien passé récapitulatif : \n ";
                int index = cb_Activite.SelectedIndex;

                listeActivite[index].setDateAct(dateBoxAct.Value.ToShortDateString());
                resume += ("\nNouvelle Date : " + listeActivite[index].getDateAct());

                if (txtBoxLibelle.Text != "")
                {
                    listeActivite[index].setLibelleActivite(txtBoxLibelle.Text);
                    resume += ("\nNouveau Libelle : " + listeActivite[index].getLibelle());
                }

                if(txtBoxNbMax.Text != "")
                {
                    listeActivite[index].setNbMaxPart(int.Parse(txtBoxNbMax.Text));
                    resume += ("\nNouveau nombre max de participants : " + listeActivite[index].getNbMaxParticipants());
                }

                //Résume du renseignement des champs de saisie
                DialogResult resumeAct = MessageBox.Show(resume, "Résume de l'activité", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormModifActivite_Load(this, null);

                cb_Activite.SelectedIndex = index;
            }
            else
            {
                DialogResult resumeAct = MessageBox.Show("L'activité n'a pas été saisie", "Erreur de Saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* ----------------------------------
                MODIFICATION ACTIVITÉ
           ---------------------------------- */
        private void btnModifAct_CheckedChanged(object sender, EventArgs e)
        {
            grpBoxInfos.Visible = true;
        }

        /* --------------------------------
                SUPPRESION ACTIVITÉ
           -------------------------------- */
        private void btnSupprAct_CheckedChanged(object sender, EventArgs e)
        {
            //On vérifie si le btnSuppr est bien séléctionné pour éviter des erreurs;
            if (btnSupprAct.Checked)
            {
                grpBoxInfos.Visible = false;
                int index = cb_Activite.SelectedIndex;
                if (index != -1)
                {
                    DialogResult resumeAct = MessageBox.Show(" - "+listeActivite[index].getLibelle(), "Confirmez vous la suppression de  l'activité : ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resumeAct == DialogResult.Yes)
                    {
                        listeActivite.RemoveAt(index);
                        FormModifActivite_Load(this, null);
                    }
                }
                else
                {
                    DialogResult resumeAct = MessageBox.Show("L'activité n'a pas été saisie", "Erreur de Saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /* --------------------------------
                ETAT SELECTION ACTIVITÉ
           -------------------------------- */
        private void cb_Activite_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ClassActivite uneActivite in listeActivite) { 
                if (uneActivite.getNum() == cb_Activite.SelectedIndex+1)
                txtBoxNum.Text = uneActivite.getNum().ToString();
            }

        }
    }
}
