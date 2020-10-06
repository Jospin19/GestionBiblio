using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblio
{
    //Déclaration de la classe Professeur
    public class Professeur
    {
        //Déclaration des Membres Données
        public string Matricule;
        public string Nom;
        public string Prenom;
        public char Sexe;
        public string Fonction;
        public string Email;


        //Déclaration du constructeur par défaut
        public Professeur()
        {
            Matricule = "";
            Nom = "";
            Prenom = "";
            Sexe = ' ';
            Fonction = "";
            Email = "";
        }


        //Déclaration du constructeur de copie
        public Professeur(string mat, string nom, string prenom, char sexe, string fonction, string email)
        {
            Matricule = mat;
            Nom = nom;
            Prenom = prenom;
            Sexe = sexe;
            Fonction = fonction;
            Email = email;
        }
    }
}
