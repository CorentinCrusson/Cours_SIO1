namespace SLAM2_HENRI_TP3_Application_CentreLoisirs
{
    partial class FormAjoutActivite
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
            this.lbl_numAct = new System.Windows.Forms.Label();
            this.textBox_numAct = new System.Windows.Forms.TextBox();
            this.lbl_libelleAct = new System.Windows.Forms.Label();
            this.textBox_lblAct = new System.Windows.Forms.TextBox();
            this.lbl_trancheAge = new System.Windows.Forms.Label();
            this.radioBtn_t1 = new System.Windows.Forms.RadioButton();
            this.radioBtn_t2 = new System.Windows.Forms.RadioButton();
            this.radioBtn_t3 = new System.Windows.Forms.RadioButton();
            this.radioBtn_t4 = new System.Windows.Forms.RadioButton();
            this.lbl_anim = new System.Windows.Forms.Label();
            this.lbl_dateAct = new System.Windows.Forms.Label();
            this.lbl_nbMaxPartic = new System.Windows.Forms.Label();
            this.datePicker_dateAct = new System.Windows.Forms.DateTimePicker();
            this.numUpDown_nbMax = new System.Windows.Forms.NumericUpDown();
            this.comboBox_anim = new System.Windows.Forms.ComboBox();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_nbMax)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_numAct
            // 
            this.lbl_numAct.AutoSize = true;
            this.lbl_numAct.Location = new System.Drawing.Point(45, 40);
            this.lbl_numAct.Name = "lbl_numAct";
            this.lbl_numAct.Size = new System.Drawing.Size(106, 13);
            this.lbl_numAct.TabIndex = 0;
            this.lbl_numAct.Text = "Numéro de l\'activité :";
            //this.lbl_numAct.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_numAct
            // 
            this.textBox_numAct.Location = new System.Drawing.Point(157, 37);
            this.textBox_numAct.Name = "textBox_numAct";
            this.textBox_numAct.ReadOnly = true;
            this.textBox_numAct.Size = new System.Drawing.Size(60, 20);
            this.textBox_numAct.TabIndex = 1;
            // 
            // lbl_libelleAct
            // 
            this.lbl_libelleAct.AutoSize = true;
            this.lbl_libelleAct.Location = new System.Drawing.Point(45, 76);
            this.lbl_libelleAct.Name = "lbl_libelleAct";
            this.lbl_libelleAct.Size = new System.Drawing.Size(99, 13);
            this.lbl_libelleAct.TabIndex = 2;
            this.lbl_libelleAct.Text = "Libellé de l\'activité :";
            //this.lbl_libelleAct.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox_lblAct
            // 
            this.textBox_lblAct.Location = new System.Drawing.Point(157, 73);
            this.textBox_lblAct.Name = "textBox_lblAct";
            this.textBox_lblAct.Size = new System.Drawing.Size(108, 20);
            this.textBox_lblAct.TabIndex = 3;
            // 
            // lbl_trancheAge
            // 
            this.lbl_trancheAge.AutoSize = true;
            this.lbl_trancheAge.Location = new System.Drawing.Point(45, 113);
            this.lbl_trancheAge.Name = "lbl_trancheAge";
            this.lbl_trancheAge.Size = new System.Drawing.Size(87, 13);
            this.lbl_trancheAge.TabIndex = 4;
            this.lbl_trancheAge.Text = "Tranche d\'âges :";
            // 
            // radioBtn_t1
            // 
            this.radioBtn_t1.AutoSize = true;
            this.radioBtn_t1.Location = new System.Drawing.Point(157, 111);
            this.radioBtn_t1.Name = "radioBtn_t1";
            this.radioBtn_t1.Size = new System.Drawing.Size(60, 17);
            this.radioBtn_t1.TabIndex = 5;
            this.radioBtn_t1.TabStop = true;
            this.radioBtn_t1.Text = "3-6 ans";
            this.radioBtn_t1.UseVisualStyleBackColor = true;
            // 
            // radioBtn_t2
            // 
            this.radioBtn_t2.AutoSize = true;
            this.radioBtn_t2.Location = new System.Drawing.Point(248, 111);
            this.radioBtn_t2.Name = "radioBtn_t2";
            this.radioBtn_t2.Size = new System.Drawing.Size(66, 17);
            this.radioBtn_t2.TabIndex = 6;
            this.radioBtn_t2.TabStop = true;
            this.radioBtn_t2.Text = "7-11 ans";
            this.radioBtn_t2.UseVisualStyleBackColor = true;
            //this.radioBtn_t2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioBtn_t3
            // 
            this.radioBtn_t3.AutoSize = true;
            this.radioBtn_t3.Location = new System.Drawing.Point(339, 111);
            this.radioBtn_t3.Name = "radioBtn_t3";
            this.radioBtn_t3.Size = new System.Drawing.Size(72, 17);
            this.radioBtn_t3.TabIndex = 7;
            this.radioBtn_t3.TabStop = true;
            this.radioBtn_t3.Text = "12-15 ans";
            this.radioBtn_t3.UseVisualStyleBackColor = true;
            // 
            // radioBtn_t4
            // 
            this.radioBtn_t4.AutoSize = true;
            this.radioBtn_t4.Location = new System.Drawing.Point(430, 111);
            this.radioBtn_t4.Name = "radioBtn_t4";
            this.radioBtn_t4.Size = new System.Drawing.Size(63, 17);
            this.radioBtn_t4.TabIndex = 8;
            this.radioBtn_t4.TabStop = true;
            this.radioBtn_t4.Text = "+15 ans";
            this.radioBtn_t4.UseVisualStyleBackColor = true;
            // 
            // lbl_anim
            // 
            this.lbl_anim.AutoSize = true;
            this.lbl_anim.Location = new System.Drawing.Point(45, 164);
            this.lbl_anim.Name = "lbl_anim";
            this.lbl_anim.Size = new System.Drawing.Size(116, 13);
            this.lbl_anim.TabIndex = 9;
            this.lbl_anim.Text = "Animateur de l\'activité :";
            //this.lbl_anim.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lbl_dateAct
            // 
            this.lbl_dateAct.AutoSize = true;
            this.lbl_dateAct.Location = new System.Drawing.Point(45, 218);
            this.lbl_dateAct.Name = "lbl_dateAct";
            this.lbl_dateAct.Size = new System.Drawing.Size(92, 13);
            this.lbl_dateAct.TabIndex = 11;
            this.lbl_dateAct.Text = "Date de l\'activité :";
            // 
            // lbl_nbMaxPartic
            // 
            this.lbl_nbMaxPartic.AutoSize = true;
            this.lbl_nbMaxPartic.Location = new System.Drawing.Point(40, 265);
            this.lbl_nbMaxPartic.Name = "lbl_nbMaxPartic";
            this.lbl_nbMaxPartic.Size = new System.Drawing.Size(122, 13);
            this.lbl_nbMaxPartic.TabIndex = 12;
            this.lbl_nbMaxPartic.Text = "Nb Max de participants :";
            // 
            // datePicker_dateAct
            // 
            this.datePicker_dateAct.Location = new System.Drawing.Point(157, 218);
            this.datePicker_dateAct.Name = "datePicker_dateAct";
            this.datePicker_dateAct.Size = new System.Drawing.Size(200, 20);
            this.datePicker_dateAct.TabIndex = 13;
            // 
            // numUpDown_nbMax
            // 
            this.numUpDown_nbMax.Location = new System.Drawing.Point(168, 265);
            this.numUpDown_nbMax.Name = "numUpDown_nbMax";
            this.numUpDown_nbMax.Size = new System.Drawing.Size(49, 20);
            this.numUpDown_nbMax.TabIndex = 15;
            // 
            // comboBox_anim
            // 
            this.comboBox_anim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_anim.ForeColor = System.Drawing.Color.Black;
            this.comboBox_anim.Items.AddRange(new object[] {
            "Bernard",
            "Daniel",
            "John",
            "Julien"});
            this.comboBox_anim.Location = new System.Drawing.Point(168, 164);
            this.comboBox_anim.Name = "comboBox_anim";
            this.comboBox_anim.Size = new System.Drawing.Size(121, 21);
            this.comboBox_anim.TabIndex = 16;
            //this.comboBox_anim.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_ajout
            // 
            this.btn_ajout.Location = new System.Drawing.Point(48, 343);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(75, 23);
            this.btn_ajout.TabIndex = 17;
            this.btn_ajout.Text = "AJOUTER";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(199, 343);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 18;
            this.btn_reset.Text = "ANNULER";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // FormAjoutActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.comboBox_anim);
            this.Controls.Add(this.numUpDown_nbMax);
            this.Controls.Add(this.datePicker_dateAct);
            this.Controls.Add(this.lbl_nbMaxPartic);
            this.Controls.Add(this.lbl_dateAct);
            this.Controls.Add(this.lbl_anim);
            this.Controls.Add(this.radioBtn_t4);
            this.Controls.Add(this.radioBtn_t3);
            this.Controls.Add(this.radioBtn_t2);
            this.Controls.Add(this.radioBtn_t1);
            this.Controls.Add(this.lbl_trancheAge);
            this.Controls.Add(this.textBox_lblAct);
            this.Controls.Add(this.lbl_libelleAct);
            this.Controls.Add(this.textBox_numAct);
            this.Controls.Add(this.lbl_numAct);
            this.Name = "FormAjoutActivite";
            this.Text = "FormAjoutActivite";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_nbMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_numAct;
        private System.Windows.Forms.TextBox textBox_numAct;
        private System.Windows.Forms.Label lbl_libelleAct;
        private System.Windows.Forms.TextBox textBox_lblAct;
        private System.Windows.Forms.Label lbl_trancheAge;
        private System.Windows.Forms.RadioButton radioBtn_t1;
        private System.Windows.Forms.RadioButton radioBtn_t2;
        private System.Windows.Forms.RadioButton radioBtn_t3;
        private System.Windows.Forms.RadioButton radioBtn_t4;
        private System.Windows.Forms.Label lbl_anim;
        private System.Windows.Forms.Label lbl_dateAct;
        private System.Windows.Forms.Label lbl_nbMaxPartic;
        private System.Windows.Forms.DateTimePicker datePicker_dateAct;
        private System.Windows.Forms.NumericUpDown numUpDown_nbMax;
        private System.Windows.Forms.ComboBox comboBox_anim;
        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.Button btn_reset;
    }
}