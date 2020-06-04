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

namespace PFE.Reservations
{
    public partial class AjouterReservation : Form
    {
        public AjouterReservation()
        {
            InitializeComponent();
        }

        GlocationAppartementEntities1 db = new GlocationAppartementEntities1();
        int id_immobilier;
        PFE.Entities.Reservations resUpdateObject = new PFE.Entities.Reservations();
        public void remplirGridViewClient()
        {
            dataGridUser.DataSource = db.Clients.Select(p => new { Numero = p.id_clients, Nom = p.nom, Cin = p.cin, Telephone = p.tel }).ToList();

        }
        private void AjouterReservation_Load(object sender, EventArgs e)
        {
            remplirGridViewClient();
            dataGridUser.FirstDisplayedCell = null;
            dataGridUser.ClearSelection();
        }

        public void getIdImmobilier(int idImmobilier)
        {
            id_immobilier = idImmobilier;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (id_immobilier != 0 )
            {
                PFE.Entities.Immeubiliers immobl = db.Immeubiliers.Where(c => c.id_immeubiliers == id_immobilier).First();
                if (immobl.status.Equals("libre"))
                {
                    PFE.Entities.Reservations addReserv = new PFE.Entities.Reservations();
                    PFE.Entities.Clients client = null;

                    if (!String.IsNullOrEmpty(nomclt.Text) || !String.IsNullOrEmpty(cinclt.Text) || !String.IsNullOrEmpty(teleclt.Text))
                    {
                        client = new PFE.Entities.Clients();
                        client.nom = nomclt.Text;
                        client.cin = cinclt.Text;
                        client.tel = teleclt.Text;
                        db.Clients.Add(client);
                        db.SaveChanges();
                    }
                    else
                    {
                        int cltid = (int)dataGridUser.CurrentRow.Cells["Numero"].Value;
                        client = db.Clients.Where(c => c.id_clients== cltid).First();
                    }
                    
                  

                    PFE.Entities.Clients clt = db.Clients.Where(c => c.cin == client.cin).First();
                    addReserv.id_clients = clt.id_clients;
                    addReserv.id_immeubiliers = immobl.id_immeubiliers;
                    addReserv.nbr_personne = int.Parse(nbrclt.Text.ToString());
                    addReserv.date_debut = datedebut.Value;
                    addReserv.date_fin = datefin.Value;
                    addReserv.tarif = float.Parse(tarifText.Text.ToString());
                    addReserv.status = "reserve";
                    db.Reservations.Add(addReserv);
                    db.SaveChanges();
                    MessageBox.Show("Reservation bien effectuee");
                }
            }
            else
            {
                PFE.Entities.Reservations addReserv = db.Reservations.Where(c => c.id_reservations == resUpdateObject.id_reservations).First();
                PFE.Entities.Clients client = db.Clients.Where(c => c.id_clients == resUpdateObject.id_clients).First();

                client.nom = nomclt.Text;
                client.cin = cinclt.Text;
                client.tel = teleclt.Text;
                client.id_clients = addReserv.id_clients;
                db.Entry(client).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                addReserv.id_clients = addReserv.id_clients;
                addReserv.id_immeubiliers = addReserv.id_immeubiliers;
                addReserv.nbr_personne = int.Parse(nbrclt.Text.ToString());
                addReserv.date_debut = datedebut.Value;
                addReserv.date_fin = datefin.Value;
                addReserv.tarif = float.Parse(tarifText.Text.ToString());
                addReserv.status = "reserve";
                db.Entry(addReserv).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Modification bien effectuee");
            }
        }

        public void remplirChampUpdate(PFE.Entities.Reservations reservation)
        {
            resUpdateObject = reservation;
            PFE.Entities.Clients clt = db.Clients.Where(c => c.id_clients == reservation.id_clients).First();
            nomclt.Text = clt.nom;
            cinclt.Text = clt.cin;
            teleclt.Text = clt.tel;

            datedebut.Text = reservation.date_debut.ToString();
            datefin.Text = reservation.date_fin.ToString();
            tarifText.Text = reservation.tarif.ToString();
            nbrclt.Text = reservation.nbr_personne.ToString();
        }
        private void annulerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chercherBtm_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nomCltTxt.Text))
            {
            
                dataGridUser.DataSource = db.Clients.Where(x => x.nom.Contains(nomCltTxt.Text)).Select(p => new { Numero = p.id_clients, Nom = p.nom, Cin = p.cin, Telephone = p.tel }).ToList();

            }
            if (!String.IsNullOrEmpty(cinCltText.Text))
            {
                dataGridUser.DataSource = db.Clients.Where(x => x.cin.Contains(cinCltText.Text)).Select(p => new { Numero = p.id_clients, Nom = p.nom, Cin = p.cin, Telephone = p.tel }).ToList();

            }
            if (!String.IsNullOrEmpty(nomCltTxt.Text) && !String.IsNullOrEmpty(cinCltText.Text))
            {
                dataGridUser.DataSource = db.Clients.Where(x => x.nom.Contains(nomCltTxt.Text) && x.cin.Contains(cinCltText.Text)).Select(p => new { Numero = p.id_clients, Nom = p.nom, Cin = p.cin, Telephone = p.tel }).ToList();

            }
            if (String.IsNullOrEmpty(nomCltTxt.Text) && String.IsNullOrEmpty(cinCltText.Text))
            {
                remplirGridViewClient();
            }
        }

        private void existClient_Click(object sender, EventArgs e)
        {
            groupBoxClt.Enabled = true;

        }
    }
}
