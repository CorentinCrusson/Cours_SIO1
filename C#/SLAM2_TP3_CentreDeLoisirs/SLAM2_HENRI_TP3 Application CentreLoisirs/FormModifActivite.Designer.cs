namespace SLAM2_HENRI_TP3_Application_CentreLoisirs
{
    partial class FormModifActivite
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
            this.cb_Activite = new System.Windows.Forms.ComboBox();
            this.grpBoxChoix = new System.Windows.Forms.GroupBox();
            this.btnSupprAct = new System.Windows.Forms.RadioButton();
            this.btnModifAct = new System.Windows.Forms.RadioButton();
            this.grpBoxInfos = new System.Windows.Forms.GroupBox();
            this.btn_Enregistrer = new System.Windows.Forms.Button();
            this.lbl_participantsMax = new System.Windows.Forms.Label();
            this.txtBoxNbMax = new System.Windows.Forms.TextBox();
            this.dateBoxAct = new System.Windows.Forms.DateTimePicker();
            this.lbl_numAct = new System.Windows.Forms.Label();
            this.txtBoxNum = new System.Windows.Forms.TextBox();
            this.txtBoxLibelle = new System.Windows.Forms.TextBox();
            this.grpBoxChoix.SuspendLayout();
            this.grpBoxInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Activite
            // 
            this.cb_Activite.AllowDrop = true;
            this.cb_Activite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Activite.FormattingEnabled = true;
            this.cb_Activite.Location = new System.Drawing.Point(120, 51);
            this.cb_Activite.Name = "cb_Activite";
            this.cb_Activite.Size = new System.Drawing.Size(524, 21);
            this.cb_Activite.TabIndex = 0;
            this.cb_Activite.SelectedIndexChanged += new System.EventHandler(this.cb_Activite_SelectedIndexChanged);
            // 
            // grpBoxChoix
            // 
            this.grpBoxChoix.Controls.Add(this.btnSupprAct);
            this.grpBoxChoix.Controls.Add(this.btnModifAct);
            this.grpBoxChoix.Location = new System.Drawing.Point(120, 109);
            this.grpBoxChoix.Name = "grpBoxChoix";
            this.grpBoxChoix.Size = new System.Drawing.Size(524, 76);
            this.grpBoxChoix.TabIndex = 1;
            this.grpBoxChoix.TabStop = false;
            this.grpBoxChoix.Text = "Choix";
            // 
            // btnSupprAct
            // 
            this.btnSupprAct.AutoSize = true;
            this.btnSupprAct.Location = new System.Drawing.Point(341, 46);
            this.btnSupprAct.Name = "btnSupprAct";
            this.btnSupprAct.Size = new System.Drawing.Size(72, 17);
            this.btnSupprAct.TabIndex = 1;
            this.btnSupprAct.Text = "Supprimer";
            this.btnSupprAct.UseVisualStyleBackColor = true;
            this.btnSupprAct.CheckedChanged += new System.EventHandler(this.btnSupprAct_CheckedChanged);
            // 
            // btnModifAct
            // 
            this.btnModifAct.AutoSize = true;
            this.btnModifAct.Checked = true;
            this.btnModifAct.Location = new System.Drawing.Point(78, 46);
            this.btnModifAct.Name = "btnModifAct";
            this.btnModifAct.Size = new System.Drawing.Size(62, 17);
            this.btnModifAct.TabIndex = 0;
            this.btnModifAct.TabStop = true;
            this.btnModifAct.Text = "Modifier";
            this.btnModifAct.UseVisualStyleBackColor = true;
            this.btnModifAct.CheckedChanged += new System.EventHandler(this.btnModifAct_CheckedChanged);
            // 
            // grpBoxInfos
            // 
            this.grpBoxInfos.Controls.Add(this.btn_Enregistrer);
            this.grpBoxInfos.Controls.Add(this.lbl_participantsMax);
            this.grpBoxInfos.Controls.Add(this.txtBoxNbMax);
            this.grpBoxInfos.Controls.Add(this.dateBoxAct);
            this.grpBoxInfos.Controls.Add(this.lbl_numAct);
            this.grpBoxInfos.Controls.Add(this.txtBoxNum);
            this.grpBoxInfos.Controls.Add(this.txtBoxLibelle);
            this.grpBoxInfos.Location = new System.Drawing.Point(120, 232);
            this.grpBoxInfos.Name = "grpBoxInfos";
            this.grpBoxInfos.Size = new System.Drawing.Size(524, 206);
            this.grpBoxInfos.TabIndex = 2;
            this.grpBoxInfos.TabStop = false;
            this.grpBoxInfos.Text = "Informations de l\'Activité";
            // 
            // btn_Enregistrer
            // 
            this.btn_Enregistrer.Location = new System.Drawing.Point(341, 141);
            this.btn_Enregistrer.Name = "btn_Enregistrer";
            this.btn_Enregistrer.Size = new System.Drawing.Size(142, 47);
            this.btn_Enregistrer.TabIndex = 6;
            this.btn_Enregistrer.Text = "Enregistrez les Modifications";
            this.btn_Enregistrer.UseVisualStyleBackColor = true;
            this.btn_Enregistrer.Click += new System.EventHandler(this.btn_Enregistrer_Click);
            // 
            // lbl_participantsMax
            // 
            this.lbl_participantsMax.AutoSize = true;
            this.lbl_participantsMax.Location = new System.Drawing.Point(126, 156);
            this.lbl_participantsMax.Name = "lbl_participantsMax";
            this.lbl_participantsMax.Size = new System.Drawing.Size(83, 13);
            this.lbl_participantsMax.TabIndex = 5;
            this.lbl_participantsMax.Text = "participants max";
            // 
            // txtBoxNbMax
            // 
            this.txtBoxNbMax.Location = new System.Drawing.Point(40, 153);
            this.txtBoxNbMax.Name = "txtBoxNbMax";
            this.txtBoxNbMax.Size = new System.Drawing.Size(64, 20);
            this.txtBoxNbMax.TabIndex = 4;
            // 
            // dateBoxAct
            // 
            this.dateBoxAct.Location = new System.Drawing.Point(40, 102);
            this.dateBoxAct.Name = "dateBoxAct";
            this.dateBoxAct.Size = new System.Drawing.Size(200, 20);
            this.dateBoxAct.TabIndex = 3;
            // 
            // lbl_numAct
            // 
            this.lbl_numAct.AutoSize = true;
            this.lbl_numAct.Location = new System.Drawing.Point(242, 52);
            this.lbl_numAct.Name = "lbl_numAct";
            this.lbl_numAct.Size = new System.Drawing.Size(110, 13);
            this.lbl_numAct.TabIndex = 2;
            this.lbl_numAct.Text = "Numéro de l\'Activité : ";
            // 
            // txtBoxNum
            // 
            this.txtBoxNum.Location = new System.Drawing.Point(358, 49);
            this.txtBoxNum.Name = "txtBoxNum";
            this.txtBoxNum.ReadOnly = true;
            this.txtBoxNum.Size = new System.Drawing.Size(125, 20);
            this.txtBoxNum.TabIndex = 1;
            // 
            // txtBoxLibelle
            // 
            this.txtBoxLibelle.Location = new System.Drawing.Point(40, 49);
            this.txtBoxLibelle.Name = "txtBoxLibelle";
            this.txtBoxLibelle.Size = new System.Drawing.Size(178, 20);
            this.txtBoxLibelle.TabIndex = 0;
            // 
            // FormModifActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxInfos);
            this.Controls.Add(this.grpBoxChoix);
            this.Controls.Add(this.cb_Activite);
            this.Name = "FormModifActivite";
            this.Text = "Modification/Suppresion des Activités";
            this.Load += new System.EventHandler(this.FormModifActivite_Load);
            this.grpBoxChoix.ResumeLayout(false);
            this.grpBoxChoix.PerformLayout();
            this.grpBoxInfos.ResumeLayout(false);
            this.grpBoxInfos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Activite;
        private System.Windows.Forms.GroupBox grpBoxChoix;
        private System.Windows.Forms.RadioButton btnSupprAct;
        private System.Windows.Forms.RadioButton btnModifAct;
        private System.Windows.Forms.GroupBox grpBoxInfos;
        private System.Windows.Forms.Button btn_Enregistrer;
        private System.Windows.Forms.Label lbl_participantsMax;
        private System.Windows.Forms.TextBox txtBoxNbMax;
        private System.Windows.Forms.DateTimePicker dateBoxAct;
        private System.Windows.Forms.Label lbl_numAct;
        private System.Windows.Forms.TextBox txtBoxNum;
        private System.Windows.Forms.TextBox txtBoxLibelle;
    }
}