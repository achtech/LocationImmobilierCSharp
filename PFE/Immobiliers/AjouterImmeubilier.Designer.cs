namespace PFE.Immobiliers
{
    partial class AjouterImmeubilier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterImmeubilier));
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.comboBoxQuartier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textchambre = new System.Windows.Forms.TextBox();
            this.textsype = new System.Windows.Forms.TextBox();
            this.textTarif = new System.Windows.Forms.TextBox();
            this.textProp = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.textDesc = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.ItemHeight = 29;
            this.comboBoxCategorie.Location = new System.Drawing.Point(207, 116);
            this.comboBoxCategorie.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCategorie.MaxLength = 30;
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(217, 37);
            this.comboBoxCategorie.TabIndex = 0;
            this.comboBoxCategorie.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategorie_SelectedIndexChanged);
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(207, 162);
            this.comboBoxVille.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(217, 37);
            this.comboBoxVille.TabIndex = 1;
            this.comboBoxVille.SelectedIndexChanged += new System.EventHandler(this.comboBoxVille_SelectedIndexChanged);
            // 
            // comboBoxQuartier
            // 
            this.comboBoxQuartier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxQuartier.FormattingEnabled = true;
            this.comboBoxQuartier.Location = new System.Drawing.Point(207, 207);
            this.comboBoxQuartier.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxQuartier.Name = "comboBoxQuartier";
            this.comboBoxQuartier.Size = new System.Drawing.Size(217, 37);
            this.comboBoxQuartier.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(62, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(62, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ville";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(63, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quartier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(62, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chambre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(501, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Superficie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(501, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tarif Journalier";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(501, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 27);
            this.label8.TabIndex = 10;
            this.label8.Text = "Propriaitaire";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(497, 255);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 27);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tel Propriaitaire";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(44, 319);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 27);
            this.label10.TabIndex = 12;
            this.label10.Text = "Description";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(319, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(284, 37);
            this.label11.TabIndex = 13;
            this.label11.Text = "Ajouter Immobilier";
            // 
            // textchambre
            // 
            this.textchambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textchambre.Location = new System.Drawing.Point(207, 252);
            this.textchambre.Margin = new System.Windows.Forms.Padding(4);
            this.textchambre.Name = "textchambre";
            this.textchambre.Size = new System.Drawing.Size(217, 34);
            this.textchambre.TabIndex = 14;
            // 
            // textsype
            // 
            this.textsype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsype.Location = new System.Drawing.Point(695, 210);
            this.textsype.Margin = new System.Windows.Forms.Padding(4);
            this.textsype.Name = "textsype";
            this.textsype.Size = new System.Drawing.Size(217, 34);
            this.textsype.TabIndex = 15;
            // 
            // textTarif
            // 
            this.textTarif.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTarif.Location = new System.Drawing.Point(697, 109);
            this.textTarif.Margin = new System.Windows.Forms.Padding(4);
            this.textTarif.Name = "textTarif";
            this.textTarif.Size = new System.Drawing.Size(217, 34);
            this.textTarif.TabIndex = 16;
            // 
            // textProp
            // 
            this.textProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProp.Location = new System.Drawing.Point(697, 162);
            this.textProp.Margin = new System.Windows.Forms.Padding(4);
            this.textProp.Name = "textProp";
            this.textProp.Size = new System.Drawing.Size(217, 34);
            this.textProp.TabIndex = 18;
            // 
            // textTel
            // 
            this.textTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTel.Location = new System.Drawing.Point(697, 253);
            this.textTel.Margin = new System.Windows.Forms.Padding(4);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(217, 34);
            this.textTel.TabIndex = 19;
            // 
            // textDesc
            // 
            this.textDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDesc.Location = new System.Drawing.Point(190, 324);
            this.textDesc.Margin = new System.Windows.Forms.Padding(4);
            this.textDesc.Multiline = true;
            this.textDesc.Name = "textDesc";
            this.textDesc.Size = new System.Drawing.Size(682, 101);
            this.textDesc.TabIndex = 20;
            // 
            // buttonValider
            // 
            this.buttonValider.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.ForeColor = System.Drawing.Color.Navy;
            this.buttonValider.Location = new System.Drawing.Point(287, 433);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(4);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(165, 50);
            this.buttonValider.TabIndex = 21;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.ForeColor = System.Drawing.Color.Navy;
            this.buttonAnnuler.Location = new System.Drawing.Point(489, 433);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(165, 50);
            this.buttonAnnuler.TabIndex = 22;
            this.buttonAnnuler.Text = "Annler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // AjouterImmeubilier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1014, 536);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textDesc);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.textProp);
            this.Controls.Add(this.textTarif);
            this.Controls.Add(this.textsype);
            this.Controls.Add(this.textchambre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxQuartier);
            this.Controls.Add(this.comboBoxVille);
            this.Controls.Add(this.comboBoxCategorie);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AjouterImmeubilier";
            this.Text = "AjouterImmeubilier";
            this.Load += new System.EventHandler(this.AjouterImmeubilier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategorie;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.ComboBox comboBoxQuartier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textchambre;
        private System.Windows.Forms.TextBox textsype;
        private System.Windows.Forms.TextBox textTarif;
        private System.Windows.Forms.TextBox textProp;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.TextBox textDesc;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
    }
}