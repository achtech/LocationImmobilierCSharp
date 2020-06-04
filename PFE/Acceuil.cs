using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }
        public static Acceuil Obj;
        public static Acceuil MF = new Acceuil();
        private void reservationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void ajouterImmeubilierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PFE.Immeubiliers.ListeImmeubiliers f = new PFE.Immeubiliers.ListeImmeubiliers();
            f.Show();
        }

        private void ajouterReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PFE.Reservations.AjouterReservation f = new PFE.Reservations.AjouterReservation();
            f.Show();
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilisateurs.nouveau_utilisateur f = new Utilisateurs.nouveau_utilisateur();
            f.Show();
        }

        private void listeUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilisateurs.Liste_Utilisateur f = new Utilisateurs.Liste_Utilisateur();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void sauthentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilisateurs.Authentifier f = new Utilisateurs.Authentifier();
            f.Show();
            this.Close();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilisateurs.Authentifier f = new Utilisateurs.Authentifier();
            f.Show();
            this.Close();
        }

        private void listeDesRéservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PFE.Reservations.ListeReservations f = new PFE.Reservations.ListeReservations();
            f.Show();

        }

        private void nouveauImmobilierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PFE.Immobiliers.AjouterImmeubilier f = new PFE.Immobiliers.AjouterImmeubilier();
            f.Show();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilisateurs.Ajouter_Utilisateur f = new Utilisateurs.Ajouter_Utilisateur();
            f.Show();
        }
    }
}
