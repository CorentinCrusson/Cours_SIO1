<?php
	require_once("personne.php");

	Class personne_physique extends personne
	{
		private $nom;
		private $prenom;

		//CONSTRUCTEUR
		public function __Construct($id,$leNom,$lePrenom,$lAdresse,$leTelephone)
		{
			parent::__Construct($id,$lAdresse,$leTelephone);
			$this->nom = $leNom;
			$this->prenom = $lePrenom;
		}

		//ACCESSEURS
		public function getIdPhysique()
		{
			return parent::getId();
		}
		public function getNom()
		{
			return $this->nom;
		}

		public function getPrenom()
		{
			return $this->prenom;
		}

		public function getAdressePhysique()
		{
			return parent::getAdresse();
		}

		public function getTelephonePhysique()
		{
			return parent::getTelephone();
		}


	}


?>