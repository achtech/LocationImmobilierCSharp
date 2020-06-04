using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE.Reservations
{
    public partial class ListeReservations : Form
    {
        public ListeReservations()
        {
            InitializeComponent();
        }
        PFE.Entities.GlocationAppartementEntities1 db = new PFE.Entities.GlocationAppartementEntities1();

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var queryable = db.Reservations.Where(x => x.id_reservations >0);
            if (checkBox1.Checked)
                queryable = queryable.Where(x => x.Immeubiliers.id_categories == 1);
            else if (checkBox2.Checked)
                queryable = queryable.Where(x => x.Immeubiliers.id_categories == 2);
            else if (checkBox3.Checked)
                queryable = queryable.Where(x => x.Immeubiliers.id_categories == 3);
            else if (checkBox4.Checked)
                queryable = queryable.Where(x => x.Immeubiliers.id_categories == 4);
            else if (checkBox5.Checked)
                queryable = queryable.Where(x => x.Immeubiliers.id_categories == 5);
            else if (checkBox6.Checked)
                queryable = queryable.Where(x => x.Immeubiliers.id_categories == 6);


            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                queryable = queryable.Where(x => x.Clients.nom.Contains(textBox2.Text));
            }

            if (!String.IsNullOrEmpty(textBox4.Text))
            {
                queryable = queryable.Where(x => x.Clients.cin.Contains(textBox4.Text));
            }


            if (comboBox1.SelectedIndex > -1)
            {
                int id = int.Parse(comboBox1.SelectedValue.ToString());
                queryable = queryable.Where(x => x.Immeubiliers.id_villes == id);
            }

            if (comboBox2.SelectedIndex > -1)
            {
                int id = int.Parse(comboBox2.SelectedValue.ToString());
                queryable = queryable.Where(x => x.Immeubiliers.id_quartiers == id);
            }

            if (!dateTimePicker1.Text.Equals(""))
            {
                queryable = queryable.Where(x => x.date_debut >=  dateTimePicker1.Value );
            }

            if (!dateTimePicker2.Text.Equals(""))
            {
                queryable = queryable.Where(x => x.date_fin <= dateTimePicker2.Value);
            }

            dataGridView1.DataSource = queryable.Select(c => new {
                Number = c.id_reservations,
                Debut = c.date_debut,
                Fin = c.date_fin,
                CLient = c.Clients.nom,
                Tel = c.Clients.tel,
                Tarif = c.tarif
            }).ToList(); 
        }

        private void ListeReservations_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.Reservations.Select(c => new {
                Number = c.id_reservations,
                Debut = c.date_debut,
                Fin = c.date_fin,
                CLient = c.Clients.nom,
                Tel = c.Clients.tel,
                Tarif = c.tarif
            }).ToList();
            remplirComboVille();
          
        }


        public void remplirComboVille()
        {

            comboBox1.DisplayMember = "libelle_ville";
            comboBox1.ValueMember = "ID_ville";
            comboBox1.DataSource = db.Villes.Select(p => new { ID_ville = p.id_villes, libelle_ville = p.libelle }).ToList();

        }
        public void remplirComboQuartier()
        {
            int idCat;
            idCat = int.Parse(comboBox1.SelectedValue.ToString());
            if (idCat != 0)
            {
                comboBox2.DisplayMember = "libelle_quart";
                comboBox2.ValueMember = "ID_quartier";
                comboBox2.DataSource = db.Quartiers.Where(c => c.id_villes == idCat).Select(p => new { ID_quartier = p.id_quartiers, libelle_quart = p.libelle }).ToList();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirComboQuartier();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex > 0)
            {
                /*btDetail.Enabled = true;
                btModifier.Enabled = true;
                btReserver.Enabled = true;*/
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                int id_imm = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Number"].Value);
                PFE.Entities.Reservations Objimm = db.Reservations.Where(c => c.id_reservations == id_imm).First();
                PFE.Reservations.AjouterReservation resModif = new PFE.Reservations.AjouterReservation();
                resModif.remplirChampUpdate(Objimm);
                this.Hide();
                resModif.Show();
            }
            else
            {
                MessageBox.Show("Veuillez choisir un element parmi la liste");
            }
        }
    }
}
