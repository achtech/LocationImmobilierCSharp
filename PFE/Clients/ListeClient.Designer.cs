namespace PFE.Clients
{
    partial class ListeClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeClient));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridClt = new System.Windows.Forms.DataGridView();
            this.dataGridRes = new System.Windows.Forms.DataGridView();
            this.nomCltTxt = new System.Windows.Forms.TextBox();
            this.cinCltText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.chercherBtm = new System.Windows.Forms.Button();
            this.ajouterBtm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listeResvBtm = new System.Windows.Forms.Button();
            this.teleClt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.modifierBtm = new System.Windows.Forms.Button();
            this.idclientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(400, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion Client";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modifierBtm);
            this.groupBox1.Controls.Add(this.teleClt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.listeResvBtm);
            this.groupBox1.Controls.Add(this.ajouterBtm);
            this.groupBox1.Controls.Add(this.chercherBtm);
            this.groupBox1.Controls.Add(this.cinCltText);
            this.groupBox1.Controls.Add(this.nomCltTxt);
            this.groupBox1.Controls.Add(this.dataGridClt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1097, 332);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clients";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dataGridRes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1097, 305);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(22, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cin";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridClt
            // 
            this.dataGridClt.AutoGenerateColumns = false;
            this.dataGridClt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclientsDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.cinDataGridViewTextBoxColumn});
            this.dataGridClt.DataSource = this.clientsBindingSource;
            this.dataGridClt.Location = new System.Drawing.Point(397, 29);
            this.dataGridClt.Name = "dataGridClt";
            this.dataGridClt.RowTemplate.Height = 24;
            this.dataGridClt.Size = new System.Drawing.Size(681, 272);
            this.dataGridClt.TabIndex = 2;
            this.dataGridClt.DoubleClick += new System.EventHandler(this.dataGridClt_DoubleClick);
            // 
            // dataGridRes
            // 
            this.dataGridRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRes.Location = new System.Drawing.Point(39, 67);
            this.dataGridRes.Name = "dataGridRes";
            this.dataGridRes.RowTemplate.Height = 24;
            this.dataGridRes.Size = new System.Drawing.Size(1039, 219);
            this.dataGridRes.TabIndex = 3;
            // 
            // nomCltTxt
            // 
            this.nomCltTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomCltTxt.Location = new System.Drawing.Point(108, 53);
            this.nomCltTxt.Name = "nomCltTxt";
            this.nomCltTxt.Size = new System.Drawing.Size(219, 30);
            this.nomCltTxt.TabIndex = 3;
            // 
            // cinCltText
            // 
            this.cinCltText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinCltText.Location = new System.Drawing.Point(109, 104);
            this.cinCltText.Name = "cinCltText";
            this.cinCltText.Size = new System.Drawing.Size(218, 30);
            this.cinCltText.TabIndex = 4;
            this.cinCltText.TextChanged += new System.EventHandler(this.cinCltText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(34, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date debut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(420, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date fin";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 30);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(531, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(222, 30);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // chercherBtm
            // 
            this.chercherBtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chercherBtm.ForeColor = System.Drawing.Color.Navy;
            this.chercherBtm.Location = new System.Drawing.Point(272, 217);
            this.chercherBtm.Name = "chercherBtm";
            this.chercherBtm.Size = new System.Drawing.Size(114, 33);
            this.chercherBtm.TabIndex = 5;
            this.chercherBtm.Text = "Chercher";
            this.chercherBtm.UseVisualStyleBackColor = true;
            this.chercherBtm.Click += new System.EventHandler(this.button1_Click);
            // 
            // ajouterBtm
            // 
            this.ajouterBtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterBtm.ForeColor = System.Drawing.Color.Navy;
            this.ajouterBtm.Location = new System.Drawing.Point(22, 219);
            this.ajouterBtm.Name = "ajouterBtm";
            this.ajouterBtm.Size = new System.Drawing.Size(112, 33);
            this.ajouterBtm.TabIndex = 6;
            this.ajouterBtm.Text = "Ajouter";
            this.ajouterBtm.UseVisualStyleBackColor = true;
            this.ajouterBtm.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(769, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "Chercher";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // listeResvBtm
            // 
            this.listeResvBtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeResvBtm.ForeColor = System.Drawing.Color.Navy;
            this.listeResvBtm.Location = new System.Drawing.Point(62, 268);
            this.listeResvBtm.Name = "listeResvBtm";
            this.listeResvBtm.Size = new System.Drawing.Size(252, 33);
            this.listeResvBtm.TabIndex = 7;
            this.listeResvBtm.Text = "Liste des reservations ";
            this.listeResvBtm.UseVisualStyleBackColor = true;
            this.listeResvBtm.Click += new System.EventHandler(this.listeResvBtm_Click);
            // 
            // teleClt
            // 
            this.teleClt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teleClt.Location = new System.Drawing.Point(108, 164);
            this.teleClt.Name = "teleClt";
            this.teleClt.Size = new System.Drawing.Size(218, 30);
            this.teleClt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(21, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mobile";
            // 
            // modifierBtm
            // 
            this.modifierBtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierBtm.ForeColor = System.Drawing.Color.Navy;
            this.modifierBtm.Location = new System.Drawing.Point(150, 217);
            this.modifierBtm.Name = "modifierBtm";
            this.modifierBtm.Size = new System.Drawing.Size(112, 33);
            this.modifierBtm.TabIndex = 10;
            this.modifierBtm.Text = "Modifier";
            this.modifierBtm.UseVisualStyleBackColor = true;
            this.modifierBtm.Click += new System.EventHandler(this.modifierBtm_Click);
            // 
            // idclientsDataGridViewTextBoxColumn
            // 
            this.idclientsDataGridViewTextBoxColumn.DataPropertyName = "id_clients";
            this.idclientsDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.idclientsDataGridViewTextBoxColumn.Name = "idclientsDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // cinDataGridViewTextBoxColumn
            // 
            this.cinDataGridViewTextBoxColumn.DataPropertyName = "cin";
            this.cinDataGridViewTextBoxColumn.HeaderText = "Cin";
            this.cinDataGridViewTextBoxColumn.Name = "cinDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(PFE.Entities.Clients);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1022, 705);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ListeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1130, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ListeClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ListeClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridClt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cinCltText;
        private System.Windows.Forms.TextBox nomCltTxt;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridRes;
        private System.Windows.Forms.Button ajouterBtm;
        private System.Windows.Forms.Button chercherBtm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button listeResvBtm;
        private System.Windows.Forms.TextBox teleClt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button modifierBtm;
        private System.Windows.Forms.Button button1;
    }
}