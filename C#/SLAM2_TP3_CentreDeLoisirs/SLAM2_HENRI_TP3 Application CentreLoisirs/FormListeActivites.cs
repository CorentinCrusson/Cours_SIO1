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
    public partial class FormListeActivites : Form
    {
        private List<ClassActivite> listeActivite;
        public FormListeActivites(List<ClassActivite> lesActivites)
        {
            InitializeComponent();
            this.listeActivite = lesActivites;
           
        }

        private void FormListeActivites_Load(object sender, EventArgs e)
        {
            //Remplissage de la Liste Box Activite
            string rowActivite;
            if (listeActivite.Count() > 0)
            {
                foreach (ClassActivite uneActivite in listeActivite)
                {
                    rowActivite = uneActivite.getNum() + " - " + uneActivite.getLibelle() + " - en datant du " + uneActivite.getDateAct() + " - "+uneActivite.getNbParticipants()+"/" + uneActivite.getNbMaxParticipants()+" participants";
                    lstBoxActivite.Items.Add(rowActivite);
                }
            }
            else
            {
                lstBoxActivite.Items.Add("Aucune Activite Enregistrée");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstBoxActivite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
