using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblio
{
    //Déclaration de la classe Etudiant
    public class Etudiant
    {
        //Déclaration des Membre Données
        public string Matricule;
        public string Nom;
        public string Prenom;
        public char Sexe;
        public string Email;

        //Déclaration de fonction membres

        //Déclaration du constructeur par défaut
        public Etudiant()
        {
            Matricule = "";
            Nom = "";
            Prenom = "";
            Sexe = ' ';
            Email = "";
        }

        //Déclaration du constructeur de copie
        public Etudiant(string mat, string nom, string prenom, char sexe, string email)
        {
            Matricule = mat;
            Nom = nom;
            Prenom = prenom;
            Sexe = sexe;
            Email = email;
        }
    }
}
