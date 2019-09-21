namespace SLAM2_HENRI_TP3_Application_CentreLoisirs
{
    partial class FormInscriptionActivite
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
            this.lbl_act = new System.Windows.Forms.Label();
            this.lbl_enfant = new System.Windows.Forms.Label();
            this.cb_act = new System.Windows.Forms.ComboBox();
            this.cb_enfant = new System.Windows.Forms.ComboBox();
            this.btn_inscription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_act
            // 
            this.lbl_act.AutoSize = true;
            this.lbl_act.Location = new System.Drawing.Point(24, 115);
            this.lbl_act.Name = "lbl_act";
            this.lbl_act.Size = new System.Drawing.Size(99, 13);
            this.lbl_act.TabIndex = 0;
            this.lbl_act.Text = "Choix de l\'Activite : ";
            // 
            // lbl_enfant
            // 
            this.lbl_enfant.AutoSize = true;
            this.lbl_enfant.Location = new System.Drawing.Point(510, 115);
            this.lbl_enfant.Name = "lbl_enfant";
            this.lbl_enfant.Size = new System.Drawing.Size(95, 13);
            this.lbl_enfant.TabIndex = 1;
            this.lbl_enfant.Text = "Choix de l\'Enfant : ";
            // 
            // cb_act
            // 
            this.cb_act.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_act.FormattingEnabled = true;
            this.cb_act.Location = new System.Drawing.Point(27, 162);
            this.cb_act.MaxDropDownItems = 10;
            this.cb_act.Name = "cb_act";
            this.cb_act.Size = new System.Drawing.Size(319, 21);
            this.cb_act.TabIndex = 2;
            this.cb_act.SelectedIndexChanged += new System.EventHandler(this.cb_act_SelectedIndexChanged);
            // 
            // cb_enfant
            // 
            this.cb_enfant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_enfant.FormattingEnabled = true;
            this.cb_enfant.Location = new System.Drawing.Point(513, 162);
            this.cb_enfant.MaxDropDownItems = 50;
            this.cb_enfant.Name = "cb_enfant";
            this.cb_enfant.Size = new System.Drawing.Size(275, 21);
            this.cb_enfant.TabIndex = 3;
            // 
            // btn_inscription
            // 
            this.btn_inscription.Location = new System.Drawing.Point(389, 160);
            this.btn_inscription.Name = "btn_inscription";
            this.btn_inscription.Size = new System.Drawing.Size(75, 23);
            this.btn_inscription.TabIndex = 4;
            this.btn_inscription.Text = "INSCRIRE";
            this.btn_inscription.UseVisualStyleBackColor = true;
            this.btn_inscription.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormInscriptionActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 270);
            this.Controls.Add(this.btn_inscription);
            this.Controls.Add(this.cb_enfant);
            this.Controls.Add(this.cb_act);
            this.Controls.Add(this.lbl_enfant);
            this.Controls.Add(this.lbl_act);
            this.Name = "FormInscriptionActivite";
            this.Text = "FormInscriptionActivite";
            this.Load += new System.EventHandler(this.FormInscriptionActivite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_act;
        private System.Windows.Forms.Label lbl_enfant;
        private System.Windows.Forms.ComboBox cb_act;
        private System.Windows.Forms.ComboBox cb_enfant;
        private System.Windows.Forms.Button btn_inscription;
    }
}