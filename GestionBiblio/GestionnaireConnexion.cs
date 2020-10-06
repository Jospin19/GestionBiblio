using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Web;
using System.Windows.Forms;

namespace GestionBiblio
{
    public class GestionnaireConnexion
    {
        //Déclaration des attributs
        string comString;
        String message_erreur;
        public MySqlConnection connecteur;
        public MySqlCommand commande { get; set; }
        public MySqlDataReader reader { get; set; }
        int nbreCmde;

        //Déclaration des méthodes

        //Déclaration du constructeur
        public GestionnaireConnexion()
        {
            comString = "datasource = localhost; port = 3306; user = root; password = ;";
            connecteur = new MySqlConnection(comString);
            try
            {
                connecteur.Open();
            }
            catch (Exception e)
            {
                message_erreur = "Probleme de connection";
            }
            commande = connecteur.CreateCommand();
        }

        //Déclaration de la méthode qui va fermer la connexion
        public void close()
        {
            connecteur.Close();
        }

        //Déclaration de laa fonction qui va permettre d'utiliser la BD 'fad'
        public void UseDB()
        {
            commande.CommandText = "use biblio";
            reader = commande.ExecuteReader();
            reader.Close();
        }


        //Déclaration des méthodes de gestion des étudiants
        //Déclaration de la fonction qui  va renvoyer la liste de tous les étudiants
        public List<Etudiant> AllEtudiant()
        {
            List<Etudiant> ListeEtd = new List<Etudiant>();
            UseDB();

            commande.CommandText = "select * from etudiant ORDER BY NomEtd, PrenomEtd ASC";
            reader = commande.ExecuteReader();

            if (!reader.HasRows)
            {
                return null;
            }

            else
            {

                while (reader.Read())
                {
                    ListeEtd.Add(new Etudiant(reader.GetString("MatriculeEtd"), reader.GetString("NomEtd"), reader.GetString("PrenomEtd"), reader.GetChar("SexeEtd"), reader.GetString("EmailEtd")));
                }
                reader.Close();
                return ListeEtd;
            }
        }

        //Déclaration de la focntionn qui va permettre de vérifier un étudiant
        public bool verifyEtudiant(string matEtd)
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();
            List<Etudiant> ListeEtd = connect.AllEtudiant();
            bool reponse = false;

            foreach(Etudiant E in ListeEtd)
            {
                if (E.Matricule == matEtd)
                    reponse = true;
            }
            return reponse;
        }

