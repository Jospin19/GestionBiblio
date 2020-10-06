using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblio
{
    //Déclaration de la classe FormulaireEmprunt
    public class FormulaireEmprunt
    {
        //Déclaration des Membres Données
        public string MatriculeEtd;
        public string MatriculeProf;
        public string ISBN;
        public DateTime DateEmprunt;
        public DateTime DateFin;

        //Déclaration du constructeur par défaut
        public FormulaireEmprunt()
        {
            MatriculeEtd = "";
            MatriculeProf = "";
            ISBN = "";
            DateEmprunt = DateTime.Now;
            DateFin = DateTime.Now + new TimeSpan(16, 0, 0, 0);
        }

        //Déclaration du constructeur de copie
        public FormulaireEmprunt(string matEtd, string matProf, string isbn, DateTime dateEmp, DateTime dateFin)
        {
            MatriculeEtd = matEtd;
            MatriculeProf = matProf;
            ISBN = isbn;
            DateEmprunt = dateEmp;
            DateFin = dateFin;
        }
    }

}
