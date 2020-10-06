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
    public partial class formConnexion : Form
    {
        //Déclaration de la fonction qui va permettre d'embellir le backcolor des bouton de connexion
        public void embellireBouton()
        {
            this.Annuler.BackColor = Color.WhiteSmoke;
            this.Connexion.BackColor = Color.WhiteSmoke;
        }

        public formConnexion()
        {
            InitializeComponent();
            embellireBouton();
        }


        //Méthode qui s'exécute lors du clic sur le bouton Annuler
        private void Annuler_Click(object sender, EventArgs e)
        {
            Password.Text = "Saisir le Password";
            Login.Text = "Saisir le Login";
            Login.Focus();
        }

        //Méthode qui s'exécute lorsque le Login a le focus
        private void Login_MouseEnter(object sender, EventArgs e)
        {
            Login.Text = "";
            if ((Password.Text == "") || (Password.Text == "Saisir le Password"))
                Password.Text = "Saisir le Password";
        }

        //Méthode qui s'exécute lorsque le Password a le focus
        private void Password_MouseEnter(object sender, EventArgs e)
        {
            Password.Text = "";
            if ((Login.Text == "") || (Login.Text == "Saisir le Login"))
                Login.Text = "Saisir le Login";
        }


        //Méthode qui permet de fermer le formulaire de connexion
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        

    }
}