        //Déclaration de la fonction qui va rechercher un étudiant
        public Etudiant OneEtudiant(string matriculeEtd)
        {
            Etudiant newEtudiant = null;
            UseDB();

            commande.CommandText = "select * from etudiant where (MatriculeEtd = '" + matriculeEtd + "')";
            reader = commande.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                    newEtudiant = new Etudiant(reader.GetString("MatriculeEtd"), reader.GetString("NomEtd"), reader.GetString("PrenomEtd"), reader.GetChar("SexeEtd"), reader.GetString("EmailEtd"));
            }
            reader.Close();
            return newEtudiant;
        }


        //Déclaration des méthodes de gestion des formulaire d'emprunts
        //Déclaration de la fonction qui  va renvoyer la liste de tous les emprunts
        public List<FormulaireEmprunt> AllEmprunt()
        {
            List<FormulaireEmprunt> ListeEmprunt = new List<FormulaireEmprunt>();
            UseDB();

            commande.CommandText = "select * from formemprunt ORDER BY DateEmprunt";
            reader = commande.ExecuteReader();

            if (!reader.HasRows)
            {
                return null;
            }

            else
            {

                while (reader.Read())
                {
                    ListeEmprunt.Add(new FormulaireEmprunt(reader.GetString("MatriculeEtd"), reader.GetString("MatriculeProf"), reader.GetString("ISBN"), DateTime.Parse(reader.GetString("DateEmprunt")), DateTime.Parse(reader.GetString("DateFin"))));
                }
                reader.Close();
                return ListeEmprunt;
            }
        }

        //Déclaration de la fonction qui va rechercher un emprunt
        public List<FormulaireEmprunt> OneEmprunt(string matriculeEtd)
        {
            List<FormulaireEmprunt> ListeEmprunt = new List<FormulaireEmprunt>();
            UseDB();

            commande.CommandText = "select * from formemprunt where (MatriculeEtd = '" + matriculeEtd + "')";
            reader = commande.ExecuteReader();

            if (!reader.HasRows)
            {
                return null;
            }

            else
            {

                while (reader.Read())
                {
                    ListeEmprunt.Add(new FormulaireEmprunt(reader.GetString("MatriculeEtd"), reader.GetString("MatriculeProf"), reader.GetString("ISBN"), reader.GetDateTime("DateEmprunt"), reader.GetDateTime("DateFin")));
                }
                reader.Close();
                return ListeEmprunt;
            }
        }


        //Déclaration de la méthode qui va ajouter un emprunnt
        public void insertEmprunt(FormulaireEmprunt F)
        {
            UseDB();
            commande.CommandText = "insert into formemprunt (MatriculeEtd, MatriculeProf, ISBN, DateEmprunt, DateFin)" +
                                   "values('" + F.MatriculeEtd + "', '" + F.MatriculeProf + "', '" + F.ISBN + "', '" + F.DateEmprunt.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + F.DateFin.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            nbreCmde = commande.ExecuteNonQuery();
        }

        //Déclaration de la méthode qui va nous dire si un lecteur a atteint le quota d'emprunt
        public List<Etudiant> mauvaisLecteur()
        {
            List<Etudiant> ListeEtudiant = new List<Etudiant>();
            UseDB();

            commande.CommandText = "SELECT * FROM etudiant WHERE etudiant.MatriculeEtd IN (SELECT formemprunt.MatriculeEtd FROM formemprunt WHERE DateFin <= now())";
            reader = commande.ExecuteReader();

            if (!reader.HasRows)
                return null;

            else
            {

                while (reader.Read())
                    ListeEtudiant.Add(new Etudiant(reader.GetString("MatriculeEtd"), reader.GetString("NomEtd"), reader.GetString("PrenomEtd"), reader.GetChar("SexeEtd"), reader.GetString("EmailEtd")));
                reader.Close();
                return ListeEtudiant;
            }
        }


        //Déclaration des fonction de gestion des livres

        //Déclaration de la fonction qui va permettre d'ajouter un livre
        public void InsertLivre(Livre L)
        {
            UseDB();
            commande.CommandText = "insert into livre (ISBN, TitreLivre, Auteur, MaisonEdition, DatePublication)" +
                                   "values('" + L.ISBN + "', '" + L.Titre + "', '" + L.Auteur + "', '" + L.MaisonEdition + "', '" + L.datePublication + "')";
            nbreCmde = commande.ExecuteNonQuery();
        }

        //Déclaration de la méthode qui va supprimer un Livre
        public void DeleteLivre(string ISBN)
        {
            UseDB();

            commande.CommandText = "delete from livre where  ISBN = '" + ISBN + "'";
            nbreCmde = commande.ExecuteNonQuery();
        }

        //Déclaration de la méthode qui va supprimer un Livre
        public void ModifyLivre(string isbn, string titre, string auteur, string maison, string datePub)
        {
            UseDB();

            commande.CommandText = "update livre set TitreLivre = '" + titre + "', Auteur = '" + auteur + "', MaisonEdition = '" + maison + "', DatePublication = '" + datePub + "' where  ISBN = '" + isbn + "'";
            nbreCmde = commande.ExecuteNonQuery();
        }

        //Déclaration de la méthode qui va récupérer tous les livres
        public List<Livre> AllLivres()
        {
            List<Livre> ListeLivre = new List<Livre>();
            UseDB();

            commande.CommandText = "select * from livre ORDER BY TitreLivre";
            reader = commande.ExecuteReader();

            if (!reader.HasRows)
            {
                return null;
            }

            else
            {

                while (reader.Read())
                {
                    ListeLivre.Add(new Livre(reader.GetString("ISBN"), reader.GetString("TitreLivre"), reader.GetString("Auteur"), reader.GetString("MaisonEdition"), reader.GetString("DatePublication")));
                }
                reader.Close();
                return ListeLivre;
            }
        }

        //Déclaration de la méthode qui va récupérer tous les livres disponibles
        public List<Livre> AllLivresDispo()
        {
            List<Livre> ListeLivre = new List<Livre>();
            UseDB();

            commande.CommandText = "SELECT * FROM livre WHERE livre.ISBN NOT IN (SELECT livre.ISBN FROM livre, formemprunt WHERE livre.ISBN = formemprunt.ISBN)";
            reader = commande.ExecuteReader();

            if (!reader.HasRows)
            {
                return null;
            }

            else
            {

                while (reader.Read())
                {
                    ListeLivre.Add(new Livre(reader.GetString("ISBN"), reader.GetString("TitreLivre"), reader.GetString("Auteur"), reader.GetString("MaisonEdition"), reader.GetString("DatePublication")));
                }
                reader.Close();
                return ListeLivre;
            }
        }



        //Déclaration des méthodes de gestion des professeur
        //Déclaration de la fonction qui  va renvoyer la liste de tous les professeurs
        public List<Professeur> AllProfesseur()
        {
            List<Professeur> ListeProf = new List<Professeur>();
            UseDB();

            commande.CommandText = "select * from professeur ORDER BY NomProf, PrenomProf ASC";
            reader = commande.ExecuteReader();

            if (!reader.HasRows)
            {
                return null;
            }

            else
            {

                while (reader.Read())
                {
                    ListeProf.Add(new Professeur(reader.GetString("MatriculeProf"), reader.GetString("NomProf"), reader.GetString("PrenomProf"), reader.GetChar("SexeProf"), reader.GetString("Fonction"), reader.GetString("Email")));
                }
                reader.Close();
                return ListeProf;
            }
        }

        //Déclaration de la fonction qui va rechercher un professeur
        public Professeur OneProfesseur(string matriculeProf)
        {
            Professeur newProfesseur = null;
            UseDB();

            commande.CommandText = "select * from professeur where (MatriculeProf = '" + matriculeProf + "')";
            reader = commande.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                    newProfesseur = new Professeur(reader.GetString("MatriculeProf"), reader.GetString("NomProf"), reader.GetString("PrenomProf"), reader.GetChar("SexeProf"), reader.GetString("Fonction"), reader.GetString("Email"));
            }
            reader.Close();
            return newProfesseur;
        }

        //Déclaration de la focntionn qui va permettre de vérifier un professeur
        public bool verifyProfesseur(string matProf)
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();
            List<Professeur> ListeProf = connect.AllProfesseur();
            bool reponse = false;

            foreach (Professeur P in ListeProf)
            {
                if (P.Matricule == matProf)
                    reponse = true;
            }
            return reponse;
        }

        //Déclaration de la fonction qui va rechercher un responsable
        public Professeur OneResponsable(string nomProf, string passe)
        {
            Professeur newResponsable = null;
            string Fonction = "Responsable";
            UseDB();

            commande.CommandText = "select * from professeur where (NomProf = '" + nomProf + "')" + "AND ( MatriculeProf = '" + passe + "')" + "AND ( Fonction = '" + Fonction + "')";
            reader = commande.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                    newResponsable = new Professeur(reader.GetString("MatriculeProf"), reader.GetString("NomProf"), reader.GetString("PrenomProf"), reader.GetChar("SexeProf"), reader.GetString("Fonction"), reader.GetString("Email"));
            }
            reader.Close();
            return newResponsable;
        }

        //Déclaration de la méthode qui va permettre de compter le nombre total d'étudiant de la bd
        public long nombreTotalEtd()
        {
            long nbretot = 1;

            UseDB();
            commande.CommandText = "select count(MatriculeEtd) as effectif from etudiant";
            reader = commande.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                    nbretot = (long)reader["effectif"];
            }
            reader.Close();
            return nbretot;
        }


        //Déclaration de la méthode qui va permettre de compter le nombre total de professeur de la bd
        public long nombreTotalProf()
        {
            long nbretot = 1;

            UseDB();
            commande.CommandText = "select count(MatriculeProf) as effectif from professeur";
            reader = commande.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                    nbretot = (long)reader["effectif"];
            }
            reader.Close();
            return nbretot;
        }

        //Déclaration de la méthode qui va permettre de compter le nombre total de professeur responsables de la bd
        public long nombreTotalProfRespo()
        {
            long nbretot = 1;
            string fction = "Responsable";

            UseDB();
            commande.CommandText = "select count(MatriculeProf) as effectif from professeur where (Fonction = '" + fction + "')";
            reader = commande.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                    nbretot = (long)reader["effectif"];
            }
            reader.Close();
            return nbretot;
        }


        //Déclaration de la méthode qui va permettre de compter le nombre total d'emprunt de la bd
        public long nombreTotalEmp()
        {
            long nbretot = 1;

            UseDB();
            commande.CommandText = "select count(ISBN) as effectif from formemprunt";
            reader = commande.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                    nbretot = (long)reader["effectif"];
            }
            reader.Close();
            return nbretot;
        }


        //Déclaration de la fonction qui va calculer le nombre total de lecteur de la bd
        public long nombreLecteur()
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();
            return connect.nombreTotalEtd() + connect.nombreTotalProf();
        }


        //Déclaration de la fonction qui va calculer le nombre total de lecteurs censionnés de la bd
        public long nombreLecteurM()
        {
            long nbretot = 1;

            UseDB();
            commande.CommandText = "SELECT count(MatriculeEtd) as effectif FROM etudiant WHERE etudiant.MatriculeEtd IN (SELECT formemprunt.MatriculeEtd FROM formemprunt WHERE DateFin <= now())";
            reader = commande.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                    nbretot = (long)reader["effectif"];
            }
            reader.Close();
            return nbretot;
        }


        //Déclaration de la fonction qui va calculer le taux de réussite
        public float tauxEmrpunt()
        {
            long totalLecteur = nombreLecteur();
            float taux = (float)((nombreTotalEmp() * 100) / totalLecteur);

            return taux;
        }

    }
}