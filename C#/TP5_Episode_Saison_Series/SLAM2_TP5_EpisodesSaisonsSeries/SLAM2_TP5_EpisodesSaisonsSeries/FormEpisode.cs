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

namespace SLAM2_TP5_EpisodesSaisonsSeries
{
    public partial class FormEpisode : Form
    {

        //Propriétés
        private List<Serie> lesSeries;

        /* Fonction permettant l'instanciation du Form Episode */
        public FormEpisode(List<Serie> desSeries)
        {
            InitializeComponent();

            lesSeries = desSeries;

            //Création du Data Grind
            DG_Episodes.ColumnCount = 5;
            DG_Episodes.Columns[0].Name = "Nom Série";
            DG_Episodes.Columns[1].Name = "Nom Réalisateur";
            DG_Episodes.Columns[2].Name = "Numéro Saison";
            DG_Episodes.Columns[3].Name = "Nom Épisode";
            DG_Episodes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DG_Episodes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DG_Episodes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DG_Episodes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

            //Parcours du Data Grind en lui attribuant des valeurs des Séries / Saisons / Épisodes
            foreach (Serie s in lesSeries)
            {
                foreach (Saison sa in s.getLesSaisons())
                {
                    foreach (Episode ep in sa.getLesEpisodes())
                    {
                        DG_Episodes.Rows.Add(s.getTitre(), s.getRealisateur(), sa.getNumSaison(), ep.getTitre());
                    }
                }
            }

        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            //Obtenir l'index de la ligne séléctionnée
            int selectedRow;
            selectedRow = DG_Episodes.CurrentCell.RowIndex;

            //Si la case n'est pas vide, alors on continue sinon on ignore l'action de l'utilisateur
            if (DG_Episodes[0,selectedRow].Value != null)
            {
                List<Episode> lesEpisodes;               

                //Get le titre de la serie sur la ligne séléctionnée
                string titreSerie = DG_Episodes[0, selectedRow].Value.ToString();
                string titreEpisode = DG_Episodes[3, selectedRow].Value.ToString();

                //Et on supprime la série à la ligne selectionné.
                lesEpisodes = lesSeries[donneIndexObjet(titreSerie, lesSeries, null)].getLesSaisons()[int.Parse(DG_Episodes[2, selectedRow].Value.ToString()) - 1].getLesEpisodes();
                lesEpisodes.RemoveAt(donneIndexObjet(titreEpisode, null, lesEpisodes));
                DG_Episodes.Rows.RemoveAt(selectedRow);
            }
            else
            {
                MessageBox.Show("La ligne sélectionné est vide", "Erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        public int donneIndexObjet(string titre,List<Serie> desSeries, List<Episode> desEpisodes)
        {
            //Parcours liste les Series, si la liste est null alors elle ne sera pas parcoura
            if (!(desSeries is null))  {
                foreach (Serie s in desSeries)
                {
                    if (s.getTitre() == titre)
                    {
                        return desSeries.IndexOf(s);
                    }
                }
            }

            //Parcours liste les Episodes
            if (!(desEpisodes is null))
            {
                foreach (Episode e in desEpisodes)
                {
                    if (e.getTitre() == titre)
                    {
                        return desEpisodes.IndexOf(e);
                    }
                }
            }

            //On renvoit -1 si le titre n'a pas été trouvé ( ce qui est illogique ) 
            return -1;
        }

        private void FormEpisode_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
