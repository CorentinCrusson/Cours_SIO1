using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLAM2_tp5_libClasses;
using DataAccesLibrary;

namespace SLAM2_TP5_EpisodesSaisonsSeries
{
    public partial class FormAccueil : Form
    {
        //PROPRIETES
        private List<Serie> lesSeries;

        /* Fonction permettant l'instanciation du Form Accueil */
        public FormAccueil()
        {
            InitializeComponent();

            //Instanciation des listes
            lesSeries = new List<Serie>();

            Serie s = new Serie(1, "Umbrella Academy", "Oublie");
            lesSeries.Add(s);
            s.AjouteSaison(1, 2017, 8);
            s.getLesSaisons()[0].AjouteEpisode(1, "Episode 1 - L'introduction", 60);

            MessageBox.Show(s.ToString());

            Serie s1 = new Serie(2, "Black Summer", "Inconnue");
            lesSeries.Add(s1);
            s1.AjouteSaison(1, 2019, 6);
            s1.AjouteSaison(2, 2020, 10);
            s1.getLesSaisons()[0].AjouteEpisode(1, "Episode 1 - L'arrivée des zombiess", 180);
            s1.getLesSaisons()[1].AjouteEpisode(1, "Episode 1 - [En cours de production]", 80);

            Serie s2 = new Serie(3, "La casa de papel", " El Miguel");
            lesSeries.Add(s2);
            s2.AjouteSaison(1, 2015, 10);
            s2.getLesSaisons()[0].AjouteEpisode(1, "Episode 1 - Le braquage", 50);
            s2.getLesSaisons()[0].AjouteEpisode(2, "Episode 2 - Le sacrifice", 30);
            s2.AjouteSaison(2, 2017, 11);
            s2.getLesSaisons()[1].AjouteEpisode(1, "Episode 1 - La sortie en moto", 60);
            s2.AjouteSaison(3, 2019, 12);
            s2.getLesSaisons()[2].AjouteEpisode(1, "Episode 1 - Les Retrouvailles", 100);

            //Affichage Informations - Les Series
            foreach (Serie laSerie in lesSeries)
            {
                cb_SerieCourante.Items.Add(laSerie.getTitre());
                cb_SerieAssociee.Items.Add(laSerie.getTitre());
                cb_SerieAssocieeEp.Items.Add(laSerie.getTitre());
            };

            if (cb_SerieCourante.SelectedIndex == -1)
                cb_SerieCourante.SelectedIndex = 0;

            //Affichage Informations -  Les Saisons
            for (int i = 1; i <= lesSeries[cb_SerieCourante.SelectedIndex].nbSaisons(); i++)
            {
                cb_SaisonCourante.Items.Add(i);
                cb_SaisonAssocieeEp.Items.Add(i);
            }

            if (cb_SaisonCourante.SelectedIndex == -1)
                cb_SaisonCourante.SelectedIndex = 0;
            cb_choixAjout.SelectedIndex = 0;

            //INITIALISATION BDD
            DataAccess.InitializeDatabase();

        }

        /*-------------------------------------------------------------------------------
        ------------------------ Fonction LOAD --------------------------------------------
        --------------------------------------------------------------------------------*/
        private void FormAccueil_Load(object sender, EventArgs e)
        {
            if (!(FormAccueil.ActiveForm is null)) {
                affichageSerie();

                if (cb_SaisonCourante.Items.Count != 0)
                {
                    if (cb_SaisonCourante.SelectedIndex == -1)
                        cb_SaisonCourante.SelectedIndex = 0;
                    else
                        affichageSaison();
                }
            }
        }

        /*--------------------------------------------------------------------------------------------------------------------------------------------
         -------------- Listes Déroulantes donnant des informations sur la saison sélectionnée de la série sélectionnée -------------------------------
         -----------------------------------------------------------------------------------------------------------------------------------------*/
        private void cb_SerieCourante_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Affichage Informations -  Les Saisons
            if (lesSeries[cb_SerieCourante.SelectedIndex].getLesSaisons().Count != 0)
            {
                cb_SaisonCourante.Items.Clear();
                for (int i = 1; i <= lesSeries[cb_SerieCourante.SelectedIndex].nbSaisons(); i++)
                {
                    cb_SaisonCourante.Items.Add(i);
                }

                FormAccueil_Load(null, null);
            }
            else
            {
                cb_SaisonCourante.Items.Clear();
            }
        }

