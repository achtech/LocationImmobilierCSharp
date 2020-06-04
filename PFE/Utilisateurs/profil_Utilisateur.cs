using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFE.Entities;

namespace PFE.Utilisateurs
{
    public partial class Ajouter_Utilisateur : Form
    {
        
        public Ajouter_Utilisateur()
        {
            InitializeComponent();
        }
        GlocationAppartementEntities1 db = new GlocationAppartementEntities1();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Authentifier.currentUser != null && Authentifier.currentUser.login != null)
            {
                try
                {

                    Authentifications usrm = db.Authentifications.Where(c => c.id_utilisateurs == Authentifier.currentUser.id_utilisateurs).First();
                    usrm.nom = nom_user.Text;
                    usrm.login = login_user.Text;
                    usrm.password = password_user.Text;
                    if (!login_user.Text.Equals("") && !nom_user.Text.Equals("") && !password_user.Text.Equals(confirm_user.Text))
                    {
                        MessageBox.Show("confirme password ne correspoend pas au premier password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        if (!login_user.Text.Equals("") && !nom_user.Text.Equals(""))
                        {
                            usrm.password = helperClass.encrypt(password_user.Text);
                            db.Entry(usrm).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            MessageBox.Show("Modification avec succes");
                            button2_Click(sender, e);
                        }
                          
                    }


                }
                catch
                {
                    MessageBox.Show("problem de modification");
                }
               
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nom_user.Clear();
            login_user.Clear();
            password_user.Clear();
            confirm_user.Clear();
            nom_user.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void remplirChampText(Authentifications user)
        {
            if(user != null)
            {
                Authentifier.currentUser = user;
                nom_user.Text = user.nom;
                login_user.Text = user.login;
            }   

        }
        private void Ajouter_Utilisateur_Load(object sender, EventArgs e)
        {
            if(Authentifier.currentUser != null && Authentifier.currentUser.login != null)
            {
                nom_user.Text = Authentifier.currentUser.nom;
                login_user.Text = Authentifier.currentUser.login;
            }
        }
    }
}
