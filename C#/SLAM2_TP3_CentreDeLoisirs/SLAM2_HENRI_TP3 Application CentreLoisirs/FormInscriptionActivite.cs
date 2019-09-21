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
    public partial class FormInscriptionActivite : Form
    {
        private List<ClassActivite> listeActivites;
        private List<ClassEnfant> listeEnfants;
        bool activiteChoisie = true, enfantChoisi = true;
        public FormInscriptionActivite(List<ClassActivite> lesActivites, List<ClassEnfant> lesEnfants)
        {
            InitializeComponent();
            this.listeActivites = lesActivites;
            this.listeEnfants = lesEnfants;
        }

        private void FormInscriptionActivite_Load(object sender, EventArgs e)
        {
            string row;

            //Remplissage de la Liste Box Activite
            if (listeActivites.Count() > 0)
            {
                foreach (ClassActivite uneActivite in listeActivites)
                {
                    row = uneActivite.getNum() + " - " + uneActivite.getLibelle() + " - en datant du " + uneActivite.getDateAct() + " - " + uneActivite.getNbParticipants() + "/" + uneActivite.getNbMaxParticipants() + " participants";
                    cb_act.Items.Add(row);
                }
            }
            else
            {
                cb_act.Items.Add("Aucune Activite Enregistrée");
                activiteChoisie = false;
            }

            //Remplissage de la Liste Box Enfant
            if (listeEnfants.Count() > 0)
            {
                foreach (ClassEnfant unEnfant in listeEnfants)
                {
                    row = unEnfant.getNum() + " - " + unEnfant.getNom() + " " + unEnfant.getPrenom() + " - " + unEnfant.donneTrancheAge();
                    cb_enfant.Items.Add(row);
                }
            }
            else
            {
                cb_enfant.Items.Add("Aucun Enfant Enregistré");
                enfantChoisi = false;
            }
        }

        private void cb_act_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resumeInscription;
            if (cb_act.SelectedIndex != -1 && activiteChoisie)
            {
                ClassActivite uneActivite;
                uneActivite = listeActivites[cb_act.SelectedIndex];
                if (cb_enfant.SelectedIndex != -1 && enfantChoisi)
                {
                    ClassEnfant unEnfant = listeEnfants[cb_enfant.SelectedIndex];
                    if (uneActivite.AjouterUnParticipant(unEnfant))
                    {
                        resumeInscription = MessageBox.Show("Enfant Ajoutée à l'Activité", "AJOUT VALIDÉ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (unEnfant.getTrancheAge() != uneActivite.getTrancheAge())
                            resumeInscription = MessageBox.Show("La tranche d'âge de l'activité est de : "+uneActivite.getTrancheAge()+"\n\nAlors que l'enfant fait partir des "+unEnfant.getTrancheAge(), "ÂGE NON VALIDE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            resumeInscription = MessageBox.Show("Le nombre de participants est complet pour cette activité", "COMPLET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                        resumeInscription = MessageBox.Show("L'enfant à inscrire n'a pas été choisi", "Erreur de Saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                resumeInscription = MessageBox.Show("L'activité n'a pas été choisie", "Erreur de Saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
