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
    public partial class Liste_Utilisateur : Form
    {
        public Liste_Utilisateur()
        {
            InitializeComponent();
        }

        GlocationAppartementEntities1 db = new GlocationAppartementEntities1();
        Authentifications user = new Authentifications();
        private void Liste_Utilisateur_Load(object sender, EventArgs e)
        {
            // display info categorie in dataGrid
            dataGridView1.DataSource = db.Authentifications.Select(p => new { Nom = p.nom, Login = p.login, id_user = p.id_utilisateurs }).ToList();
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            if(dataGridView1.CurrentRow.Index != -1)
            {
                int id_utilisateurs = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_user"].Value);
                user = db.Authentifications.Where(c => c.id_utilisateurs == id_utilisateurs).First();
                Ajouter_Utilisateur userModif = new Ajouter_Utilisateur();
                userModif.remplirChampText(user);
                userModif.Show();
            }
        }
    }
}
