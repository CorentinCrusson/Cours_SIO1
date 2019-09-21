namespace SLAM2_TP5_EpisodesSaisonsSeries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccueil));
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lbl_txtEpisodes = new System.Windows.Forms.Label();
            this.lbl_serieCourante = new System.Windows.Forms.Label();
            this.lbl_saisonCourante = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_SerieCourante = new System.Windows.Forms.ComboBox();
            this.cb_SaisonCourante = new System.Windows.Forms.ComboBox();
            this.lbl_realisateur = new System.Windows.Forms.Label();
            this.lbl_nbSaisons = new System.Windows.Forms.Label();
            this.lbl_annee = new System.Windows.Forms.Label();
            this.lbl_episodesPrevus = new System.Windows.Forms.Label();
            this.lbl_episodesDiffuses = new System.Windows.Forms.Label();
            this.lbl_dureeSaison = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_leRealisateur = new System.Windows.Forms.Label();
            this.lbl_leNbSsaisons = new System.Windows.Forms.Label();
            this.lbl_lAnnee = new System.Windows.Forms.Label();
            this.lbl_leNbEpisodesPrevus = new System.Windows.Forms.Label();
            this.lbl_leNbEpisodesDiff = new System.Windows.Forms.Label();
            this.lbl_laDureeSaison = new System.Windows.Forms.Label();
            this.lbl_ajoutSerie = new System.Windows.Forms.Label();
            this.lbl_ajoutSaison = new System.Windows.Forms.Label();
            this.lbl_ajoutEpisode = new System.Windows.Forms.Label();
            this.lbl_numSerie = new System.Windows.Forms.Label();
            this.lbl_titreSerie = new System.Windows.Forms.Label();
            this.lbl_ajoutReal = new System.Windows.Forms.Label();
            this.txtBox_numSerie = new System.Windows.Forms.TextBox();
            this.txtBox_titreSerie = new System.Windows.Forms.TextBox();
            this.txtBox_realisateur = new System.Windows.Forms.TextBox();
            this.btn_ajoutSerie = new System.Windows.Forms.Button();
            this.btn_ajoutSaison = new System.Windows.Forms.Button();
            this.txtBox_nbEpsPrevus = new System.Windows.Forms.TextBox();
            this.txtBox_numSaison = new System.Windows.Forms.TextBox();
            this.lbl_ajoutNbEpsPrevus = new System.Windows.Forms.Label();
            this.lbl_ajoutNumSaison = new System.Windows.Forms.Label();
            this.lbl_ajoutSerieAssociee = new System.Windows.Forms.Label();
            this.btn_ajoutEpisode = new System.Windows.Forms.Button();
            this.txtBox_ajoutNumEp = new System.Windows.Forms.TextBox();
            this.lbl_numEp = new System.Windows.Forms.Label();
            this.lbl_ajoutSaisonAssocieeEp = new System.Windows.Forms.Label();
            this.lbl_ajoutSerieAssocieeEp = new System.Windows.Forms.Label();
            this.lbl_ajoutAnnee = new System.Windows.Forms.Label();
            this.txtBox_annee = new System.Windows.Forms.TextBox();
            this.cb_SerieAssociee = new System.Windows.Forms.ComboBox();
            this.cb_SerieAssocieeEp = new System.Windows.Forms.ComboBox();
            this.cb_SaisonAssocieeEp = new System.Windows.Forms.ComboBox();
            this.lbl_titreEp = new System.Windows.Forms.Label();
            this.lbl_dureeEp = new System.Windows.Forms.Label();
            this.txtBox_ajoutTitreEp = new System.Windows.Forms.TextBox();
            this.txtBox_ajoutDureeEp = new System.Windows.Forms.TextBox();
            this.gb_serie = new System.Windows.Forms.GroupBox();
            this.gb_saison = new System.Windows.Forms.GroupBox();
            this.gb_episode = new System.Windows.Forms.GroupBox();
            this.cb_choixAjout = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_serie.SuspendLayout();
            this.gb_saison.SuspendLayout();
            this.gb_episode.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(251, 21);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(387, 42);
            this.lbl_titre.TabIndex = 0;
            this.lbl_titre.Text = "Gestion de séries TV";
            // 
            // lbl_txtEpisodes
            // 
            this.lbl_txtEpisodes.AutoSize = true;
            this.lbl_txtEpisodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txtEpisodes.Location = new System.Drawing.Point(29, 123);
            this.lbl_txtEpisodes.Name = "lbl_txtEpisodes";
            this.lbl_txtEpisodes.Size = new System.Drawing.Size(152, 25);
            this.lbl_txtEpisodes.TabIndex = 1;
            this.lbl_txtEpisodes.Text = "Les épisodes";
            // 
            // lbl_serieCourante
            // 
            this.lbl_serieCourante.AutoSize = true;
            this.lbl_serieCourante.Location = new System.Drawing.Point(66, 203);
            this.lbl_serieCourante.Name = "lbl_serieCourante";
            this.lbl_serieCourante.Size = new System.Drawing.Size(86, 13);
            this.lbl_serieCourante.TabIndex = 2;
            this.lbl_serieCourante.Text = "Série Courante : ";
            // 
            // lbl_saisonCourante
            // 
            this.lbl_saisonCourante.AutoSize = true;
            this.lbl_saisonCourante.Location = new System.Drawing.Point(66, 350);
            this.lbl_saisonCourante.Name = "lbl_saisonCourante";
            this.lbl_saisonCourante.Size = new System.Drawing.Size(94, 13);
            this.lbl_saisonCourante.TabIndex = 3;
            this.lbl_saisonCourante.Text = "Saison Courante : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(693, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 105);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cb_SerieCourante
            // 
            this.cb_SerieCourante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SerieCourante.FormattingEnabled = true;
            this.cb_SerieCourante.Location = new System.Drawing.Point(178, 203);
            this.cb_SerieCourante.Name = "cb_SerieCourante";
            this.cb_SerieCourante.Size = new System.Drawing.Size(158, 21);
            this.cb_SerieCourante.TabIndex = 5;
            this.cb_SerieCourante.SelectedIndexChanged += new System.EventHandler(this.cb_SerieCourante_SelectedIndexChanged);
            // 
            // cb_SaisonCourante
            // 
            this.cb_SaisonCourante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SaisonCourante.FormattingEnabled = true;
            this.cb_SaisonCourante.Location = new System.Drawing.Point(178, 342);
            this.cb_SaisonCourante.Name = "cb_SaisonCourante";
            this.cb_SaisonCourante.Size = new System.Drawing.Size(158, 21);
            this.cb_SaisonCourante.TabIndex = 6;
            this.cb_SaisonCourante.SelectedIndexChanged += new System.EventHandler(this.cb_SaisonCourante_SelectedIndexChanged);
            // 
            // lbl_realisateur
            // 
            this.lbl_realisateur.AutoSize = true;
            this.lbl_realisateur.Location = new System.Drawing.Point(452, 166);
            this.lbl_realisateur.Name = "lbl_realisateur";
            this.lbl_realisateur.Size = new System.Drawing.Size(69, 13);
            this.lbl_realisateur.TabIndex = 7;
            this.lbl_realisateur.Text = "Réalisateur : ";
            // 
            // lbl_nbSaisons
            // 
            this.lbl_nbSaisons.AutoSize = true;
            this.lbl_nbSaisons.Location = new System.Drawing.Point(452, 203);
            this.lbl_nbSaisons.Name = "lbl_nbSaisons";
            this.lbl_nbSaisons.Size = new System.Drawing.Size(108, 13);
            this.lbl_nbSaisons.TabIndex = 8;
            this.lbl_nbSaisons.Text = "Nombre de Saisons : ";
            // 
            // lbl_annee
            // 
            this.lbl_annee.AutoSize = true;
            this.lbl_annee.Location = new System.Drawing.Point(452, 284);
            this.lbl_annee.Name = "lbl_annee";
            this.lbl_annee.Size = new System.Drawing.Size(47, 13);
            this.lbl_annee.TabIndex = 9;
            this.lbl_annee.Text = "Année : ";
            // 
            // lbl_episodesPrevus
            // 
            this.lbl_episodesPrevus.AutoSize = true;
            this.lbl_episodesPrevus.Location = new System.Drawing.Point(452, 316);
            this.lbl_episodesPrevus.Name = "lbl_episodesPrevus";
            this.lbl_episodesPrevus.Size = new System.Drawing.Size(141, 13);
            this.lbl_episodesPrevus.TabIndex = 10;
            this.lbl_episodesPrevus.Text = "Nombre d\'épisodes prévus : ";
            // 
            // lbl_episodesDiffuses
            // 
            this.lbl_episodesDiffuses.AutoSize = true;
            this.lbl_episodesDiffuses.Location = new System.Drawing.Point(452, 350);
            this.lbl_episodesDiffuses.Name = "lbl_episodesDiffuses";
            this.lbl_episodesDiffuses.Size = new System.Drawing.Size(142, 13);
            this.lbl_episodesDiffuses.TabIndex = 11;
            this.lbl_episodesDiffuses.Text = "Nombre d\'épisodes diffusés: ";
            // 
            // lbl_dureeSaison
            // 
            this.lbl_dureeSaison.AutoSize = true;
            this.lbl_dureeSaison.Location = new System.Drawing.Point(452, 383);
            this.lbl_dureeSaison.Name = "lbl_dureeSaison";
            this.lbl_dureeSaison.Size = new System.Drawing.Size(106, 13);
            this.lbl_dureeSaison.TabIndex = 12;
            this.lbl_dureeSaison.Text = "Durée de la Saison : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Gérer les épisodes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_leRealisateur
            // 
            this.lbl_leRealisateur.AutoSize = true;
            this.lbl_leRealisateur.Location = new System.Drawing.Point(533, 166);
            this.lbl_leRealisateur.Name = "lbl_leRealisateur";
            this.lbl_leRealisateur.Size = new System.Drawing.Size(105, 13);
            this.lbl_leRealisateur.TabIndex = 14;
            this.lbl_leRealisateur.Text = "XXXXXXXXXXXXXX";
            // 
            // lbl_leNbSsaisons
            // 
            this.lbl_leNbSsaisons.AutoSize = true;
            this.lbl_leNbSsaisons.Location = new System.Drawing.Point(566, 203);
            this.lbl_leNbSsaisons.Name = "lbl_leNbSsaisons";
            this.lbl_leNbSsaisons.Size = new System.Drawing.Size(105, 13);
            this.lbl_leNbSsaisons.TabIndex = 15;
            this.lbl_leNbSsaisons.Text = "XXXXXXXXXXXXXX";
            // 
            // lbl_lAnnee
            // 
            this.lbl_lAnnee.AutoSize = true;
            this.lbl_lAnnee.Location = new System.Drawing.Point(505, 284);
            this.lbl_lAnnee.Name = "lbl_lAnnee";
            this.lbl_lAnnee.Size = new System.Drawing.Size(105, 13);
            this.lbl_lAnnee.TabIndex = 16;
            this.lbl_lAnnee.Text = "XXXXXXXXXXXXXX";
            // 
            // lbl_leNbEpisodesPrevus
            // 
            this.lbl_leNbEpisodesPrevus.AutoSize = true;
            this.lbl_leNbEpisodesPrevus.Location = new System.Drawing.Point(601, 316);
            this.lbl_leNbEpisodesPrevus.Name = "lbl_leNbEpisodesPrevus";
            this.lbl_leNbEpisodesPrevus.Size = new System.Drawing.Size(105, 13);
            this.lbl_leNbEpisodesPrevus.TabIndex = 17;
            this.lbl_leNbEpisodesPrevus.Text = "XXXXXXXXXXXXXX";
            // 
            // lbl_leNbEpisodesDiff
            // 
            this.lbl_leNbEpisodesDiff.AutoSize = true;
            this.lbl_leNbEpisodesDiff.Location = new System.Drawing.Point(601, 350);
            this.lbl_leNbEpisodesDiff.Name = "lbl_leNbEpisodesDiff";
            this.lbl_leNbEpisodesDiff.Size = new System.Drawing.Size(105, 13);
            this.lbl_leNbEpisodesDiff.TabIndex = 18;
            this.lbl_leNbEpisodesDiff.Text = "XXXXXXXXXXXXXX";
            // 
            // lbl_laDureeSaison
            // 
            this.lbl_laDureeSaison.AutoSize = true;
            this.lbl_laDureeSaison.Location = new System.Drawing.Point(566, 383);
            this.lbl_laDureeSaison.Name = "lbl_laDureeSaison";
            this.lbl_laDureeSaison.Size = new System.Drawing.Size(105, 13);
            this.lbl_laDureeSaison.TabIndex = 19;
            this.lbl_laDureeSaison.Text = "XXXXXXXXXXXXXX";
            // 
            // lbl_ajoutSerie
            // 
            this.lbl_ajoutSerie.AutoSize = true;
            this.lbl_ajoutSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajoutSerie.Location = new System.Drawing.Point(15, 16);
            this.lbl_ajoutSerie.Name = "lbl_ajoutSerie";
            this.lbl_ajoutSerie.Size = new System.Drawing.Size(174, 24);
            this.lbl_ajoutSerie.TabIndex = 20;
            this.lbl_ajoutSerie.Text = "Ajouter une Série";
            // 
            // lbl_ajoutSaison
            // 
            this.lbl_ajoutSaison.AutoSize = true;
            this.lbl_ajoutSaison.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajoutSaison.Location = new System.Drawing.Point(6, 16);
            this.lbl_ajoutSaison.Name = "lbl_ajoutSaison";
            this.lbl_ajoutSaison.Size = new System.Drawing.Size(188, 24);
            this.lbl_ajoutSaison.TabIndex = 21;
            this.lbl_ajoutSaison.Text = "Ajouter une Saison";
            // 
            // lbl_ajoutEpisode
            // 
            this.lbl_ajoutEpisode.AutoSize = true;
            this.lbl_ajoutEpisode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajoutEpisode.Location = new System.Drawing.Point(19, 16);
            this.lbl_ajoutEpisode.Name = "lbl_ajoutEpisode";
            this.lbl_ajoutEpisode.Size = new System.Drawing.Size(190, 24);
            this.lbl_ajoutEpisode.TabIndex = 22;
            this.lbl_ajoutEpisode.Text = "Ajouter un Épisode";
            // 
            // lbl_numSerie
            // 
            this.lbl_numSerie.AutoSize = true;
            this.lbl_numSerie.Location = new System.Drawing.Point(16, 49);
            this.lbl_numSerie.Name = "lbl_numSerie";
            this.lbl_numSerie.Size = new System.Drawing.Size(65, 13);
            this.lbl_numSerie.TabIndex = 23;
            this.lbl_numSerie.Text = "Num Série : ";
            // 
            // lbl_titreSerie
            // 
            this.lbl_titreSerie.AutoSize = true;
            this.lbl_titreSerie.Location = new System.Drawing.Point(17, 81);
            this.lbl_titreSerie.Name = "lbl_titreSerie";
            this.lbl_titreSerie.Size = new System.Drawing.Size(64, 13);
            this.lbl_titreSerie.TabIndex = 24;
            this.lbl_titreSerie.Text = "Titre Série : ";
            // 
            // lbl_ajoutReal
            // 
            this.lbl_ajoutReal.AutoSize = true;
            this.lbl_ajoutReal.Location = new System.Drawing.Point(234, 43);
            this.lbl_ajoutReal.Name = "lbl_ajoutReal";
            this.lbl_ajoutReal.Size = new System.Drawing.Size(69, 13);
            this.lbl_ajoutReal.TabIndex = 25;
            this.lbl_ajoutReal.Text = "Réalisateur : ";
            // 
            // txtBox_numSerie
            // 
            this.txtBox_numSerie.Location = new System.Drawing.Point(87, 49);
            this.txtBox_numSerie.Name = "txtBox_numSerie";
            this.txtBox_numSerie.Size = new System.Drawing.Size(100, 20);
            this.txtBox_numSerie.TabIndex = 26;
            // 
            // txtBox_titreSerie
            // 
            this.txtBox_titreSerie.Location = new System.Drawing.Point(87, 81);
            this.txtBox_titreSerie.Name = "txtBox_titreSerie";
            this.txtBox_titreSerie.Size = new System.Drawing.Size(100, 20);
            this.txtBox_titreSerie.TabIndex = 27;
            // 
            // txtBox_realisateur
            // 
            this.txtBox_realisateur.Location = new System.Drawing.Point(352, 40);
            this.txtBox_realisateur.Name = "txtBox_realisateur";
            this.txtBox_realisateur.Size = new System.Drawing.Size(100, 20);
            this.txtBox_realisateur.TabIndex = 28;
            // 
            // btn_ajoutSerie
            // 
            this.btn_ajoutSerie.Location = new System.Drawing.Point(494, 81);
            this.btn_ajoutSerie.Name = "btn_ajoutSerie";
            this.btn_ajoutSerie.Size = new System.Drawing.Size(108, 23);
            this.btn_ajoutSerie.TabIndex = 29;
            this.btn_ajoutSerie.Text = "Ajouter une Série";
            this.btn_ajoutSerie.UseVisualStyleBackColor = true;
            this.btn_ajoutSerie.Click += new System.EventHandler(this.btn_ajoutSerie_Click);
            // 
            // btn_ajoutSaison
            // 
            this.btn_ajoutSaison.Location = new System.Drawing.Point(535, 95);
            this.btn_ajoutSaison.Name = "btn_ajoutSaison";
            this.btn_ajoutSaison.Size = new System.Drawing.Size(108, 23);
            this.btn_ajoutSaison.TabIndex = 36;
            this.btn_ajoutSaison.Text = "Ajouter une Saison";
            this.btn_ajoutSaison.UseVisualStyleBackColor = true;
            this.btn_ajoutSaison.Click += new System.EventHandler(this.btn_ajoutSaison_Click);
            // 
            // txtBox_nbEpsPrevus
            // 
            this.txtBox_nbEpsPrevus.Location = new System.Drawing.Point(409, 53);
            this.txtBox_nbEpsPrevus.Name = "txtBox_nbEpsPrevus";
            this.txtBox_nbEpsPrevus.Size = new System.Drawing.Size(100, 20);
            this.txtBox_nbEpsPrevus.TabIndex = 35;
            // 
            // txtBox_numSaison
            // 
            this.txtBox_numSaison.Location = new System.Drawing.Point(115, 97);
            this.txtBox_numSaison.Name = "txtBox_numSaison";
            this.txtBox_numSaison.Size = new System.Drawing.Size(100, 20);
            this.txtBox_numSaison.TabIndex = 34;
            // 
            // lbl_ajoutNbEpsPrevus
            // 
            this.lbl_ajoutNbEpsPrevus.AutoSize = true;
            this.lbl_ajoutNbEpsPrevus.Location = new System.Drawing.Point(260, 56);
            this.lbl_ajoutNbEpsPrevus.Name = "lbl_ajoutNbEpsPrevus";
            this.lbl_ajoutNbEpsPrevus.Size = new System.Drawing.Size(143, 13);
            this.lbl_ajoutNbEpsPrevus.TabIndex = 32;
            this.lbl_ajoutNbEpsPrevus.Text = "Nombre d\'Épisodes Prévus : ";
            // 
            // lbl_ajoutNumSaison
            // 
            this.lbl_ajoutNumSaison.AutoSize = true;
            this.lbl_ajoutNumSaison.Location = new System.Drawing.Point(6, 100);
            this.lbl_ajoutNumSaison.Name = "lbl_ajoutNumSaison";
            this.lbl_ajoutNumSaison.Size = new System.Drawing.Size(103, 13);
            this.lbl_ajoutNumSaison.TabIndex = 31;
            this.lbl_ajoutNumSaison.Text = "Numéro de Saison : ";
            // 
            // lbl_ajoutSerieAssociee
            // 
            this.lbl_ajoutSerieAssociee.AutoSize = true;
            this.lbl_ajoutSerieAssociee.Location = new System.Drawing.Point(6, 56);
            this.lbl_ajoutSerieAssociee.Name = "lbl_ajoutSerieAssociee";
            this.lbl_ajoutSerieAssociee.Size = new System.Drawing.Size(86, 13);
            this.lbl_ajoutSerieAssociee.TabIndex = 30;
            this.lbl_ajoutSerieAssociee.Text = "Série Associée : ";
            // 
            // btn_ajoutEpisode
            // 
            this.btn_ajoutEpisode.Location = new System.Drawing.Point(549, 113);
            this.btn_ajoutEpisode.Name = "btn_ajoutEpisode";
            this.btn_ajoutEpisode.Size = new System.Drawing.Size(108, 23);
            this.btn_ajoutEpisode.TabIndex = 43;
            this.btn_ajoutEpisode.Text = "Ajouter un Épisode";
            this.btn_ajoutEpisode.UseVisualStyleBackColor = true;
            this.btn_ajoutEpisode.Click += new System.EventHandler(this.btn_ajoutEpisode_Click);
            // 
            // txtBox_ajoutNumEp
            // 
            this.txtBox_ajoutNumEp.Location = new System.Drawing.Point(425, 47);
            this.txtBox_ajoutNumEp.Name = "txtBox_ajoutNumEp";
            this.txtBox_ajoutNumEp.Size = new System.Drawing.Size(100, 20);
            this.txtBox_ajoutNumEp.TabIndex = 42;
            // 
            // lbl_numEp
            // 
            this.lbl_numEp.AutoSize = true;
            this.lbl_numEp.Location = new System.Drawing.Point(319, 50);
            this.lbl_numEp.Name = "lbl_numEp";
            this.lbl_numEp.Size = new System.Drawing.Size(79, 13);
            this.lbl_numEp.TabIndex = 39;
            this.lbl_numEp.Text = "Num Épisode : ";
            this.lbl_numEp.Click += new System.EventHandler(this.lbl_numEp_Click);
            // 
            // lbl_ajoutSaisonAssocieeEp
            // 
            this.lbl_ajoutSaisonAssocieeEp.AutoSize = true;
            this.lbl_ajoutSaisonAssocieeEp.Location = new System.Drawing.Point(20, 90);
            this.lbl_ajoutSaisonAssocieeEp.Name = "lbl_ajoutSaisonAssocieeEp";
            this.lbl_ajoutSaisonAssocieeEp.Size = new System.Drawing.Size(94, 13);
            this.lbl_ajoutSaisonAssocieeEp.TabIndex = 38;
            this.lbl_ajoutSaisonAssocieeEp.Text = "Saison Associée : ";
            // 
            // lbl_ajoutSerieAssocieeEp
            // 
            this.lbl_ajoutSerieAssocieeEp.AutoSize = true;
            this.lbl_ajoutSerieAssocieeEp.Location = new System.Drawing.Point(20, 53);
            this.lbl_ajoutSerieAssocieeEp.Name = "lbl_ajoutSerieAssocieeEp";
            this.lbl_ajoutSerieAssocieeEp.Size = new System.Drawing.Size(86, 13);
            this.lbl_ajoutSerieAssocieeEp.TabIndex = 37;
            this.lbl_ajoutSerieAssocieeEp.Text = "Série Associée : ";
            // 
            // lbl_ajoutAnnee
            // 
            this.lbl_ajoutAnnee.AutoSize = true;
            this.lbl_ajoutAnnee.Location = new System.Drawing.Point(260, 100);
            this.lbl_ajoutAnnee.Name = "lbl_ajoutAnnee";
            this.lbl_ajoutAnnee.Size = new System.Drawing.Size(47, 13);
            this.lbl_ajoutAnnee.TabIndex = 44;
            this.lbl_ajoutAnnee.Text = "Année : ";
            // 
            // txtBox_annee
            // 
            this.txtBox_annee.Location = new System.Drawing.Point(330, 97);
            this.txtBox_annee.Name = "txtBox_annee";
            this.txtBox_annee.Size = new System.Drawing.Size(100, 20);
            this.txtBox_annee.TabIndex = 45;
            // 
            // cb_SerieAssociee
            // 
            this.cb_SerieAssociee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SerieAssociee.FormattingEnabled = true;
            this.cb_SerieAssociee.Location = new System.Drawing.Point(98, 53);
            this.cb_SerieAssociee.Name = "cb_SerieAssociee";
            this.cb_SerieAssociee.Size = new System.Drawing.Size(121, 21);
            this.cb_SerieAssociee.TabIndex = 46;
            // 
            // cb_SerieAssocieeEp
            // 
            this.cb_SerieAssocieeEp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SerieAssocieeEp.FormattingEnabled = true;
            this.cb_SerieAssocieeEp.Location = new System.Drawing.Point(127, 50);
            this.cb_SerieAssocieeEp.Name = "cb_SerieAssocieeEp";
            this.cb_SerieAssocieeEp.Size = new System.Drawing.Size(121, 21);
            this.cb_SerieAssocieeEp.TabIndex = 47;
            this.cb_SerieAssocieeEp.SelectedIndexChanged += new System.EventHandler(this.cb_SerieAssocieeEp_SelectedIndexChanged);
            // 
            // cb_SaisonAssocieeEp
            // 
            this.cb_SaisonAssocieeEp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SaisonAssocieeEp.FormattingEnabled = true;
            this.cb_SaisonAssocieeEp.Location = new System.Drawing.Point(127, 87);
            this.cb_SaisonAssocieeEp.Name = "cb_SaisonAssocieeEp";
            this.cb_SaisonAssocieeEp.Size = new System.Drawing.Size(121, 21);
            this.cb_SaisonAssocieeEp.TabIndex = 48;
            // 
            // lbl_titreEp
            // 
            this.lbl_titreEp.AutoSize = true;
            this.lbl_titreEp.Location = new System.Drawing.Point(320, 84);
            this.lbl_titreEp.Name = "lbl_titreEp";
            this.lbl_titreEp.Size = new System.Drawing.Size(78, 13);
            this.lbl_titreEp.TabIndex = 49;
            this.lbl_titreEp.Text = "Titre Épisode : ";
            // 
            // lbl_dureeEp
            // 
            this.lbl_dureeEp.AutoSize = true;
            this.lbl_dureeEp.Location = new System.Drawing.Point(317, 116);
            this.lbl_dureeEp.Name = "lbl_dureeEp";
            this.lbl_dureeEp.Size = new System.Drawing.Size(86, 13);
            this.lbl_dureeEp.TabIndex = 50;
            this.lbl_dureeEp.Text = "Durée Épisode : ";
            this.lbl_dureeEp.Click += new System.EventHandler(this.lbl_dureeEp_Click);
            // 
            // txtBox_ajoutTitreEp
            // 
            this.txtBox_ajoutTitreEp.Location = new System.Drawing.Point(425, 113);
            this.txtBox_ajoutTitreEp.Name = "txtBox_ajoutTitreEp";
            this.txtBox_ajoutTitreEp.Size = new System.Drawing.Size(100, 20);
            this.txtBox_ajoutTitreEp.TabIndex = 51;
            // 
            // txtBox_ajoutDureeEp
            // 
            this.txtBox_ajoutDureeEp.Location = new System.Drawing.Point(425, 81);
            this.txtBox_ajoutDureeEp.Name = "txtBox_ajoutDureeEp";
            this.txtBox_ajoutDureeEp.Size = new System.Drawing.Size(100, 20);
            this.txtBox_ajoutDureeEp.TabIndex = 52;
            // 
            // gb_serie
            // 
            this.gb_serie.Controls.Add(this.lbl_ajoutSerie);
            this.gb_serie.Controls.Add(this.lbl_ajoutReal);
            this.gb_serie.Controls.Add(this.txtBox_realisateur);
            this.gb_serie.Controls.Add(this.lbl_numSerie);
            this.gb_serie.Controls.Add(this.txtBox_numSerie);
            this.gb_serie.Controls.Add(this.lbl_titreSerie);
            this.gb_serie.Controls.Add(this.txtBox_titreSerie);
            this.gb_serie.Controls.Add(this.btn_ajoutSerie);
            this.gb_serie.Location = new System.Drawing.Point(12, 588);
            this.gb_serie.Name = "gb_serie";
            this.gb_serie.Size = new System.Drawing.Size(669, 123);
            this.gb_serie.TabIndex = 53;
            this.gb_serie.TabStop = false;
            this.gb_serie.Visible = false;
            // 
            // gb_saison
            // 
            this.gb_saison.Controls.Add(this.lbl_ajoutSaison);
            this.gb_saison.Controls.Add(this.lbl_ajoutSerieAssociee);
            this.gb_saison.Controls.Add(this.txtBox_numSaison);
            this.gb_saison.Controls.Add(this.lbl_ajoutNumSaison);
            this.gb_saison.Controls.Add(this.cb_SerieAssociee);
            this.gb_saison.Controls.Add(this.lbl_ajoutNbEpsPrevus);
            this.gb_saison.Controls.Add(this.txtBox_nbEpsPrevus);
            this.gb_saison.Controls.Add(this.lbl_ajoutAnnee);
            this.gb_saison.Controls.Add(this.txtBox_annee);
            this.gb_saison.Controls.Add(this.btn_ajoutSaison);
            this.gb_saison.Location = new System.Drawing.Point(18, 493);
            this.gb_saison.Name = "gb_saison";
            this.gb_saison.Size = new System.Drawing.Size(669, 126);
            this.gb_saison.TabIndex = 54;
            this.gb_saison.TabStop = false;
            this.gb_saison.Visible = false;
            // 
            // gb_episode
            // 
            this.gb_episode.Controls.Add(this.lbl_ajoutEpisode);
            this.gb_episode.Controls.Add(this.lbl_ajoutSerieAssocieeEp);
            this.gb_episode.Controls.Add(this.cb_SerieAssocieeEp);
            this.gb_episode.Controls.Add(this.btn_ajoutEpisode);
            this.gb_episode.Controls.Add(this.txtBox_ajoutDureeEp);
            this.gb_episode.Controls.Add(this.txtBox_ajoutTitreEp);
            this.gb_episode.Controls.Add(this.lbl_dureeEp);
            this.gb_episode.Controls.Add(this.lbl_ajoutSaisonAssocieeEp);
            this.gb_episode.Controls.Add(this.cb_SaisonAssocieeEp);
            this.gb_episode.Controls.Add(this.lbl_titreEp);
            this.gb_episode.Controls.Add(this.lbl_numEp);
            this.gb_episode.Controls.Add(this.txtBox_ajoutNumEp);
            this.gb_episode.Location = new System.Drawing.Point(233, 522);
            this.gb_episode.Name = "gb_episode";
            this.gb_episode.Size = new System.Drawing.Size(669, 160);
            this.gb_episode.TabIndex = 47;
            this.gb_episode.TabStop = false;
            this.gb_episode.Visible = false;
            // 
            // cb_choixAjout
            // 
            this.cb_choixAjout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_choixAjout.FormattingEnabled = true;
            this.cb_choixAjout.Items.AddRange(new object[] {
            "Serie",
            "Saison",
            "Episode"});
            this.cb_choixAjout.Location = new System.Drawing.Point(79, 500);
            this.cb_choixAjout.Name = "cb_choixAjout";
            this.cb_choixAjout.Size = new System.Drawing.Size(121, 21);
            this.cb_choixAjout.TabIndex = 55;
            this.cb_choixAjout.SelectedIndexChanged += new System.EventHandler(this.cb_choixAjout_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 56;
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 731);
            this.Controls.Add(this.gb_episode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_choixAjout);
            this.Controls.Add(this.gb_saison);
            this.Controls.Add(this.gb_serie);
            this.Controls.Add(this.lbl_laDureeSaison);
            this.Controls.Add(this.lbl_leNbEpisodesDiff);
            this.Controls.Add(this.lbl_leNbEpisodesPrevus);
            this.Controls.Add(this.lbl_lAnnee);
            this.Controls.Add(this.lbl_leNbSsaisons);
            this.Controls.Add(this.lbl_leRealisateur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_dureeSaison);
            this.Controls.Add(this.lbl_episodesDiffuses);
            this.Controls.Add(this.lbl_episodesPrevus);
            this.Controls.Add(this.lbl_annee);
            this.Controls.Add(this.lbl_nbSaisons);
            this.Controls.Add(this.lbl_realisateur);
            this.Controls.Add(this.cb_SaisonCourante);
            this.Controls.Add(this.cb_SerieCourante);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_saisonCourante);
            this.Controls.Add(this.lbl_serieCourante);
            this.Controls.Add(this.lbl_txtEpisodes);
            this.Controls.Add(this.lbl_titre);
            this.Name = "FormAccueil";
            this.Text = "Séries TV";
            this.Load += new System.EventHandler(this.FormAccueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_serie.ResumeLayout(false);
            this.gb_serie.PerformLayout();
            this.gb_saison.ResumeLayout(false);
            this.gb_saison.PerformLayout();
            this.gb_episode.ResumeLayout(false);
            this.gb_episode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_txtEpisodes;
        private System.Windows.Forms.Label lbl_serieCourante;
        private System.Windows.Forms.Label lbl_saisonCourante;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cb_SerieCourante;
        private System.Windows.Forms.ComboBox cb_SaisonCourante;
        private System.Windows.Forms.Label lbl_realisateur;
        private System.Windows.Forms.Label lbl_nbSaisons;
        private System.Windows.Forms.Label lbl_annee;
        private System.Windows.Forms.Label lbl_episodesPrevus;
        private System.Windows.Forms.Label lbl_episodesDiffuses;
        private System.Windows.Forms.Label lbl_dureeSaison;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_leRealisateur;
        private System.Windows.Forms.Label lbl_leNbSsaisons;
        private System.Windows.Forms.Label lbl_lAnnee;
        private System.Windows.Forms.Label lbl_leNbEpisodesPrevus;
        private System.Windows.Forms.Label lbl_leNbEpisodesDiff;
        private System.Windows.Forms.Label lbl_laDureeSaison;
        private System.Windows.Forms.Label lbl_ajoutSerie;
        private System.Windows.Forms.Label lbl_ajoutSaison;
        private System.Windows.Forms.Label lbl_ajoutEpisode;
        private System.Windows.Forms.Label lbl_numSerie;
        private System.Windows.Forms.Label lbl_titreSerie;
        private System.Windows.Forms.Label lbl_ajoutReal;
        private System.Windows.Forms.TextBox txtBox_numSerie;
        private System.Windows.Forms.TextBox txtBox_titreSerie;
        private System.Windows.Forms.TextBox txtBox_realisateur;
        private System.Windows.Forms.Button btn_ajoutSerie;
        private System.Windows.Forms.Button btn_ajoutSaison;
        private System.Windows.Forms.TextBox txtBox_nbEpsPrevus;
        private System.Windows.Forms.TextBox txtBox_numSaison;
        private System.Windows.Forms.Label lbl_ajoutNbEpsPrevus;
        private System.Windows.Forms.Label lbl_ajoutNumSaison;
        private System.Windows.Forms.Label lbl_ajoutSerieAssociee;
        private System.Windows.Forms.Button btn_ajoutEpisode;
        private System.Windows.Forms.TextBox txtBox_ajoutNumEp;
        private System.Windows.Forms.Label lbl_numEp;
        private System.Windows.Forms.Label lbl_ajoutSaisonAssocieeEp;
        private System.Windows.Forms.Label lbl_ajoutSerieAssocieeEp;
        private System.Windows.Forms.Label lbl_ajoutAnnee;
        private System.Windows.Forms.TextBox txtBox_annee;
        private System.Windows.Forms.ComboBox cb_SerieAssociee;
        private System.Windows.Forms.ComboBox cb_SerieAssocieeEp;
        private System.Windows.Forms.ComboBox cb_SaisonAssocieeEp;
        private System.Windows.Forms.Label lbl_titreEp;
        private System.Windows.Forms.Label lbl_dureeEp;
        private System.Windows.Forms.TextBox txtBox_ajoutTitreEp;
        private System.Windows.Forms.TextBox txtBox_ajoutDureeEp;
        private System.Windows.Forms.GroupBox gb_serie;
        private System.Windows.Forms.GroupBox gb_saison;
        private System.Windows.Forms.GroupBox gb_episode;
        private System.Windows.Forms.ComboBox cb_choixAjout;
        private System.Windows.Forms.Label label1;
    }
}

