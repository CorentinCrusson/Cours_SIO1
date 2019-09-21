namespace SLAM2_HENRI_TP3_Application_CentreLoisirs
{
    partial class FormAccueil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesActivitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDuneActivitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesActivitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationSuppressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesInscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDunEnfantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionÀUneActivitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesActivitésToolStripMenuItem,
            this.gestionDesInscriptionsToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesActivitésToolStripMenuItem
            // 
            this.gestionDesActivitésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDuneActivitéToolStripMenuItem,
            this.listeDesActivitésToolStripMenuItem,
            this.modificationSuppressionToolStripMenuItem});
            this.gestionDesActivitésToolStripMenuItem.Name = "gestionDesActivitésToolStripMenuItem";
            this.gestionDesActivitésToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.gestionDesActivitésToolStripMenuItem.Text = "Gestion des Activités";
            this.gestionDesActivitésToolStripMenuItem.Click += new System.EventHandler(this.gestionDesActivitésToolStripMenuItem_Click);
            // 
            // ajoutDuneActivitéToolStripMenuItem
            // 
            this.ajoutDuneActivitéToolStripMenuItem.Name = "ajoutDuneActivitéToolStripMenuItem";
            this.ajoutDuneActivitéToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.ajoutDuneActivitéToolStripMenuItem.Text = "Ajout d\'une activité";
            this.ajoutDuneActivitéToolStripMenuItem.Click += new System.EventHandler(this.ajoutDuneActivitéToolStripMenuItem_Click);
            // 
            // listeDesActivitésToolStripMenuItem
            // 
            this.listeDesActivitésToolStripMenuItem.Name = "listeDesActivitésToolStripMenuItem";
            this.listeDesActivitésToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.listeDesActivitésToolStripMenuItem.Text = "Liste des Activités";
            this.listeDesActivitésToolStripMenuItem.Click += new System.EventHandler(this.listeDesActivitésToolStripMenuItem_Click);
            // 
            // modificationSuppressionToolStripMenuItem
            // 
            this.modificationSuppressionToolStripMenuItem.Name = "modificationSuppressionToolStripMenuItem";
            this.modificationSuppressionToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.modificationSuppressionToolStripMenuItem.Text = "Modification/Suppression";
            this.modificationSuppressionToolStripMenuItem.Click += new System.EventHandler(this.modificationSuppressionToolStripMenuItem_Click);
            // 
            // gestionDesInscriptionsToolStripMenuItem
            // 
            this.gestionDesInscriptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDunEnfantToolStripMenuItem,
            this.inscriptionÀUneActivitéToolStripMenuItem});
            this.gestionDesInscriptionsToolStripMenuItem.Name = "gestionDesInscriptionsToolStripMenuItem";
            this.gestionDesInscriptionsToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.gestionDesInscriptionsToolStripMenuItem.Text = "Gestion des Inscriptions";
            // 
            // ajoutDunEnfantToolStripMenuItem
            // 
            this.ajoutDunEnfantToolStripMenuItem.Name = "ajoutDunEnfantToolStripMenuItem";
            this.ajoutDunEnfantToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.ajoutDunEnfantToolStripMenuItem.Text = "Ajout d\'un enfant";
            this.ajoutDunEnfantToolStripMenuItem.Click += new System.EventHandler(this.ajoutDunEnfantToolStripMenuItem_Click);
            // 
            // inscriptionÀUneActivitéToolStripMenuItem
            // 
            this.inscriptionÀUneActivitéToolStripMenuItem.Name = "inscriptionÀUneActivitéToolStripMenuItem";
            this.inscriptionÀUneActivitéToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.inscriptionÀUneActivitéToolStripMenuItem.Text = "Inscription à une activité";
            this.inscriptionÀUneActivitéToolStripMenuItem.Click += new System.EventHandler(this.inscriptionÀUneActivitéToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAccueil";
            this.Text = "Application Centre de Loisirs";
            this.Load += new System.EventHandler(this.FormAccueil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesActivitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDuneActivitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesActivitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationSuppressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesInscriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDunEnfantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionÀUneActivitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

