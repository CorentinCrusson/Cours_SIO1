<?php

include "./Modeles/Metiers/personne_morale.php";

Class ConteneurPersMorale
{

	private $lesPersMorales;
	
	//CONSTRUCTEUR-----------------------------------------------------------------------------
	public function __Construct()
	{
		$this->lesPersMorales = new arrayObject();
	}
	
	//METHODES
	public function ajoutPersMorale($id,$laRaisonSociale,$laFormeJuridique,$lAdresse,$leTelephone)
	{
		$unePersMorale = new personne_morale($id,$laRaisonSociale,$laFormeJuridique,$lAdresse,$leTelephone);
		$this->lesPersMorales->append($unePersMorale);
	}

	public function getlesPersMorales()
	{
		return $this->lesPersMorales;
	}

	public function nbPersMorales()
	{
		return $this->lesPersMorales->count();
	}

	public function listeDesPersMorales()
	{
		$liste ='<table border=3>
			<tr><TH> ID Personne Morale</TH><TH> Raison Sociale </TH><TH> Forme Juridique </TH><TH> Adresse</TH> <TH> Telephone</TH></tr>';
		foreach($this->lesPersMorales as $unePersMorale)
		{
			$liste = $liste.'<tr><td> '.$unePersMorale->getIdMorale().' </td><td>'.$unePersMorale->getRaisonSociale().' </td><td> '.$unePersMorale->getFormeJuridique().' </td><td> '.$unePersMorale->getAdresseMorale().' </td><td> 0'.$unePersMorale->getTelephoneMorale().' </td></tr>';
		}
		return $liste;
	}

	public function lesPersMoralesAuFormatHTML($vue)
		{
		if ($vue != "bien")
			$liste = "<SELECT name = 'id'>";
		else
			$liste = "";
		foreach ($this->lesPersMorales as $unePersMorale)
			{
			$liste = $liste."<OPTION value='".$unePersMorale->getIdMorale()."'>".$unePersMorale->getRaisonSociale()." - ".$unePersMorale->getFormeJuridique()."</OPTION>";
			}
		$liste = $liste."</SELECT>";
		return $liste;
		}	
}

?>