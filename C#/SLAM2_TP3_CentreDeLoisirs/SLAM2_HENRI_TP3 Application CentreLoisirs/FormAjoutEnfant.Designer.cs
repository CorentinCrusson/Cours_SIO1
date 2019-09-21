namespace SLAM2_HENRI_TP3_Application_CentreLoisirs
{
    partial class FormAjoutEnfant
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
            this.lbl_numE = new System.Windows.Forms.Label();
            this.lbl_prenomE = new System.Windows.Forms.Label();
            this.lbl_nomE = new System.Windows.Forms.Label();
            this.txtBox_numE = new System.Windows.Forms.TextBox();
            this.txtBox_nomE = new System.Windows.Forms.TextBox();
            this.txtBox_prenomE = new System.Windows.Forms.TextBox();
            this.radioBtn_t4 = new System.Windows.Forms.RadioButton();
            this.radioBtn_t3 = new System.Windows.Forms.RadioButton();
            this.radioBtn_t2 = new System.Windows.Forms.RadioButton();
            this.radioBtn_t1 = new System.Windows.Forms.RadioButton();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.grpBox_trancheAge = new System.Windows.Forms.GroupBox();
            this.grpBox_trancheAge.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_numE
            // 
            this.lbl_numE.AutoSize = true;
            this.lbl_numE.Location = new System.Drawing.Point(75, 64);
            this.lbl_numE.Name = "lbl_numE";
            this.lbl_numE.Size = new System.Drawing.Size(106, 13);
            this.lbl_numE.TabIndex = 0;
            this.lbl_numE.Text = "Numéro de l\'Enfant : ";
            // 
            // lbl_prenomE
            // 
            this.lbl_prenomE.AutoSize = true;
            this.lbl_prenomE.Location = new System.Drawing.Point(76, 190);
            this.lbl_prenomE.Name = "lbl_prenomE";
            this.lbl_prenomE.Size = new System.Drawing.Size(105, 13);
            this.lbl_prenomE.TabIndex = 1;
            this.lbl_prenomE.Text = "Prénom de l\'Enfant : ";
            // 
            // lbl_nomE
            // 
            this.lbl_nomE.AutoSize = true;
            this.lbl_nomE.Location = new System.Drawing.Point(76, 120);
            this.lbl_nomE.Name = "lbl_nomE";
            this.lbl_nomE.Size = new System.Drawing.Size(91, 13);
            this.lbl_nomE.TabIndex = 3;
            this.lbl_nomE.Text = "Nom de l\'Enfant : ";
            // 
            // txtBox_numE
            // 
            this.txtBox_numE.Location = new System.Drawing.Point(186, 61);
            this.txtBox_numE.Name = "txtBox_numE";
            this.txtBox_numE.ReadOnly = true;
            this.txtBox_numE.Size = new System.Drawing.Size(100, 20);
            this.txtBox_numE.TabIndex = 4;
            // 
            // txtBox_nomE
            // 
            this.txtBox_nomE.Location = new System.Drawing.Point(186, 117);
            this.txtBox_nomE.Name = "txtBox_nomE";
            this.txtBox_nomE.Size = new System.Drawing.Size(100, 20);
            this.txtBox_nomE.TabIndex = 5;
            // 
            // txtBox_prenomE
            // 
            this.txtBox_prenomE.Location = new System.Drawing.Point(186, 187);
            this.txtBox_prenomE.Name = "txtBox_prenomE";
            this.txtBox_prenomE.Size = new System.Drawing.Size(100, 20);
            this.txtBox_prenomE.TabIndex = 6;
            // 
            // radioBtn_t4
            // 
            this.radioBtn_t4.AutoSize = true;
            this.radioBtn_t4.Location = new System.Drawing.Point(232, 17);
            this.radioBtn_t4.Name = "radioBtn_t4";
            this.radioBtn_t4.Size = new System.Drawing.Size(63, 17);
            this.radioBtn_t4.TabIndex = 12;
            this.radioBtn_t4.Text = "+15 ans";
            this.radioBtn_t4.UseVisualStyleBackColor = true;
            // 
            // radioBtn_t3
            // 
            this.radioBtn_t3.AutoSize = true;
            this.radioBtn_t3.Location = new System.Drawing.Point(154, 17);
            this.radioBtn_t3.Name = "radioBtn_t3";
            this.radioBtn_t3.Size = new System.Drawing.Size(72, 17);
            this.radioBtn_t3.TabIndex = 11;
            this.radioBtn_t3.Text = "12-15 ans";
            this.radioBtn_t3.UseVisualStyleBackColor = true;
            // 
            // radioBtn_t2
            // 
            this.radioBtn_t2.AutoSize = true;
            this.radioBtn_t2.Location = new System.Drawing.Point(81, 17);
            this.radioBtn_t2.Name = "radioBtn_t2";
            this.radioBtn_t2.Size = new System.Drawing.Size(66, 17);
            this.radioBtn_t2.TabIndex = 10;
            this.radioBtn_t2.Text = "7-11 ans";
            this.radioBtn_t2.UseVisualStyleBackColor = true;
            // 
            // radioBtn_t1
            // 
            this.radioBtn_t1.AutoSize = true;
            this.radioBtn_t1.Checked = true;
            this.radioBtn_t1.Location = new System.Drawing.Point(15, 17);
            this.radioBtn_t1.Name = "radioBtn_t1";
            this.radioBtn_t1.Size = new System.Drawing.Size(60, 17);
            this.radioBtn_t1.TabIndex = 9;
            this.radioBtn_t1.TabStop = true;
            this.radioBtn_t1.Text = "3-6 ans";
            this.radioBtn_t1.UseVisualStyleBackColor = true;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(79, 372);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 13;
            this.btn_ajouter.Text = "AJOUTER";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(278, 372);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 14;
            this.btn_annuler.Text = "ANNULER";
            this.btn_annuler.UseVisualStyleBackColor = true;
            // 
            // grpBox_trancheAge
            // 
            this.grpBox_trancheAge.Controls.Add(this.radioBtn_t1);
            this.grpBox_trancheAge.Controls.Add(this.radioBtn_t2);
            this.grpBox_trancheAge.Controls.Add(this.radioBtn_t3);
            this.grpBox_trancheAge.Controls.Add(this.radioBtn_t4);
            this.grpBox_trancheAge.Location = new System.Drawing.Point(78, 249);
            this.grpBox_trancheAge.Name = "grpBox_trancheAge";
            this.grpBox_trancheAge.Size = new System.Drawing.Size(318, 42);
            this.grpBox_trancheAge.TabIndex = 15;
            this.grpBox_trancheAge.TabStop = false;
            this.grpBox_trancheAge.Text = "Tranche d\'Âge";
            // 
            // FormAjoutEnfant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBox_trancheAge);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.txtBox_prenomE);
            this.Controls.Add(this.txtBox_nomE);
            this.Controls.Add(this.txtBox_numE);
            this.Controls.Add(this.lbl_nomE);
            this.Controls.Add(this.lbl_prenomE);
            this.Controls.Add(this.lbl_numE);
            this.Name = "FormAjoutEnfant";
            this.Text = "FormAjoutEnfant";
            this.grpBox_trancheAge.ResumeLayout(false);
            this.grpBox_trancheAge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_numE;
        private System.Windows.Forms.Label lbl_prenomE;
        private System.Windows.Forms.Label lbl_nomE;
        private System.Windows.Forms.TextBox txtBox_numE;
        private System.Windows.Forms.TextBox txtBox_nomE;
        private System.Windows.Forms.TextBox txtBox_prenomE;
        private System.Windows.Forms.RadioButton radioBtn_t4;
        private System.Windows.Forms.RadioButton radioBtn_t3;
        private System.Windows.Forms.RadioButton radioBtn_t2;
        private System.Windows.Forms.RadioButton radioBtn_t1;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.GroupBox grpBox_trancheAge;
    }
}