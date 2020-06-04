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
    public partial class nouveau_utilisateur : Form
    {
        public nouveau_utilisateur()
        {
            InitializeComponent();
        }
        GlocationAppartementEntities1 db = new GlocationAppartementEntities1();
        private void button2_Click(object sender, EventArgs e)
        {
            nom_user.Clear();
            login_user.Clear();
            nom_user.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authentifications v = new Authentifications();
            v.nom = nom_user.Text;
            v.login = login_user.Text;
            v.password = helperClass.encrypt(login_user.Text);
            db.Authentifications.Add(v);
            db.SaveChanges();
            MessageBox.Show("Vous avez ajouter un nouveau utilisateur");
            button2_Click(sender, e);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
