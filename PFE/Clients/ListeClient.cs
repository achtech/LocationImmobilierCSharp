﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFE.Entities;

namespace PFE.Clients
{
    public partial class ListeClient : Form
    {
        public ListeClient()
        {
            InitializeComponent();
        }
        GlocationAppartementEntities1 db = new GlocationAppartementEntities1();
  
        PFE.Entities.Clients  resUpdateObject = new PFE.Entities.Clients();
        public void remplirGridViewClient()
        {
            dataGridClt.DataSource = db.Clients.Select(p => new { id_clients = p.id_clients, nom = p.nom, Cin = p.cin, tele = p.tel }).ToList();

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ListeClient_Load(object sender, EventArgs e)
        {
            remplirGridViewClient();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridRes.DataSource = null;
            if (!String.IsNullOrEmpty(nomCltTxt.Text))
            {

                dataGridClt.DataSource = db.Clients.Where(x => x.nom.Contains(nomCltTxt.Text)).Select(p => new { Numero = p.id_clients, Nom = p.nom, Cin = p.cin, Telephone = p.tel }).ToList();

            }
            if (!String.IsNullOrEmpty(cinCltText.Text))
            {
                dataGridClt.DataSource = db.Clients.Where(x => x.cin.Contains(cinCltText.Text)).Select(p => new { Numero = p.id_clients, Nom = p.nom, Cin = p.cin, Telephone = p.tel }).ToList();

            }
            if (!String.IsNullOrEmpty(nomCltTxt.Text) && !String.IsNullOrEmpty(cinCltText.Text))
            {
                dataGridClt.DataSource = db.Clients.Where(x => x.nom.Contains(nomCltTxt.Text) && x.cin.Contains(cinCltText.Text)).Select(p => new { Numero = p.id_clients, Nom = p.nom, Cin = p.cin, Telephone = p.tel }).ToList();

            }
            if (String.IsNullOrEmpty(nomCltTxt.Text) && String.IsNullOrEmpty(cinCltText.Text))
            {
                remplirGridViewClient();
            }
        }

        private void listeResvBtm_Click(object sender, EventArgs e)
        {
            if (dataGridClt.CurrentRow.Index != -1)
            {
                int id_clt = Convert.ToInt32(dataGridClt.CurrentRow.Cells[0].Value);
                dataGridRes.DataSource = db.Reservations.Where(x => x.id_clients == id_clt).Select(c => new {
                    Number = c.id_reservations,
                    Debut = c.date_debut,
                    Fin = c.date_fin,
                    CLient = c.Clients.nom,
                    Tel = c.Clients.tel,
                    Immobiler = c.Immeubiliers.Categories.libelle,
                    ville = c.Immeubiliers.Villes.libelle,
                    Tarif = c.tarif
                }).ToList();
            }
            else
            {
                MessageBox.Show("Veuillez choisir un client");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridClt.CurrentRow.Index != -1)
            {
                int id_clt = Convert.ToInt32(dataGridClt.CurrentRow.Cells[0].Value);
                var queryable = db.Reservations.Where(x => x.id_clients == id_clt);

                if (!dateTimePicker1.Text.Equals("") && !dateTimePicker2.Text.Equals(""))
                {
                    queryable = queryable.Where(x => x.date_debut >= dateTimePicker1.Value && x.date_fin <= dateTimePicker2.Value);
                }
                else
                {
                    MessageBox.Show("Veuillez introduire les deux dates");
                }

               

                dataGridRes.DataSource = queryable.Select(c => new {
                    Number = c.id_reservations,
                    Debut = c.date_debut,
                    Fin = c.date_fin,
                    CLient = c.Clients.nom,
                    Tel = c.Clients.tel,
                    Immobiler = c.Immeubiliers.Categories.libelle,
                    ville = c.Immeubiliers.Villes.libelle,
                    Tarif = c.tarif
                }).ToList();
            }
        }

        private void cinCltText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nomCltTxt.Text) && !String.IsNullOrEmpty(cinCltText.Text) && !String.IsNullOrEmpty(teleClt.Text))
            {
                PFE.Entities.Clients newClt = new PFE.Entities.Clients();
                newClt.nom = nomCltTxt.Text.ToString();
                newClt.cin = cinCltText.Text.ToString();
                newClt.tel = teleClt.Text.ToString();
                db.Clients.Add(newClt);
                db.SaveChanges();
                MessageBox.Show("client est ajouter avec succes ");
                remplirGridViewClient();

            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs ");
            }
        }

        private void modifierBtm_Click(object sender, EventArgs e)
        {
            if (dataGridClt.CurrentRow.Index != -1)
            {
                int id_clt = Convert.ToInt32(dataGridClt.CurrentRow.Cells[0].Value);
                PFE.Entities.Clients newClt = db.Clients.Where(x => x.id_clients == id_clt).First();
                newClt.nom = nomCltTxt.Text;
                newClt.cin = nomCltTxt.Text;
                newClt.tel = nomCltTxt.Text;

                db.Entry(newClt).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("modification avec success");
                remplirGridViewClient();
            }
        }

        private void dataGridClt_DoubleClick(object sender, EventArgs e)
        {
            int id_clt = Convert.ToInt32(dataGridClt.CurrentRow.Cells[0].Value);
            PFE.Entities.Clients newClt = db.Clients.Where(x => x.id_clients == id_clt).First();
            nomCltTxt.Text = newClt.nom ;
            cinCltText.Text = newClt.cin;
            nomCltTxt.Text = newClt.tel;
            
         }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
