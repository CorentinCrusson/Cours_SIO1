<?php

include "./Modeles/Metiers/bien_immobilier.php";

Class ConteneurBienImmobilier
{

	private $lesBiensImmobiliers;
	
	//CONSTRUCTEUR-----------------------------------------------------------------------------
	public function __Construct()
	{
		$this->lesBiensImmobiliers = new arrayObject();
	}

	//METHODES
	public function ajoutBien($code,$nom,$adresse,$codeProprio)
	{
		$unBien = new bien_immobilier($code,$nom,$adresse,$codeProprio);
		$this->lesBiensImmobiliers->append($unBien);
	}

	public function nbBiens()
	{
		return $this->lesBiensImmobiliers->count();
	}

	public function getLesBiens()
	{
		return $this->lesBiensImmobiliers;
	}

	public function listeDesBiens($lesPersPhysiques, $lesPersMorales)
	{
		$liste ='<table border=3>
			<tr><TH>Id </TH><TH>Nom </TH> <TH> Adresse </TH> <TH> Code Propriétaire </TH> </tr>';		

			foreach ($this->lesBiensImmobiliers as $unBien)
			{	
				$propriétaire = "Aucun Propriétaire";

				//On vérifie dans Pers Physique
				foreach($lesPersPhysiques as $unePers)
				if($unePers->getIdPhysique() == $unBien->getCodeProprio())
					$propriétaire = $unePers->getNom()."-".$unePers->getPrenom();

				//On vérifie dans Pers Morale
				foreach($lesPersMorales as $unePers)
				if($unePers->getIdMorale() == $unBien->getCodeProprio())
					$propriétaire = $unePers->getRaisonSociale()."-".$unePers->getFormeJuridique();


				$liste = $liste.'<tr><td>'.$unBien->getCode().'</td><td>'.$unBien->getNom().'</td><td>'.$unBien->getAdresse().'</td><td>'.$propriétaire.'</td></tr>';
				
			}
			$liste = $liste.'</table>';
			return $liste;
	}

	public function lesBiensAuFormatHTML()
		{
		$liste = "<SELECT name = 'code'>";

		foreach ($this->lesBiensImmobiliers as $unBien)
			{
				$liste = $liste."<OPTION value='".$unBien->getCode()."'>".$unBien->getNom()."</OPTION>";
			}
		$liste = $liste."</SELECT>";
		return $liste;
		}	

	public function donneIdBienDepuisNom($nomBien)
		{
		//initialisation d'un booléen (on part de l'hypothèse que le bien immobilier n'existe pas)
		$trouve=false;
		$leBonBien=null;
		//création d'un itérateur sur la collection lesBiensImmobiliers
		$iBien = $this->lesBiensImmobiliers->getIterator();
		//TQ on a pas trouvé le poste t que l'on est pas arrivé au bout de la collection
		while ((!$trouve)&&($iBien->valid()))
			{
			//SI le libellé du poste courant correspond au numéro passé en paramètre
			if ($iBien->current()->getLibelle()==$nomBien)
				{
				//maj du booléen
				$trouve=true;
				//sauvegarde de l'entraineur courant
				$leBonBien = $iBien->current();				
				}
			//SINON on passe au poste suivante
			else
			{				
				$iBien->next();
			}
		return $leBonBien->getId();
			}		
	
		}
}

?>