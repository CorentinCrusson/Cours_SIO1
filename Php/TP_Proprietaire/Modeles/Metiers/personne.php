<?php

	Class personne
	{
		private $id;
		private $adresse;
		private $telephone;

		public function __Construct($leID,$lAdresse,$leTelephone)
		{
			$this->id = $leID;
			$this->adresse = $lAdresse;
			$this->telephone = $leTelephone;
		}

		//ACCESSEURS
		public function getId()
		{
			return $this->id;
		}

		public function getAdresse()
		{
			return $this->adresse;
		}

		public function getTelephone()
		{
			return $this->telephone;
		}

	}


?>