<?php

include "./Modeles/Metiers/personne_physique.php";

Class ConteneurPersPhysique
{

	private $lesPersPhysiques;
	
	//CONSTRUCTEUR-----------------------------------------------------------------------------
	public function __Construct()
	{
		$this->lesPersPhysiques = new arrayObject();
	}
	
	//METHODES
	public function ajoutPersPhysique($id,$leNom,$lePrenom,$lAdresse,$leTelephone)
	{
		$unePersPhysique = new personne_physique($id,$leNom,$lePrenom,$lAdresse,$leTelephone);		
		$this->lesPersPhysiques->append($unePersPhysique);
	}

	public function getlesPersPhysiques()
	{
		return $this->lesPersPhysiques;
	}

	public function nbPersPhysiques()
	{
		return $this->lesPersPhysiques->count();
	}

	public function listeDesPersPhysiques()
	{
		$liste ='<table border=3>
			<tr><TH> ID Personne Physique</TH><TH> Nom </TH><TH> Prenom </TH><TH> Adresse</TH> <TH> Telephone</TH></tr>';
		foreach($this->lesPersPhysiques as $unePersPhysique)
		{
			$liste = $liste.'<tr><td> '.$unePersPhysique->getIdPhysique().' </td><td>'.$unePersPhysique->getNom().' </td><td> '.$unePersPhysique->getPrenom().' </td><td> '.$unePersPhysique->getAdressePhysique().' </td><td> 0'.$unePersPhysique->getTelephonePhysique().' </td></tr>';
		}
		return $liste;
	}
	
	public function lesPersPhysiquesAuFormatHTML($vue)
	{
		$liste = "<SELECT name = 'id'>";

		if ($vue == "bien")
			$liste = $liste."<OPTION value='0'> </OPTION>";

		foreach ($this->lesPersPhysiques as $unePersPhysique)
			{
			$liste = $liste."<OPTION value='".$unePersPhysique->getIdPhysique()."'>".$unePersPhysique->getNom()." - ".$unePersPhysique->getPrenom()."</OPTION>";
			}

		if ($vue != "bien")
			$liste = $liste."</SELECT>";
		return $liste;
	}	
}

?>