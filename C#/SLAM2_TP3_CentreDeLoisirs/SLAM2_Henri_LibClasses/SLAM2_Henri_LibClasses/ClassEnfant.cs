using System;
using System.Collections.Generic;

namespace SLAM2_Henri_LibClasses
{
    public class ClassEnfant
    {
        //Propriétés
        private int num;
        private string nom;
        private string prenom;
        private int t_age;

        //Constructeur
        public ClassEnfant(int numE, string nomE, string prenomE, int t_ageE)
        {
            this.num = numE;
            this.nom = nomE;
            this.prenom = prenomE;
            this.t_age = t_ageE;
        }

        //Acceseurs

        public int getNum()
        {
            return this.num;
        }

        public string getNom()
        {
            return this.nom;
        }
        public string getPrenom()
        {
            return this.prenom;
        }
        public int getTrancheAge()
        {
            return this.t_age;
        }

        //Setteurs
        public void setNum(int numE)
        {
            this.num = numE;
        }

        public void setNom(string nomE)
        {
            this.nom = nomE;
        }

        public void setPrenom(string prenomE)
        {
            this.prenom = prenomE;
        }

        public void setTrancheAge(int trancheAge)
        {
            this.t_age = trancheAge;
        }

        //Methodes

        public string donneTrancheAge()
        {
            switch (this.t_age)
            {
                case 1:
                    return "3-6 ans";

                case 2:
                    return "7-11 ans";

                case 3:
                    return "12-15 ans";

                case 4:
                    return "+15 ans";

                default:
                    return "âge non saisi";
            }
        }
    }
}
