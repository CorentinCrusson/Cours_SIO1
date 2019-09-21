using System;
using System.Collections.Generic;

namespace SLAM2_tp5_libClasses
{
    public class Serie
    {
        //PROPRIÉTES
        private int num_Serie;
        private string titre_serie;
        private string realisateur;
        private int dureeTotale;
        private List<Saison> lesSaisons;

        //CONSTRUCTEUR
        public Serie(int unNum, string titre, string realisateur)
        {
            this.num_Serie = unNum;
            this.titre_serie = titre;
            this.realisateur = realisateur;
            this.lesSaisons = new List<Saison>();
        }

        //MUTATEURS


        //ACCESEURS
        public int getNumSerie()
        {
            return this.num_Serie;
        }
        public string getTitre()
        {
            return this.titre_serie;
        }
        public string getRealisateur()
        {
            return this.realisateur;
        }

        public List<Saison> getLesSaisons()
        {
            return this.lesSaisons;
        }

        //METHODES
        public int nbSaisons()
        {
            return lesSaisons.Count;
        }

        public void AjouteSaison(int num, int annee, int nbEpisodesPrevus)
        {
            Saison s = new Saison(num, annee, nbEpisodesPrevus);
            lesSaisons.Add(s);
        }
        public void modifierSaison(int numSaison, int anneeSaison, int nbEpsPrevus, Saison s)
        {
            int index = lesSaisons.IndexOf(s);
            lesSaisons[index].setNumSaison(numSaison);
            lesSaisons[index].setAnneeSaison(anneeSaison);
            lesSaisons[index].setNbEpsPrevus(nbEpsPrevus);
        }
        public int DonneDureeTotale()
        {
            dureeTotale = 0;
            foreach(Saison laSaison in lesSaisons)
            {
                foreach(Episode lEpisode in laSaison.getLesEpisodes())
                {
                    dureeTotale += lEpisode.getDuree();
                }
            }
            return dureeTotale;
        }
    }
}
