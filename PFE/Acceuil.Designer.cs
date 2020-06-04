namespace PFE
{
    partial class Acceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceuil));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesRéservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.immeubilierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauImmobilierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterImmeubilierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateurToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.reservationToolStripMenuItem,
            this.immeubilierToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1093, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesRéservationsToolStripMenuItem});
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.reservationToolStripMenuItem.Text = "Reservation";
            this.reservationToolStripMenuItem.Click += new System.EventHandler(this.reservationToolStripMenuItem_Click_1);
            // 
            // listeDesRéservationsToolStripMenuItem
            // 
            this.listeDesRéservationsToolStripMenuItem.Name = "listeDesRéservationsToolStripMenuItem";
            this.listeDesRéservationsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listeDesRéservationsToolStripMenuItem.Text = "Liste des réservations";
            this.listeDesRéservationsToolStripMenuItem.Click += new System.EventHandler(this.listeDesRéservationsToolStripMenuItem_Click);
            // 
            // immeubilierToolStripMenuItem
            // 
            this.immeubilierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauImmobilierToolStripMenuItem,
            this.ajouterImmeubilierToolStripMenuItem});
            this.immeubilierToolStripMenuItem.Name = "immeubilierToolStripMenuItem";
            this.immeubilierToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.immeubilierToolStripMenuItem.Text = "Immeubilier";
            // 
            // nouveauImmobilierToolStripMenuItem
            // 
            this.nouveauImmobilierToolStripMenuItem.Name = "nouveauImmobilierToolStripMenuItem";
            this.nouveauImmobilierToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.nouveauImmobilierToolStripMenuItem.Text = "Nouveau immobilier";
            this.nouveauImmobilierToolStripMenuItem.Click += new System.EventHandler(this.nouveauImmobilierToolStripMenuItem_Click);
            // 
            // ajouterImmeubilierToolStripMenuItem
            // 
            this.ajouterImmeubilierToolStripMenuItem.Name = "ajouterImmeubilierToolStripMenuItem";
            this.ajouterImmeubilierToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.ajouterImmeubilierToolStripMenuItem.Text = "Liste des immeubiliers";
            this.ajouterImmeubilierToolStripMenuItem.Click += new System.EventHandler(this.ajouterImmeubilierToolStripMenuItem_Click);
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUtilisateurToolStripMenuItem,
            this.listeUtilisateursToolStripMenuItem,
            this.profilToolStripMenuItem});
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.utilisateurToolStripMenuItem.Text = "Utilisateur";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click);
            // 
            // ajouterUtilisateurToolStripMenuItem
            // 
            this.ajouterUtilisateurToolStripMenuItem.Name = "ajouterUtilisateurToolStripMenuItem";
            this.ajouterUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ajouterUtilisateurToolStripMenuItem.Text = "Ajouter Utilisateur";
            this.ajouterUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUtilisateurToolStripMenuItem_Click);
            // 
            // listeUtilisateursToolStripMenuItem
            // 
            this.listeUtilisateursToolStripMenuItem.Name = "listeUtilisateursToolStripMenuItem";
            this.listeUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.listeUtilisateursToolStripMenuItem.Text = "Liste Utilisateurs";
            this.listeUtilisateursToolStripMenuItem.Click += new System.EventHandler(this.listeUtilisateursToolStripMenuItem_Click);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.profilToolStripMenuItem.Text = "Profil";
            this.profilToolStripMenuItem.Click += new System.EventHandler(this.profilToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.fileToolStripMenuItem.Text = "Quitter";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeClientToolStripMenuItem,
            this.nouveauClientToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // listeClientToolStripMenuItem
            // 
            this.listeClientToolStripMenuItem.Name = "listeClientToolStripMenuItem";
            this.listeClientToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.listeClientToolStripMenuItem.Text = "Liste Client";
            this.listeClientToolStripMenuItem.Click += new System.EventHandler(this.listeClientToolStripMenuItem_Click);
            // 
            // nouveauClientToolStripMenuItem
            // 
            this.nouveauClientToolStripMenuItem.Name = "nouveauClientToolStripMenuItem";
            this.nouveauClientToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.nouveauClientToolStripMenuItem.Text = "Nouveau client";
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1093, 550);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Acceuil";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem immeubilierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterImmeubilierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesRéservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauImmobilierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauClientToolStripMenuItem;
    }
}

