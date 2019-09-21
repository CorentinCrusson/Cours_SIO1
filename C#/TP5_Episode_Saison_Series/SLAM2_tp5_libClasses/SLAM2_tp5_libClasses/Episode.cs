using System;
using System.Collections.Generic;
using System.Text;

namespace SLAM2_tp5_libClasses
{
    public class Episode
    {
        //PROPRIÉTES
        private int num_episode;
        private string titre;
        private int duree;
        private Saison laSaison;

        //CONSTRUCTEUR SANS LA SAISON
        public Episode(int unNum, string unTitre, int uneDuree)
        {
            this.num_episode = unNum;
            this.titre = unTitre;
            this.duree = uneDuree;
        }

        //CONSTRUCTEUR AVEC LA SAISON
        public Episode(int unNum, string unTitre, int uneDuree, Saison s)
        {
            this.num_episode = unNum;
            this.titre = unTitre;
            this.duree = uneDuree;
            this.laSaison = s;
        }

        //MUTATEURS
        public void setSaison(Saison s)
        {
            this.laSaison = s;
        }

        public void setNumEp(int num)
        {
            this.num_episode = num;
        }

        public void setTitre(string titre)
        {
            this.titre = titre;
        }

        public void setDuree(int duree)
        {
            this.duree = duree;
        }

        //ACCESEURS
        public int getNumEpisode()
        {
            return this.num_episode;
        }

        public string getTitre()
        {
            return this.titre;
        }

        public int getDuree()
        {
            return this.duree;
        }

        //METHODES
    }
}
