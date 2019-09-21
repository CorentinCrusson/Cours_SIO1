<?php

	Class bien_immobilier
	{
		private $code;
		private $nom;
		private $adresse;
		private $codeProprietaire;

		//CONSTRUCTEUR
		public function __Construct($leCode, $leNom, $lAdresse, $leCodeProprio)
		{
			$this->code = $leCode;
			$this->nom = $leNom;
			$this->adresse = $lAdresse;
			$this->codeProprietaire = $leCodeProprio;
		}

		//ACCESEURS
		public function getCode()
		{
			return $this->code;
		}

		public function getNom()
		{
			return $this->nom;
		}

		public function getAdresse()
		{
			return $this->adresse;
		}

		public function getCodeProprio()
		{
			return $this->codeProprietaire;
		}

		//MUTATEURS
	}

?>