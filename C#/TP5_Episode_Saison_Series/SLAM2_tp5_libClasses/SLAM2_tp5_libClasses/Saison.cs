using System;
using System.Collections.Generic;
using System.Text;

namespace SLAM2_tp5_libClasses
{
    public class Saison
    {
        //PROPRIÉTES
        private int num_saison;
        private int annee;
        private int nb_episodes_prevus;
        private int dureeTotale;
        private Serie laSerie;
        private List<Episode> lesEpisodes;
        
        //CONSTRUCTEUR SANS LA SERIE
        public Saison(int unNum, int uneAnnee, int unNbEpisodePrevu)
        {
            this.num_saison = unNum;
            this.annee = uneAnnee;
            this.nb_episodes_prevus = unNbEpisodePrevu;
            this.lesEpisodes = new List<Episode>();
        }

        //CONSTRUCTEUR AVEC LA SERIE
        public Saison(int unNum, int uneAnnee, int unNbEpisodePrevu, Serie s)
        {
            this.num_saison = unNum;
            this.annee = uneAnnee;
            this.nb_episodes_prevus = unNbEpisodePrevu;
            this.laSerie = s;
            this.lesEpisodes = new List<Episode>();
        }

        //MUTATEURS
        public void setNumSaison(int num)
        {
            this.num_saison = num;
        }

        public void setAnneeSaison(int num)
        {
            this.annee = num;
        }

        public void setNbEpsPrevus(int nb)
        {
            this.nb_episodes_prevus = nb;
        }

        //ACCESEURS

        public int getNumSaison()
        {
            return this.num_saison;
        }
        public int getAnnee()
        {
            return this.annee;
        }        
        public int getNbEpisodesPrevus()
        {
            return this.nb_episodes_prevus;
        }

        public List<Episode> getLesEpisodes()
        {
            return this.lesEpisodes;
        }

        //METHODES

        public void AjouteEpisode(int numEpisode, string titreEpisode, int dureeEpisode)
        {
            Episode e = new Episode(numEpisode, titreEpisode, dureeEpisode);
            lesEpisodes.Add(e);
        }

        public void ModifierEpisode(int numEpisode, string titreEpisode, int dureeEpisode, Episode e)
        {
            int index = lesEpisodes.IndexOf(e);
            lesEpisodes[index].setNumEp(numEpisode);
            lesEpisodes[index].setTitre(titreEpisode);
            lesEpisodes[index].setDuree(dureeEpisode);
        }

        public int dureeSaison()
        {
            dureeTotale = 0;
            foreach(Episode lEpisode in lesEpisodes)
            {
                dureeTotale += lEpisode.getDuree();
            }
            return dureeTotale;
        }

        public bool estComplete()
        {
            if (this.nb_episodes_prevus == lesEpisodes.Count)
                return true;
            else
                return false;
        }
    }
}
