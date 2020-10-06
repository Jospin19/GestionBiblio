using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblio
{
    //Déclaration de la classe Livre
    public class Livre
    {
        //Déclaration des Membres Données
        public string ISBN;
        public string Titre;
        public string Auteur;
        public string MaisonEdition;
        public string datePublication;

        //Déclaration du constructeur par défaut
        public Livre()
        {
            ISBN = "";
            Titre = "";
            Auteur = "";
            MaisonEdition = "";
            datePublication = "";
        }

        //Déclaration du constructeur de copie
        public Livre(string isbn, string titre, string auteur, string maisonEdit, string datePub)
        {
            ISBN = isbn;
            Titre = titre;
            Auteur = auteur;
            MaisonEdition = maisonEdit;
            datePublication = datePub;
        }

    }
}
