using System;
using System.Collections.Generic;
using System.Text;

namespace SLAM2_Henri_LibClasses
{
    class Enfant
    {
        //Propriétés
        private int num;
        private string nom;
        private string prenom;
        private int t_age;

        //Constructeur
        public Enfant(int numE, string nomE, string prenomE, int t_ageE)
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
    }
}
