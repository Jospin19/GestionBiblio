using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBiblio
{
    public partial class FormAdmin : Form
    {
        string isbn = "";

        public FormAdmin()
        {
            InitializeComponent();
        }


        //Déclaration des actions à effectuer lors du clic sur le bouton Acceuil
        private void Acceuil_Click(object sender, EventArgs e)
        {
            Separator.Width = Acceuil.Width;
            Separator.Left = Acceuil.Left;

            //Opérations de masquage

            //MenuLivre--------Acceuil
            GestionLivres.Visible = false;

            //GestionLecteur--------Acceuil
            GestionLecteur.Visible = false;

            //GestionEmprunt--------Acceuil
            GestionEmprunt.Visible = false;

            Transition.ShowSync(acceuilAdmin);
            acceuilAdmin.Visible = true;
        }


        //Déclaration des actions à effectuer lors du clic sur le bouton Menu livres
        private void MenuLivres_Click(object sender, EventArgs e)
        {
            Separator.Width = MenuLivres.Width;
            Separator.Left = MenuLivres.Left;

            //Opérations de masquage

            //Acceuil--------MenuLivre
            acceuilAdmin.Visible = false;

            //GestionLecteurs--------MenuLivre
            GestionLecteur.Visible = false;

            //GestionEmprunt--------GestionLivres
            GestionEmprunt.Visible = false;

            Transition.ShowSync(GestionLivres);
            //On remplit le datagrid des livres
            chargerdgLivre();
            GestionLivres.Visible = true;

        }


        //Déclaration des actions à effectuer lors du clic sur le bouton Menu lecteurs
        private void MenuLecteurs_Click(object sender, EventArgs e)
        {
            Separator.Width = MenuLecteurs.Width;
            Separator.Left = MenuLecteurs.Left;

            //Opérations de masquage

            //Acceuil--------GestionLecteur
            acceuilAdmin.Visible = false;

            //GestionLivre--------GestionLecteur
            GestionLivres.Visible = false;

            //GestionEmprunt--------GestionLecteur
            GestionEmprunt.Visible = false;

            Transition.ShowSync(GestionLecteur);
            //On remplit le datagrid des lecteurs
            chargerdgLecteur();
            GestionLecteur.Visible = true;
        }


        //Déclaration des actions à effectuer lors du clic sur le bouton Menu Emprunt
        private void MenuEmprunt_Click(object sender, EventArgs e)
        {
            Separator.Width = MenuEmprunt.Width;
            Separator.Left = MenuEmprunt.Left;

            //Opérations de masquage

            //Acceuil--------GestionEmprunt
            acceuilAdmin.Visible = false;

            //GestionLivre--------GestionEmprunt
            GestionLivres.Visible = false;

            //GestionLecteur--------GestionEmprunt
            GestionLecteur.Visible = false;

            Transition.ShowSync(GestionEmprunt);
            //On remplit le datagrid des emprunts
            chargerdgEmprunt();
            GestionEmprunt.Visible = true;
        }


        //Déclaration de la méthode qui va s'exécuter lors du clic sur le bouton close
        private void Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        //Déclaration de la méthode qui va s'exécuter lors du clic sur le bouton Minimize
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        //Déclaration de la méthode qui va s'exécuter lors du clic sur le bouton LogOut
        private void LogOut_Click(object sender, EventArgs e)
        {

        }

        //Déclaration de la méthode qui va s'exécuter lors du clic sur le bouton Help
        private void Help_Click(object sender, EventArgs e)
        {

        }

        //Déclaration de la fonction qui va remplir le dg de tous les livres
        public void chargerdgLivre()
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();
            List<Livre> ficheU = connect.AllLivres();

            dgLivre.Rows.Clear();

            foreach(Livre L in ficheU)
            {
                dgLivre.Rows.Add(null, L.ISBN, L.Titre, L.Auteur, L.MaisonEdition, L.datePublication);
            }
        }

        //Déclaration de la fonction qui va remplir le dg des livres dispos
        public void chargerdgLivreD()
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();
            List<Livre> ficheU = connect.AllLivresDispo();

            dgLivre.Rows.Clear();

            foreach (Livre L in ficheU)
            {
                dgLivre.Rows.Add(null, L.ISBN, L.Titre, L.Auteur, L.MaisonEdition, L.datePublication);
            }
        }


        //Charge le datagrid avec tous les livres de la bd
        private void btnAct_Click(object sender, EventArgs e)
        {
            //On masque le panel de notification
            Transition1.HideSync(notifL);
            notifL.Visible = false;

            chargerdgLivre();
        }


        //Charge le datagrid avec les livre dispo de la bd
        private void LivreDispos_Click(object sender, EventArgs e)
        {
            panelAjout.Visible = false;

            dgLivre.Visible = true;
            chargerdgLivreD();
        }

        private void dgLivre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Affectation des valeurs du datagrid
            isbn = dgLivre.Rows[e.RowIndex].Cells[1].Value.ToString();
            titre.Text = dgLivre.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAuteur.Text = dgLivre.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtMaison.Text = dgLivre.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDate.Text = dgLivre.Rows[e.RowIndex].Cells[5].Value.ToString();

            //Rend visible
            titre.Visible = true;
            txtAuteur.Visible = true;
            txtMaison.Visible = true;
            txtDate.Visible = true;

            Emprunter.Visible = true;
            ModLiv.Visible = true;
            SupLiv.Visible = true;
            Mat.Visible = true;
        }

        private void insLivre_Click(object sender, EventArgs e)
        {
            dgLivre.Visible = false;
            Transition1.ShowSync(panelAjout);

            panelAjout.Visible = true;

            //On cache le premier bouton d'ajout
            insLivre.Visible = false;

            //On cache les textbox
            titre.Visible = false;
            txtAuteur.Visible = false;
            txtMaison.Visible = false;
            txtDate.Visible = false;
            Mat.Visible = false;
        }

        private void AjLiv_Click(object sender, EventArgs e)
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();
            Livre L = new Livre(AISBN.Text, titreL.Text, AAuteur.Text, AMaisonEdit.Text, ADatePub.Text);
            connect.InsertLivre(L);

            Transition1.HideSync(panelAjout);
            panelAjout.Visible = false;

            //On rend le premier bouton d'ajout visibe
            insLivre.Visible = true;

            //On fait réapparaitre le datagrid
            Transition1.ShowSync(dgLivre);
            dgLivre.Visible = true;

        }

        private void SupLiv_Click(object sender, EventArgs e)
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();
            connect.DeleteLivre(isbn);

            //On masque les boutons
            Emprunter.Visible = false;
            ModLiv.Visible = false;
            SupLiv.Visible = false;
            Mat.Visible = false;

            //On masque les textbox
            titre.Visible = false;
            txtAuteur.Visible = false;
            txtMaison.Visible = false;
            txtDate.Visible = false;

            //On fait apparaitre le panel de notification
            Transition.ShowSync(notifL);
            notifL.Visible = true;
        }


        private void MatEtd_MouseClick(object sender, MouseEventArgs e)
        {
            Mat.Text = "";

            if (titre.Text == "")
                titre.Text = "Veuillez entrer un titre";
            else if (txtAuteur.Text == "")
                txtAuteur.Text = "Veuillez entrer l'auteur";
            else if (txtMaison.Text == "")
                txtMaison.Text = "Entrer la mais d'edition";
            else if (txtDate.Text == "")
                txtDate.Text = "Date de publication";
        }

        private void Emprunter_Click(object sender, EventArgs e)
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();

            FormulaireEmprunt emprunt = null;

            //Récupération de la date et du temps système
            //Date de début d'emprunt
            DateTime debut =  DateTime.Now;

            //Date de fin d'emprunt
            DateTime fin =  DateTime.Now;
            fin += new TimeSpan(16, 0, 0, 0);
            if((connect.AllEtudiant() == null))
            {
                txtNot.Text = "Aucun etudiant enregistré!!!";
                Transition.ShowSync(notifL);
                notifL.Visible = true;
            }
            else
            {
                if (connect.verifyEtudiant(Mat.Text))
                {
                    emprunt = new FormulaireEmprunt(Mat.Text, null, isbn, debut, fin);
                    connect.insertEmprunt(emprunt);
                }
                else if (connect.verifyProfesseur(Mat.Text))
                {
                    emprunt = new FormulaireEmprunt(null, Mat.Text, isbn, debut, fin);
                    connect.insertEmprunt(emprunt);
                }
                else
                {
                    txtNot.Text = "Ce matricule n existe pas!!!";
                    Transition.ShowSync(notifL);
                    notifL.Visible = true;
                }

                //On masque les boutons
                Emprunter.Visible = false;
                ModLiv.Visible = false;
                SupLiv.Visible = false;
                Mat.Visible = false;

                //On masque les textbox
                titre.Visible = false;
                txtAuteur.Visible = false;
                txtMaison.Visible = false;
                txtDate.Visible = false;

                //On fait apparaitre le panel de notification
                txtNot.Text = "Opération effetuée avec succès";
                Transition.HideSync(notifL);
                notifL.Visible = true;
            }
            

        }


        //Méthode qui s'exécute lors du clic sur le bouton modifier(dans la gestion des livres)
        private void ModLiv_Click(object sender, EventArgs e)
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();

            connect.ModifyLivre(isbn, titre.Text, txtAuteur.Text, txtMaison.Text, txtDate.Text);

            //On masque les boutons
            Emprunter.Visible = false;
            ModLiv.Visible = false;
            SupLiv.Visible = false;
            Mat.Visible = false;

            //On masque les textbox
            titre.Visible = false;
            txtAuteur.Visible = false;
            txtMaison.Visible = false;
            txtDate.Visible = false;

            //On fait apparaitre le panel de notification
            txtNot.Text = "Operation effectuee avec succes!!!";
            Transition.ShowSync(notifL);
            notifL.Visible = true;
        }


        private void retL_Click(object sender, EventArgs e)
        {
            panelAjout.Visible = false;
            Transition1.ShowSync(dgLivre);
            dgLivre.Visible = true;

            //On cache le premier bouton d'ajout
            insLivre.Visible = true;
        }

        //Déclaration de la fonction qui va remplir le dg des lecteur
        public void chargerdgLecteur()
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();
            List<Etudiant> ficheE = connect.AllEtudiant();
            List<Professeur> ficheP = connect.AllProfesseur();

            dgLecteur.Rows.Clear();

            //On remplis le datgrid avec tous les étudiants
            foreach (Etudiant E in ficheE)
                dgLecteur.Rows.Add(null, E.Matricule, E.Nom, E.Prenom, E.Sexe, E.Email);
            
            //On ajoute au datagrid tous les professeur
            foreach (Professeur P in ficheP)
                dgLecteur.Rows.Add(null, P.Matricule, P.Nom, P.Prenom, P.Sexe, P.Email);
        }

        //Fonction qui charge le data grid des censionnés
        public void chargerdgMLecteur()
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();
            List<Etudiant> ficheE = connect.mauvaisLecteur();

            dgLecteur.Rows.Clear();

            if(ficheE == null)
                dgLecteur.Rows.Add(null, "Aucun", "Aucun", "Aucun", "Aucun", "Aucun");
            else
            {
                //On remplis le datgrid avec tous les étudiants
                foreach (Etudiant E in ficheE)
                    dgLecteur.Rows.Add(null, E.Matricule, E.Nom, E.Prenom, E.Sexe, E.Email);
            }

        }

        private void AllLecteur_Click(object sender, EventArgs e)
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();
            long eff = connect.nombreTotalEtd() + connect.nombreLecteur();

            chargerdgLecteur();
            tot.Text = eff.ToString();
            tot.Visible = true;
        }


        //On ajoute au datagrid les lecteurs ayant une cension
        private void MLecteurs_Click(object sender, EventArgs e)
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();
            long eff = connect.nombreLecteurM();

            chargerdgMLecteur();
            tot.Visible = false;
        }

        //Lorsqu'on clique sur le textbox de recherche
        private void txtRecherche_MouseClick(object sender, MouseEventArgs e)
        {
            txtRecherche.Text = "";
        }

        //Méthode qui va s'exécuter lors du clic sur le bouton de recherche
        private void imgRecherche_Click(object sender, EventArgs e)
        {
            tot.Visible = false;
            GestionnaireConnexion connect = new GestionnaireConnexion();

            //On rechercher un lecteur(étudiant ou professeur)
            if ((connect.OneEtudiant(txtRecherche.Text) == null) && (connect.OneProfesseur(txtRecherche.Text) == null))
            {
                txtNotLect.Text = "Ce lecteur n est pas enregistré!!!!";
                Transition1.ShowSync(notifLect);
                notifLect.Visible = true;
            }
            else
            {
                if ((connect.OneEtudiant(txtRecherche.Text) == null) && (connect.OneProfesseur(txtRecherche.Text) != null))
                {
                    dgLecteur.Rows.Clear();
                    Professeur P = connect.OneProfesseur(txtRecherche.Text);

                    //On ajoute l'utilisateur trouvé dans le datagrid
                    dgLecteur.Rows.Add(null, P.Matricule, P.Nom, P.Prenom, P.Sexe, P.Email);
                }
                else
                {
                    dgLecteur.Rows.Clear();
                    Etudiant E = connect.OneEtudiant(txtRecherche.Text);

                    //On ajoute l'utilisateur trouvé dans le datagrid
                    dgLecteur.Rows.Add(null, E.Matricule, E.Nom, E.Prenom, E.Sexe, E.Email);
                }
            }
        }

        private void Mat_MouseClick(object sender, MouseEventArgs e)
        {
            Mat.Text = "";
        }

        private void AISBN_MouseClick(object sender, MouseEventArgs e)
        {
            AISBN.Text = "";
        }

        private void titreL_MouseClick(object sender, MouseEventArgs e)
        {
            titreL.Text = "";
        }

        private void AAuteur_MouseClick(object sender, MouseEventArgs e)
        {
            AAuteur.Text = "";
        }

        private void AMaisonEdit_MouseClick(object sender, MouseEventArgs e)
        {
            AMaisonEdit.Text = "";
        }

        private void ADatePub_MouseClick(object sender, MouseEventArgs e)
        {
            ADatePub.Text = "";
        }

        //Déclaration de la fonction qui va remplir le dg des emprunts
        public void chargerdgEmprunt()
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();
            List<FormulaireEmprunt> ficheE = connect.AllEmprunt();

            totE.Visible = true;

            dgEmprunt.Rows.Clear();

            //On remplis le datgrid avec tous les emprunts
            foreach (FormulaireEmprunt E in ficheE)
            {
                if ((E.MatriculeEtd == null) && (E.MatriculeProf == null))
                    dgEmprunt.Rows.Add(null, "Aucun", "Aucun", "Aucun", "Aucun");
                else
                {
                    if ((E.MatriculeEtd == null) && (E.MatriculeProf != null))
                        dgEmprunt.Rows.Add(null, E.MatriculeEtd, E.ISBN, E.DateEmprunt.ToString(), E.DateFin.ToString());
                    else
                        dgEmprunt.Rows.Add(null, E.MatriculeProf, E.ISBN, E.DateEmprunt.ToString(), E.DateFin.ToString());
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();
            long eff = connect.nombreTotalEmp();

            chargerdgEmprunt();
            totE.Text = eff.ToString();
            totE.Visible = true;
        }

        private void txtRechEmp_MouseClick(object sender, MouseEventArgs e)
        {
            txtRechEmp.Text = "";
        }

        private void imgRechEmp_Click(object sender, EventArgs e)
        {
            GestionnaireConnexion connect = new GestionnaireConnexion();
            List<FormulaireEmprunt> ficheE = connect.AllEmprunt();

            totE.Visible = false;
            //On rechercher un emprunt
            if ((connect.OneEtudiant(txtRechEmp.Text) == null) && (connect.OneProfesseur(txtRechEmp.Text) == null))
            {
                txtEmp.Text = "Ce lecteur n est pas enregistré!!!!";
                Transition1.ShowSync(notifE);
                notifE.Visible = true;
            }
            else
            {
                //On remplis le datgrid avec tous les emprunts
                foreach (FormulaireEmprunt E in ficheE)
                {
                    dgEmprunt.Rows.Clear();

                    if ((E.MatriculeEtd == null) && (E.MatriculeProf == null))
                        dgEmprunt.Rows.Add(null, "Aucun", "Aucun", "Aucun", "Aucun");
                    else if (E.MatriculeEtd == null)
                        dgEmprunt.Rows.Add(null, E.MatriculeProf, E.ISBN, E.DateEmprunt.ToString(), E.DateFin.ToString());
                    else
                        dgEmprunt.Rows.Add(null, E.MatriculeEtd, E.ISBN, E.DateEmprunt.ToString(), E.DateFin.ToString());
                }
            }
        }
    }
}
