namespace SLAM2_TP5_EpisodesSaisonsSeries
{
    partial class FormEpisode
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
            System.Windows.Forms.Label lbl_list;
            this.DG_Episodes = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            lbl_list = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Episodes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_list
            // 
            lbl_list.AutoSize = true;
            lbl_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_list.Location = new System.Drawing.Point(50, 35);
            lbl_list.Name = "lbl_list";
            lbl_list.Size = new System.Drawing.Size(260, 31);
            lbl_list.TabIndex = 0;
            lbl_list.Text = "Liste des Épisodes";
            // 
            // DG_Episodes
            // 
            this.DG_Episodes.AllowUserToDeleteRows = false;
            this.DG_Episodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Episodes.Location = new System.Drawing.Point(56, 94);
            this.DG_Episodes.Name = "DG_Episodes";
            this.DG_Episodes.ReadOnly = true;
            this.DG_Episodes.Size = new System.Drawing.Size(610, 263);
            this.DG_Episodes.TabIndex = 1;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(493, 42);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click_1);
            // 
            // FormEpisode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 395);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.DG_Episodes);
            this.Controls.Add(lbl_list);
            this.Name = "FormEpisode";
            this.Text = "Gestion des Épisodes";
            this.Load += new System.EventHandler(this.FormEpisode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Episodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Episodes;
        private System.Windows.Forms.Button Delete;
    }
}