namespace SLAM2_HENRI_TP3_Application_CentreLoisirs
{
    partial class FormListeActivites
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
            this.lstBoxActivite = new System.Windows.Forms.ListBox();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxActivite
            // 
            this.lstBoxActivite.FormattingEnabled = true;
            this.lstBoxActivite.Location = new System.Drawing.Point(97, 54);
            this.lstBoxActivite.Name = "lstBoxActivite";
            this.lstBoxActivite.Size = new System.Drawing.Size(497, 238);
            this.lstBoxActivite.TabIndex = 0;
            this.lstBoxActivite.SelectedIndexChanged += new System.EventHandler(this.lstBoxActivite_SelectedIndexChanged);
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(304, 344);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_fermer.TabIndex = 1;
            this.btn_fermer.Text = "FERMER";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormListeActivites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 443);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.lstBoxActivite);
            this.Name = "FormListeActivites";
            this.Text = "Listes des Activités";
            this.Load += new System.EventHandler(this.FormListeActivites_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxActivite;
        private System.Windows.Forms.Button btn_fermer;
    }
}