        private void cb_SaisonCourante_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormAccueil_Load(null, null);
        }

        //Bouton GESTION DES EPISODES
        private void button1_Click(object sender, EventArgs e)
        {
                FormEpisode FA = new FormEpisode(lesSeries);
                FA.ShowDialog();
        }


        /*----------------------------------------------------------------------------------------------------------------
        ----------------------------- AJOUTS Serie | Saison | Episode -----------------------------------------------------
        ------------------------------------------------------------------------------------------------------------------*/

        //---------------- SERIE ------------------------------------------
        private void btn_ajoutSerie_Click(object sender, EventArgs e)
        {
            DialogResult message;
            if (txtBox_numSerie.Text=="")
            {
                message = MessageBox.Show("Vous n'avez pas rentrer le numéro de la série", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ( estDedansSerie(lesSeries,int.Parse(txtBox_numSerie.Text)) )
            {
                message = MessageBox.Show("Ce numéro de Série existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtBox_titreSerie.Text=="")
            {
                message = MessageBox.Show("Vous n'avez pas rentrer le titre de la série", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtBox_realisateur.Text == "")
            {
                message = MessageBox.Show("Vous n'avez pas rentrer le nom du réalisateur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int indexSerie = int.Parse(txtBox_numSerie.Text);
                Serie uneSerie = new Serie(indexSerie, txtBox_titreSerie.Text, txtBox_realisateur.Text);
                lesSeries.Add(uneSerie);

                //Affichage Informations - Les Series
                cb_SerieCourante.Items.Clear();
                cb_SerieAssociee.Items.Clear();
                cb_SerieAssocieeEp.Items.Clear();
                foreach (Serie laSerie in lesSeries)
                {
                    cb_SerieCourante.Items.Add(laSerie.getTitre());
                    cb_SerieAssociee.Items.Add(laSerie.getTitre());
                    cb_SerieAssocieeEp.Items.Add(laSerie.getTitre());
                };

                if (cb_SerieCourante.SelectedIndex == -1)
                    cb_SerieCourante.SelectedIndex = indexSerie-1;

                //Récapitualif
                
                message = MessageBox.Show("Récapitulatif : \nTitre de la Série : " + lesSeries[indexSerie-1].getTitre
                       () + "\nRéalisateur de la Série : " + lesSeries[indexSerie-1].getRealisateur(), "Ajout Validé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                affichageSerie();
            }
        }


        //---------------- SAISON ------------------------------------------

        private void btn_ajoutSaison_Click(object sender, EventArgs e)
        {
            DialogResult message;
            if (cb_SerieAssociee.SelectedIndex==-1)
            {
                message = MessageBox.Show("Vous n'avez pas rentrer la Série à Associer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtBox_numSaison.Text == "")
            {
                message = MessageBox.Show("Vous n'avez pas rentrer le numéro de la saison", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtBox_nbEpsPrevus.Text == "")
            {
                message = MessageBox.Show("Vous n'avez pas rentrer le nombre d'épisodes prévus", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            else if (txtBox_annee.Text=="")
            {
                message = MessageBox.Show("Vous n'avez pas rentrer l'année de la Saison", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int numSaison = int.Parse(txtBox_numSaison.Text);

                if (estDedansSaison(lesSeries[cb_SerieAssociee.SelectedIndex].getLesSaisons(), numSaison))
                {
                    lesSeries[cb_SerieAssociee.SelectedIndex].modifierSaison(numSaison, int.Parse(txtBox_annee.Text), int.Parse(txtBox_nbEpsPrevus.Text), lesSeries[cb_SerieAssociee.SelectedIndex].getLesSaisons()[numSaison-1]);
                }
                else
                {
                    lesSeries[cb_SerieAssociee.SelectedIndex].AjouteSaison(int.Parse(txtBox_numSaison.Text), int.Parse(txtBox_annee.Text), int.Parse(txtBox_nbEpsPrevus.Text));
                }

                //Affichage Informations -  Les Saisons
                cb_SaisonCourante.Items.Clear();
                cb_SaisonAssocieeEp.Items.Clear();
                for (int i = 1; i <= lesSeries[cb_SerieCourante.SelectedIndex].nbSaisons(); i++)
                {
                    cb_SaisonCourante.Items.Add(i);
                    cb_SaisonAssocieeEp.Items.Add(i);
                }

                message = MessageBox.Show(("Récapitulatif : \nSérie Associée : "+lesSeries[cb_SerieAssociee.SelectedIndex].getTitre
                    ()+"\nNuméro de Saison : "+txtBox_numSaison.Text+"\nNombres d'épisodes prévus : "+txtBox_nbEpsPrevus.Text+"\nAnnée de la Saison : "+txtBox_annee.Text), "Ajout Validé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                affichageSerie();

            }
        }


        //---------------- EPISODE ------------------------------------------

        private void btn_ajoutEpisode_Click(object sender, EventArgs e)
        {
            DialogResult message;
            if (cb_SerieAssocieeEp.SelectedIndex == -1)
            {
                message = MessageBox.Show("Vous n'avez pas rentrer la Série à Associer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cb_SaisonAssocieeEp.SelectedIndex == -1)
            {
                message = MessageBox.Show("Vous n'avez pas rentrer la Saison à Associer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtBox_ajoutNumEp.Text=="")
            {
                message = MessageBox.Show("Vous n'avez pas rentrer le Numéro de l'épisode", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtBox_ajoutTitreEp.Text == "")
            {
                message = MessageBox.Show("Vous n'avez pas rentrer le Titre de l'épisode", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtBox_ajoutDureeEp.Text == "")
            {
                message = MessageBox.Show("Vous n'avez pas rentrer la Durée de l'épisode", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int indexSaison = cb_SaisonAssocieeEp.SelectedIndex;
                int numEpisode = int.Parse(txtBox_ajoutNumEp.Text);
                if (estDedansEpisode(lesSeries[cb_SerieAssocieeEp.SelectedIndex].getLesSaisons()[indexSaison].getLesEpisodes(), numEpisode))
                {
                    lesSeries[cb_SerieAssocieeEp.SelectedIndex].getLesSaisons()[indexSaison].ModifierEpisode(numEpisode, txtBox_ajoutTitreEp.Text, int.Parse(txtBox_ajoutDureeEp.Text), lesSeries[cb_SerieAssocieeEp.SelectedIndex].getLesSaisons()[indexSaison].getLesEpisodes()[numEpisode-1]);

                }
                else
                {
                    lesSeries[cb_SerieAssocieeEp.SelectedIndex].getLesSaisons()[indexSaison].AjouteEpisode(int.Parse(txtBox_ajoutNumEp.Text), txtBox_ajoutTitreEp.Text, int.Parse(txtBox_ajoutDureeEp.Text));
                }

                message = MessageBox.Show(("Récapitulatif : \nSérie Associée : " + lesSeries[cb_SerieAssocieeEp.SelectedIndex].getTitre
                   () + "\nSaison Associée : "+ (indexSaison+1) + "\nNuméro de l'épisode : " + txtBox_ajoutNumEp.Text + "\nNom de l'Épisode :  "+txtBox_ajoutTitreEp.Text+"\nDurée de l'Épisode : " + txtBox_ajoutDureeEp.Text), "Ajout Validé", MessageBoxButtons.OK, MessageBoxIcon.Information);

                affichageSerie();
                if (cb_SaisonCourante.Items.Count != 0)
                {
                    if (cb_SaisonCourante.SelectedIndex == -1)
                        cb_SaisonCourante.SelectedIndex = 0;
                    else
                        affichageSaison();
                }
            }
        }


        private void cb_SerieAssocieeEp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Affichage Informations -  Les Saisons
            if (cb_SaisonAssocieeEp.Items.Count != 0)
            {
                cb_SaisonAssocieeEp.Items.Clear();
                for (int i = 1; i <= lesSeries[cb_SerieAssocieeEp.SelectedIndex].nbSaisons(); i++)
                {
                    cb_SaisonAssocieeEp.Items.Add(i);
                }

                FormAccueil_Load(null, null);
            }
        }

        /*-------------------------------------------------------------------------------------------------------------------------
        ------------------------- FONCTIONS PERMETTANT DE VERIFIER SI LA SERIE/SAISON/EPISODE EXISTE DÉJÀ --------------------------------
        ---------------------------------------------------------------------------------------------------------------------------*/

        //------ Serie -------
        public bool estDedansSerie(List<Serie> lesSeries, int num)
        {
            foreach (Serie s in lesSeries)
            {
                if (s.getNumSerie() == num)
                    return true;
            }

            return false;
        }

        //------ Saison -------
        public bool estDedansSaison(List<Saison> lesSaisons,int num)
        {
            foreach (Saison sa in lesSaisons)
            {
                if (sa.getNumSaison() == num)
                    return true;
            }
                
            return false;
        }

        //------ Episode -------
        public bool estDedansEpisode(List<Episode> lesEpisodes, int num)
        {
            foreach (Episode e in lesEpisodes)
                if (e.getNumEpisode() == num)
                    return true;
            return false;
        }

        /*----------------------------------------------------------------------------------------------------------------------------------
        ------------------------- FONCTIONS PERMETTANT D'AFFICHER LES INFORMATIONS DE LA SAISON/EPISODE ----------------------------------
        -----------------------------------------------------------------------------------------------------------------------------------*/

        public void affichageSerie()
        {
            lbl_leRealisateur.Text = lesSeries[cb_SerieCourante.SelectedIndex].getRealisateur();
            lbl_leNbSsaisons.Text = lesSeries[cb_SerieCourante.SelectedIndex].nbSaisons().ToString();
        }
        public void affichageSaison()
        {
            lbl_lAnnee.Text = lesSeries[cb_SerieCourante.SelectedIndex].getLesSaisons()[cb_SaisonCourante.SelectedIndex].getAnnee().ToString();
            lbl_laDureeSaison.Text = lesSeries[cb_SerieCourante.SelectedIndex].getLesSaisons()[cb_SaisonCourante.SelectedIndex].dureeSaison().ToString();
            lbl_leNbEpisodesPrevus.Text = lesSeries[cb_SerieCourante.SelectedIndex].getLesSaisons()[cb_SaisonCourante.SelectedIndex].getNbEpisodesPrevus().ToString();
            lbl_leNbEpisodesDiff.Text = lesSeries[cb_SerieCourante.SelectedIndex].getLesSaisons()[cb_SaisonCourante.SelectedIndex].getLesEpisodes().Count.ToString();
        }

        private void lbl_dureeEp_Click(object sender, EventArgs e)
        {
            //
        }

        private void lbl_numEp_Click(object sender, EventArgs e)
        {
            //
        }

        /*----------------------------------------------------------------------------------------------------------------------------------
        ------------------------------ FONCTION GERANT LE CHOIX de l'ajout SERIE | SAISON | EPISODE -----------------------------------------
        -----------------------------------------------------------------------------------------------------------------------------------*/
        private void cb_choixAjout_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_choixAjout.SelectedIndex)
            {
                case 0:

                    //Affichage de la partie d'ajout SERIE
                    gb_episode.Visible = false;
                    gb_saison.Visible = false;
                    gb_serie.Visible = true;
                    gb_serie.Location = new Point(79, 527);
                    break;

                case 1:

                    //Affichage de la partie d'ajout SAISON
                    gb_episode.Visible = false;
                    gb_serie.Visible = false;
                    gb_saison.Visible = true;
                    gb_saison.Location = new Point(79, 527);

                    //--
                    cb_SerieAssociee.SelectedIndex = cb_SerieCourante.SelectedIndex;

                    break;

                case 2:

                    //Affichage de la partie d'ajout EPISODE
                    gb_serie.Visible = false;
                    gb_saison.Visible = false;
                    gb_episode.Visible = true;
                    gb_episode.Location = new Point(79, 527);

                    //--
                    cb_SerieAssocieeEp.SelectedIndex = cb_SerieCourante.SelectedIndex;
                    cb_SaisonAssocieeEp.SelectedIndex = cb_SaisonCourante.SelectedIndex;

                    break;
                default:
                    break;
            }
        }

        /*----------------   BDD ----------------------*/

    }
}
