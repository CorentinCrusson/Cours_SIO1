using System;
using System.Collections.Generic;

namespace SLAM2_Henri_LibClasses
{
    public class ClassActivite
    {
        //Propriétés
        private int numActivite;
        private string libelle;
        private string dateA;
        private int trancheAge;
        private string animateur;
        private int nbMaxParticipants;
        private int nbParticipants;
        private List<ClassEnfant> listeEnfants;

        //Constructeur
        public ClassActivite(int numA, string lib, string dateAct)
        {
            this.numActivite = numA;
            this.libelle = lib;
            this.dateA = dateAct;
            this.nbParticipants = 0;
            this.listeEnfants = new List<ClassEnfant>();
        }

        //Acceseurs

        public int getNum()
        {
            return this.numActivite;
        }

        public string getLibelle()
        {
            return this.libelle;
        }
        public string getDateAct()
        {
            return this.dateA;
        }
        public int getTrancheAge()
        {
            return this.trancheAge;
        }

        public string getAnimateur()
        {
            return this.animateur;
        }

        public int getNbMaxParticipants()
        {
            return this.nbMaxParticipants;
        }
        public int getNbParticipants()
        {
            return this.nbParticipants;
        }

        //Setteurs
        public void setDateAct(string dateAct)
        {
            this.dateA = dateAct;
        }

        public void setTrancheAge(int tranche)
        {
            this.trancheAge = tranche;
        }

        public void setLibelleActivite(string libelle)
        {
            this.libelle = libelle;
        }
        public void setAnimateur(string LAnimateur)
        {
            this.animateur = LAnimateur;
        }
        public void setNbMaxPart(int nbMax)
        {
            this.nbMaxParticipants = nbMax;
        }

        //Méthodes
        public int Est_Complete()
        {
            if (nbMaxParticipants-nbParticipants >0)
            {
                return (nbMaxParticipants - nbParticipants);
            }
            else
            {
                return 0;
            }
        }
        public bool AjouterUnParticipant(ClassEnfant unEnfant)
        {
            if(Est_Complete()>0 && unEnfant.getTrancheAge() == this.trancheAge)
            {
                this.nbParticipants += 1;
                listeEnfants.Add(unEnfant);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
