<?php
	require_once("personne.php");

	Class personne_morale extends personne
	{
		private $raisonSociale;
		private $formeJuridique;

		//CONSTRUCTEUR
		public function __Construct($id,$laRaisonSociale,$laFormeJuridique,$lAdresse,$leTelephone)
		{
			parent::__Construct($id,$lAdresse,$leTelephone);
			$this->raisonSociale = $laRaisonSociale;
			$this->formeJuridique = $laFormeJuridique;
		}


		public function getIdMorale()
		{
			return parent::getId();
		}
		public function getRaisonSociale()
		{
			return $this->raisonSociale;
		}

		public function getFormeJuridique()
		{
			return $this->formeJuridique;
		}

		public function getAdresseMorale()
		{
			return parent::getAdresse();
		}

		public function getTelephoneMorale()
		{
			return parent::getTelephone();
		}


	}


?>