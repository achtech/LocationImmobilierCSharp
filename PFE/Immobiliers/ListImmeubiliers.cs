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

namespace PFE.Immeubiliers
{
    public partial class ListeImmeubiliers : Form
    {
        public ListeImmeubiliers()
        {
            InitializeComponent();
        }
        GlocationAppartementEntities1 db = new GlocationAppartementEntities1();

        public void remplirComboVille()
        {

            comboBoxVille.DisplayMember = "libelle_ville";
            comboBoxVille.ValueMember = "ID_ville";
            comboBoxVille.DataSource = db.Villes.Select(p => new { ID_ville= p.id_villes, libelle_ville = p.libelle }).ToList();
           
        }
        public void remplirComboQuartier()
        {
            int idCat;
            idCat = int.Parse(comboBoxVille.SelectedValue.ToString());
            if(idCat != 0)
            {
                comboBoxQuart.DisplayMember = "libelle_quart";
                comboBoxQuart.ValueMember = "ID_quartier";
                comboBoxQuart.DataSource = db.Quartiers.Where(c => c.id_villes == idCat).Select(p => new { ID_quartier = p.id_quartiers, libelle_quart = p.libelle }).ToList();
            }
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Ajouter_Immeubilier_Load(object sender, EventArgs e)
        {
            remplirComboVille();
            
            dataGridView1.DataSource = db.Immeubiliers.Select(c => new {
                Number = c.id_immeubiliers,
                Catgorie = c.Categories.libelle,
                Ville = c.Villes.libelle,
                Quartier = c.Quartiers.libelle,
                Chambre = c.nbr_chambre,
                Tarif = c.tarif,
                Status = c.status,
                Superficie = c.superficie,
            }).ToList();
            dataGridView1.FirstDisplayedCell = null;
            dataGridView1.ClearSelection();

        }

        private void comboBoxQuart_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirComboQuartier();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var queryable = db.Immeubiliers.Where(x => x.status == "libre");
                if (appartCheck.Checked) 
                    queryable = queryable.Where(x => x.id_categories == 1);
                else if (maisonCheck.Checked)
                    queryable = queryable.Where(x => x.id_categories == 2);
                else if (bureauCheck.Checked)
                    queryable = queryable.Where(x => x.id_categories == 3);
                else if (magazinCheck.Checked)
                    queryable = queryable.Where(x => x.id_categories == 4);
                else if (terrainCheck.Checked)
                    queryable = queryable.Where(x => x.id_categories == 5);
                else if (allCheck.Checked)
                    queryable = queryable.Where(x => x.id_categories == 6);

            
            if (!String.IsNullOrEmpty(prixMaxText.Text))
            {
                int prixmax = int.Parse(prixMaxText.Text.ToString());
                queryable = queryable.Where(x => x.tarif <= prixmax);
            }

            if (!String.IsNullOrEmpty(prixMinText.Text))
            {
                int prixmin = int.Parse(prixMinText.Text.ToString());
                queryable = queryable.Where(x => x.tarif >= prixmin);
            }

            if (!String.IsNullOrEmpty(surfaceMaxText.Text))
            {
                int max = int.Parse(surfaceMaxText.Text.ToString());
                queryable = queryable.Where(x => x.superficie <= max );
            }

            if (!String.IsNullOrEmpty(surrfaceMinText.Text))
            {
                int min = int.Parse(surrfaceMinText.Text.ToString());
                queryable = queryable.Where(x => x.superficie >= min);
            }

            if (!String.IsNullOrEmpty(nbrChambreText.Text))
            {
                int nbr = int.Parse(nbrChambreText.Text.ToString());
                queryable = queryable.Where(x => x.nbr_chambre == nbr);
            }

            if (reserveRadio.Checked == true)
            {
                queryable = queryable.Where(x => x.status == "reserver");
            }

            if (libreRadio.Checked == true)
            {
                queryable = queryable.Where(x => x.status == "libre");
            }
                
            if (comboBoxVille.SelectedIndex > -1)
            {
                int id = int.Parse(comboBoxVille.SelectedValue.ToString());
                queryable = queryable.Where(x => x.id_villes == id);
            }

            if (comboBoxQuart.SelectedIndex > -1)
            {
                int id = int.Parse(comboBoxQuart.SelectedValue.ToString());
                queryable = queryable.Where(x => x.id_quartiers == id);
            }

            dataGridView1.DataSource = queryable.Select(c => new {
                Number = c.id_immeubiliers,
                Catgorie = c.Categories.libelle,
                Ville = c.Villes.libelle,
                Quartier = c.Quartiers.libelle,
                Chambre = c.nbr_chambre,
                Tarif = c.tarif,
                Status = c.status,
                Superficie = c.superficie,
            }).ToList();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                int iddetails = (int)dataGridView1.CurrentRow.Cells["Number"].Value;
                PFE.Immobiliers.AjouterImmeubilier userModif = new PFE.Immobiliers.AjouterImmeubilier();
                PFE.Entities.Immeubiliers ObjectImm = db.Immeubiliers.Where(c => c.id_immeubiliers == iddetails).First();
                userModif.remplirTextOfDetails(ObjectImm);
                this.Hide();
                userModif.Show();
            }
            else
            {
                MessageBox.Show("Veuillez choisir un element parmi la liste");
            }
        }

        public void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                int id_imm = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Number"].Value);
                PFE.Entities.Immeubiliers Objimm = db.Immeubiliers.Where(c => c.id_immeubiliers == id_imm).First();
                PFE.Immobiliers.AjouterImmeubilier userModif = new PFE.Immobiliers.AjouterImmeubilier();
                userModif.remplirChampText(Objimm);
                this.Hide();
                userModif.Show();
            }
            else
            {
                MessageBox.Show("Veuillez choisir un element parmi la liste");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                btDetail.Enabled = true;
                btModifier.Enabled = true;
                btReserver.Enabled = true;
            }
        }

        private void btReserver_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                PFE.Reservations.AjouterReservation reserve = new PFE.Reservations.AjouterReservation();
                int id_imm = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Number"].Value);
                reserve.getIdImmobilier(id_imm);
                this.Hide();
                reserve.Show();
            }
            else
            {
                MessageBox.Show("Veuillez choisir un element parmi la liste");
            }
        }
    }
}
