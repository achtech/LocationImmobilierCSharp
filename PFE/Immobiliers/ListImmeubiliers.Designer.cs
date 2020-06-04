using System;

namespace PFE.Immeubiliers
{
    partial class ListeImmeubiliers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeImmeubiliers));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.libreRadio = new System.Windows.Forms.RadioButton();
            this.reserveRadio = new System.Windows.Forms.RadioButton();
            this.btRechercher = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxQuart = new System.Windows.Forms.ComboBox();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.nbrChambreText = new System.Windows.Forms.TextBox();
            this.surfaceMaxText = new System.Windows.Forms.TextBox();
            this.prixMaxText = new System.Windows.Forms.TextBox();
            this.surrfaceMinText = new System.Windows.Forms.TextBox();
            this.prixMinText = new System.Windows.Forms.TextBox();
            this.allCheck = new System.Windows.Forms.CheckBox();
            this.terrainCheck = new System.Windows.Forms.CheckBox();
            this.magazinCheck = new System.Windows.Forms.CheckBox();
            this.bureauCheck = new System.Windows.Forms.CheckBox();
            this.maisonCheck = new System.Windows.Forms.CheckBox();
            this.appartCheck = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btReserver = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.btDetail = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(262, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des Immeubiliers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btRechercher);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxQuart);
            this.groupBox1.Controls.Add(this.comboBoxVille);
            this.groupBox1.Controls.Add(this.nbrChambreText);
            this.groupBox1.Controls.Add(this.surfaceMaxText);
            this.groupBox1.Controls.Add(this.prixMaxText);
            this.groupBox1.Controls.Add(this.surrfaceMinText);
            this.groupBox1.Controls.Add(this.prixMinText);
            this.groupBox1.Controls.Add(this.allCheck);
            this.groupBox1.Controls.Add(this.terrainCheck);
            this.groupBox1.Controls.Add(this.magazinCheck);
            this.groupBox1.Controls.Add(this.bureauCheck);
            this.groupBox1.Controls.Add(this.maisonCheck);
            this.groupBox1.Controls.Add(this.appartCheck);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(63, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(981, 336);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.libreRadio);
            this.groupBox3.Controls.Add(this.reserveRadio);
            this.groupBox3.Location = new System.Drawing.Point(598, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 74);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // libreRadio
            // 
            this.libreRadio.AutoSize = true;
            this.libreRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libreRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.libreRadio.Location = new System.Drawing.Point(185, 28);
            this.libreRadio.Margin = new System.Windows.Forms.Padding(4);
            this.libreRadio.Name = "libreRadio";
            this.libreRadio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.libreRadio.Size = new System.Drawing.Size(76, 29);
            this.libreRadio.TabIndex = 21;
            this.libreRadio.TabStop = true;
            this.libreRadio.Text = "Libre";
            this.libreRadio.UseVisualStyleBackColor = true;
            // 
            // reserveRadio
            // 
            this.reserveRadio.AutoSize = true;
            this.reserveRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.reserveRadio.Location = new System.Drawing.Point(42, 28);
            this.reserveRadio.Margin = new System.Windows.Forms.Padding(4);
            this.reserveRadio.Name = "reserveRadio";
            this.reserveRadio.Size = new System.Drawing.Size(105, 29);
            this.reserveRadio.TabIndex = 20;
            this.reserveRadio.TabStop = true;
            this.reserveRadio.Text = "Reservé";
            this.reserveRadio.UseVisualStyleBackColor = true;
            // 
            // btRechercher
            // 
            this.btRechercher.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRechercher.Location = new System.Drawing.Point(781, 277);
            this.btRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.btRechercher.Name = "btRechercher";
            this.btRechercher.Size = new System.Drawing.Size(185, 50);
            this.btRechercher.TabIndex = 22;
            this.btRechercher.Text = "Recherche";
            this.btRechercher.UseVisualStyleBackColor = false;
            this.btRechercher.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(324, 189);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Quartier";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(24, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ville";
            // 
            // comboBoxQuart
            // 
            this.comboBoxQuart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBoxQuart.FormattingEnabled = true;
            this.comboBoxQuart.Location = new System.Drawing.Point(329, 213);
            this.comboBoxQuart.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxQuart.Name = "comboBoxQuart";
            this.comboBoxQuart.Size = new System.Drawing.Size(248, 37);
            this.comboBoxQuart.TabIndex = 17;
            this.comboBoxQuart.SelectedValueChanged += new System.EventHandler(this.comboBoxQuart_SelectedValueChanged);
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(29, 213);
            this.comboBoxVille.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(287, 37);
            this.comboBoxVille.TabIndex = 16;
            this.comboBoxVille.SelectedIndexChanged += new System.EventHandler(this.comboBoxVille_SelectedIndexChanged);
            // 
            // nbrChambreText
            // 
            this.nbrChambreText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.nbrChambreText.Location = new System.Drawing.Point(741, 117);
            this.nbrChambreText.Margin = new System.Windows.Forms.Padding(4);
            this.nbrChambreText.Name = "nbrChambreText";
            this.nbrChambreText.Size = new System.Drawing.Size(175, 34);
            this.nbrChambreText.TabIndex = 15;
            // 
            // surfaceMaxText
            // 
            this.surfaceMaxText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.surfaceMaxText.Location = new System.Drawing.Point(565, 117);
            this.surfaceMaxText.Margin = new System.Windows.Forms.Padding(4);
            this.surfaceMaxText.Name = "surfaceMaxText";
            this.surfaceMaxText.Size = new System.Drawing.Size(175, 34);
            this.surfaceMaxText.TabIndex = 14;
            this.surfaceMaxText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // prixMaxText
            // 
            this.prixMaxText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.prixMaxText.Location = new System.Drawing.Point(209, 117);
            this.prixMaxText.Margin = new System.Windows.Forms.Padding(4);
            this.prixMaxText.Name = "prixMaxText";
            this.prixMaxText.Size = new System.Drawing.Size(175, 34);
            this.prixMaxText.TabIndex = 13;
            // 
            // surrfaceMinText
            // 
            this.surrfaceMinText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.surrfaceMinText.Location = new System.Drawing.Point(387, 117);
            this.surrfaceMinText.Margin = new System.Windows.Forms.Padding(4);
            this.surrfaceMinText.Name = "surrfaceMinText";
            this.surrfaceMinText.Size = new System.Drawing.Size(175, 34);
            this.surrfaceMinText.TabIndex = 12;
            // 
            // prixMinText
            // 
            this.prixMinText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.prixMinText.Location = new System.Drawing.Point(29, 117);
            this.prixMinText.Margin = new System.Windows.Forms.Padding(4);
            this.prixMinText.Name = "prixMinText";
            this.prixMinText.Size = new System.Drawing.Size(175, 34);
            this.prixMinText.TabIndex = 11;
            // 
            // allCheck
            // 
            this.allCheck.AutoSize = true;
            this.allCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.allCheck.Location = new System.Drawing.Point(855, 39);
            this.allCheck.Margin = new System.Windows.Forms.Padding(4);
            this.allCheck.Name = "allCheck";
            this.allCheck.Size = new System.Drawing.Size(82, 28);
            this.allCheck.TabIndex = 10;
            this.allCheck.Text = "Autre";
            this.allCheck.UseVisualStyleBackColor = true;
            // 
            // terrainCheck
            // 
            this.terrainCheck.AutoSize = true;
            this.terrainCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terrainCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.terrainCheck.Location = new System.Drawing.Point(672, 39);
            this.terrainCheck.Margin = new System.Windows.Forms.Padding(4);
            this.terrainCheck.Name = "terrainCheck";
            this.terrainCheck.Size = new System.Drawing.Size(166, 28);
            this.terrainCheck.TabIndex = 9;
            this.terrainCheck.Text = "Terrain/Ferme";
            this.terrainCheck.UseVisualStyleBackColor = true;
            this.terrainCheck.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // magazinCheck
            // 
            this.magazinCheck.AutoSize = true;
            this.magazinCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magazinCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.magazinCheck.Location = new System.Drawing.Point(554, 39);
            this.magazinCheck.Margin = new System.Windows.Forms.Padding(4);
            this.magazinCheck.Name = "magazinCheck";
            this.magazinCheck.Size = new System.Drawing.Size(110, 28);
            this.magazinCheck.TabIndex = 8;
            this.magazinCheck.Text = "Magasin";
            this.magazinCheck.UseVisualStyleBackColor = true;
            this.magazinCheck.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // bureauCheck
            // 
            this.bureauCheck.AutoSize = true;
            this.bureauCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bureauCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bureauCheck.Location = new System.Drawing.Point(360, 39);
            this.bureauCheck.Margin = new System.Windows.Forms.Padding(4);
            this.bureauCheck.Name = "bureauCheck";
            this.bureauCheck.Size = new System.Drawing.Size(181, 28);
            this.bureauCheck.TabIndex = 7;
            this.bureauCheck.Text = "Burreau/Plateau";
            this.bureauCheck.UseVisualStyleBackColor = true;
            // 
            // maisonCheck
            // 
            this.maisonCheck.AutoSize = true;
            this.maisonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maisonCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.maisonCheck.Location = new System.Drawing.Point(197, 39);
            this.maisonCheck.Margin = new System.Windows.Forms.Padding(4);
            this.maisonCheck.Name = "maisonCheck";
            this.maisonCheck.Size = new System.Drawing.Size(145, 28);
            this.maisonCheck.TabIndex = 6;
            this.maisonCheck.Text = "Maison/Villa";
            this.maisonCheck.UseVisualStyleBackColor = true;
            // 
            // appartCheck
            // 
            this.appartCheck.AutoSize = true;
            this.appartCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appartCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.appartCheck.Location = new System.Drawing.Point(34, 39);
            this.appartCheck.Margin = new System.Windows.Forms.Padding(4);
            this.appartCheck.Name = "appartCheck";
            this.appartCheck.Size = new System.Drawing.Size(151, 28);
            this.appartCheck.TabIndex = 5;
            this.appartCheck.Text = "Appartement";
            this.appartCheck.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(738, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre des Chambres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(560, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Superficie maximal";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(382, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Superficie minimal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(207, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prix Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(30, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prix Min";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btReserver);
            this.groupBox2.Controls.Add(this.btModifier);
            this.groupBox2.Controls.Add(this.btDetail);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(63, 426);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(981, 297);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des immobiliers";
            // 
            // btReserver
            // 
            this.btReserver.Location = new System.Drawing.Point(366, 35);
            this.btReserver.Name = "btReserver";
            this.btReserver.Size = new System.Drawing.Size(160, 40);
            this.btReserver.TabIndex = 3;
            this.btReserver.Text = "Reserver";
            this.btReserver.UseVisualStyleBackColor = true;
            this.btReserver.Click += new System.EventHandler(this.btReserver_Click);
            // 
            // btModifier
            // 
            this.btModifier.Location = new System.Drawing.Point(199, 34);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(160, 40);
            this.btModifier.TabIndex = 2;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = true;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // btDetail
            // 
            this.btDetail.Location = new System.Drawing.Point(34, 34);
            this.btDetail.Name = "btDetail";
            this.btDetail.Size = new System.Drawing.Size(160, 40);
            this.btDetail.TabIndex = 1;
            this.btDetail.Text = "Detail";
            this.btDetail.UseVisualStyleBackColor = true;
            this.btDetail.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(956, 196);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // ListeImmeubiliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1101, 736);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListeImmeubiliers";
            this.Text = "Ajouter_Immeubilier";
            this.Load += new System.EventHandler(this.Ajouter_Immeubilier_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btRechercher;
        private System.Windows.Forms.RadioButton libreRadio;
        private System.Windows.Forms.RadioButton reserveRadio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxQuart;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.TextBox nbrChambreText;
        private System.Windows.Forms.TextBox surfaceMaxText;
        private System.Windows.Forms.TextBox prixMaxText;
        private System.Windows.Forms.TextBox surrfaceMinText;
        private System.Windows.Forms.TextBox prixMinText;
        private System.Windows.Forms.CheckBox allCheck;
        private System.Windows.Forms.CheckBox terrainCheck;
        private System.Windows.Forms.CheckBox magazinCheck;
        private System.Windows.Forms.CheckBox bureauCheck;
        private System.Windows.Forms.CheckBox maisonCheck;
        private System.Windows.Forms.CheckBox appartCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btDetail;
        private System.Windows.Forms.Button btReserver;
        private System.Windows.Forms.Button btModifier;
    }
}