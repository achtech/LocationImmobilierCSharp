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
    public partial class Authentifier : Form
    {
        public Authentifier()
        {
            InitializeComponent();
        }
        GlocationAppartementEntities1 db = new GlocationAppartementEntities1();
        private void button1_Click(object sender, EventArgs e)
        {

            var username = textBox1.Text;
            var password = helperClass.encrypt(textBox2.Text);
           
            int existe = db.Authentifications.Where(c => c.login == username && c.password == password).Count();
            
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Enrez votre Mot de passe", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (existe != 0)
                    {
                    Authentifier.currentUser = db.Authentifications.Where(c => c.login == username && c.password == password).First();
                    Acceuil Ac = new Acceuil();
                        Ac.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Login ou mot de passe incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

           

            }
            db.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Authentifier_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public static Authentifications currentUser;
    }
}
