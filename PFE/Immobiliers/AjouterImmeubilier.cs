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

namespace PFE.Immobiliers
{
    public partial class AjouterImmeubilier : Form
    {
        public AjouterImmeubilier()
        {
            InitializeComponent();
        }

        GlocationAppartementEntities1 db = new GlocationAppartementEntities1();

        PFE.Entities.Immeubiliers updateImmobilier = new PFE.Entities.Immeubiliers();
        PFE.Entities.Immeubiliers detailImmobilier = new PFE.Entities.Immeubiliers();

        public void remplirComboVille()
        {

            comboBoxVille.DisplayMember = "libelle_ville";
            comboBoxVille.ValueMember = "ID_ville";
            comboBoxVille.DataSource = db.Villes.Select(p => new { ID_ville = p.id_villes, libelle_ville = p.libelle }).ToList();

        }
        public void remplirComboQuartier()
        {
            int idCat;
            idCat = int.Parse(comboBoxVille.SelectedValue.ToString());
            if (idCat != 0)
            {
                comboBoxQuartier.DisplayMember = "libelle_quart";
                comboBoxQuartier.ValueMember = "ID_quartier";
                comboBoxQuartier.DataSource = db.Quartiers.Where(c => c.id_villes == idCat).Select(p => new { ID_quartier = p.id_quartiers, libelle_quart = p.libelle }).ToList();
            }

        }
        public void remplirComboCat()
        {
            comboBoxCategorie.DisplayMember = "libelle_cat";
            comboBoxCategorie.ValueMember = "ID_categorie";
            comboBoxCategorie.DataSource = db.Categories.Select(p => new { ID_categorie = p.id_categories, libelle_cat = p.libelle }).ToList();

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AjouterImmeubilier_Load(object sender, EventArgs e)
        {
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(updateImmobilier != null && updateImmobilier.id_categories != 0)
            {
                PFE.Entities.Immeubiliers updateImm = db.Immeubiliers.Where(c => c.id_immeubiliers == updateImmobilier.id_immeubiliers).First();
                updateImm.id_villes = int.Parse(comboBoxVille.SelectedValue.ToString());
                updateImm.id_quartiers = int.Parse(comboBoxQuartier.SelectedValue.ToString());
                updateImm.nbr_chambre = int.Parse(textchambre.Text.ToString());
                updateImm.superficie = int.Parse(textsype.Text.ToString());
                updateImm.tarif = int.Parse(textTarif.Text.ToString());
                updateImm.nom_proprietaire = textProp.Text.ToString();
                updateImm.tel_proprietaire = textTel.Text.ToString();
                updateImm.id_categories = int.Parse(comboBoxCategorie.SelectedValue.ToString());
                db.Entry(updateImm).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("modification avec success");

            }
            else
            {
                PFE.Entities.Immeubiliers imm = new PFE.Entities.Immeubiliers();
                imm.id_categories = int.Parse(comboBoxCategorie.SelectedValue.ToString());
                imm.id_villes = int.Parse(comboBoxVille.SelectedValue.ToString());
                imm.id_quartiers = int.Parse(comboBoxVille.SelectedValue.ToString());
                imm.nbr_chambre = int.Parse(textchambre.Text.ToString());
                imm.superficie = int.Parse(textsype.Text.ToString());
                imm.tarif = int.Parse(textTarif.Text.ToString());
                imm.nom_proprietaire = textProp.Text.ToString();
                imm.tel_proprietaire = textTel.Text.ToString();
                imm.status = "libre";
                db.Immeubiliers.Add(imm);
                db.SaveChanges();
                MessageBox.Show("Vous avez ajouter un nouveau immobilier");
                button1_Click(sender, e);
            }

        }

        private void comboBoxVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirComboQuartier();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void remplirChampText(PFE.Entities.Immeubiliers immobilierInf)
        {
            remplirComboCat();
            remplirComboVille();

            comboBoxCategorie.SelectedValue = immobilierInf.id_categories;
            comboBoxVille.SelectedValue = immobilierInf.id_villes;
            comboBoxQuartier.SelectedValue = immobilierInf.id_quartiers;
            textchambre.Text = immobilierInf.nbr_chambre.ToString();
            textsype.Text = immobilierInf.superficie.ToString();
            textTarif.Text = immobilierInf.tarif.ToString();
            textProp.Text = immobilierInf.nom_proprietaire.ToString();
            textDesc.Text = immobilierInf.description;
            textTel.Text = immobilierInf.tel_proprietaire;
            updateImmobilier = immobilierInf;
        }

        public void remplirTextOfDetails(PFE.Entities.Immeubiliers immobilierInf)
        {
            remplirComboCat();
            remplirComboVille();

            comboBoxCategorie.Enabled = true;
            comboBoxVille.Enabled = true;
            comboBoxQuartier.Enabled = true;
            textchambre.Enabled = true;
            textsype.Enabled = true;
            textTarif.Enabled = true;
            textProp.Enabled = true;
            textDesc.Enabled = true;
            textTel.Enabled = true;
            buttonValider.Enabled = false;
          

            comboBoxCategorie.SelectedValue = immobilierInf.id_categories;
            comboBoxVille.SelectedValue = immobilierInf.id_villes;
            comboBoxQuartier.SelectedValue = immobilierInf.id_quartiers;
            textchambre.Text = immobilierInf.nbr_chambre.ToString();
            textsype.Text = immobilierInf.superficie.ToString();
            textTarif.Text = immobilierInf.tarif.ToString();
            textProp.Text = immobilierInf.nom_proprietaire.ToString();
            textDesc.Text = immobilierInf.description;
            textTel.Text = immobilierInf.tel_proprietaire;
            detailImmobilier = immobilierInf;

        }
        private void comboBoxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
