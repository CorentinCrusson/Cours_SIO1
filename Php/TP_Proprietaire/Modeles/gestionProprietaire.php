<?php

	include 'Conteneurs/ConteneurBienImmobilier.php';
	include 'Conteneurs/ConteneurPersPhysique.php';
	include 'Conteneurs/ConteneurPersMorale.php';	
	include './Modeles/accesBD.php';

class gestionProprietaire
{
	private $tousLesBiens;
	private $toutesLesPersPhysiques;
	private $toutesLesPersMorales;
	private $maBDD;

	//CONSTRUCTEUR
	public function __Construct()
	{
		$this->toutesLesPersPhysiques = new ConteneurPersPhysique();	
		$this->toutesLesPersMorales = new ConteneurPersMorale();		
		$this->tousLesBiens = new ConteneurBienImmobilier();			
		$this->maBDD = new accesBD();

		$this->chargeLesPersPhysiques();	
		$this->chargeLesPersMorales();	
		$this->chargeLesBiens();	
	}

	public function getPersPhysiques()
	{
		return $this->toutesLesPersPhysiques;
	}

	public function getPersMorales()
	{
		return $this->toutesLesPersMorales;
	}

	public function getBiens()
	{
		return $this->tousLesBiens;
	}

	private function chargeLesPersPhysiques()
	{
		$resultat = $this->maBDD->chargement('personne_physique');
		$nb =0;
		while ($nb<sizeof($resultat))
		{
			$this->toutesLesPersPhysiques->ajoutPersPhysique($resultat[$nb][0],$resultat[$nb][1],$resultat[$nb][2],$resultat[$nb][3],$resultat[$nb][4]);
			$nb++;
		}
	}

	private function chargeLesPersMorales()
	{
		$resultat = $this->maBDD->chargement('personne_morale');
		$nb =0;
		while ($nb<sizeof($resultat))
		{
			$this->toutesLesPersMorales->ajoutPersMorale($resultat[$nb][0],$resultat[$nb][1],$resultat[$nb][2],$resultat[$nb][3],$resultat[$nb][4]);
			$nb++;
		}
	}

	private function chargeLesBiens()
	{
		$resultat = $this->maBDD->chargement('bien_immobilier');
		$nb =0;
		while ($nb<sizeof($resultat))
		{
			$this->tousLesBiens->ajoutBien($resultat[$nb][0],$resultat[$nb][1],$resultat[$nb][2],$resultat[$nb][3]);
			$nb++;
		}
	}

	//METHODE AJOUTANT UN ELEMENT--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	public function ajouteUnePersPhysique($leNom,$lePrenom,$lAdresse,$leTelephone)
	{
		//DANS LA BDD
		$sonNumero = $this->maBDD->insertPersPhysique($leNom, $lePrenom, $lAdresse, $leTelephone);
		
		//DANS LA COLLECTION
		$this->toutesLesPersPhysiques->ajoutPersPhysique($sonNumero, $leNom, $lePrenom, $lAdresse, $leTelephone);
	}

	public function ajouteUnePersMorale($laRaisonSociale,$laFormeJuridique,$lAdresse,$leTelephone)
	{
		//DANS LA BDD	
		$sonNumero = $this->maBDD->insertPersMorale($laRaisonSociale, $laFormeJuridique, $lAdresse, $leTelephone);

		//DANS LA COLLECTION
		$this->toutesLesPersMorales->ajoutPersMorale($sonNumero, $laRaisonSociale, $laFormeJuridique, $lAdresse, $leTelephone);
	}

	public function ajouteUnBien($leNom, $lAdresse, $leCodeProprio)
	{
		//DANS LA BDD	
		$sonNumero = $this->maBDD->insertBien($leNom, $lAdresse, $leCodeProprio);

		//DANS LA COLLECTION
		$this->tousLesBiens->ajoutBien($sonNumero, $leNom, $lAdresse, $leCodeProprio);
	}

	//METHODE MODIFIANT UN ELEMENT--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	public function modifPersPhysique($idPers, $leNom,$lePrenom,$lAdresse,$leTelephone)
	{			
		//On vérifie si le champ saisi est vide et si c'est le cas, on rentre le champ avec les informations initiales
		foreach($this->toutesLesPersPhysiques->getLesPersPhysiques() as $unePers)
		{
			if($unePers->getIdPhysique() == $idPers)
				{
					if (empty($leNom))
						$leNom = $unePers->getNom();

					if (empty($lePrenom))
						$lePrenom = $unePers->getPrenom();

					if (empty($lAdresse))
						$lAdresse = $unePers->getAdressePhysique();

					if (empty($leTelephone))
						$leTelephone = $unePers->getTelephonePhysique();
				}
		}
		$this->maBDD->updatePersPhysique($idPers, $leNom,$lePrenom,$lAdresse,$leTelephone);
	}


	public function modifPersMorale($idPers, $laRaisonSociale,$laFormeJuridique,$lAdresse,$leTelephone)
	{
		//On vérifie si le champ saisi est vide et si c'est le cas, on rentre le champ avec les informations initiales
		foreach($this->toutesLesPersMorales->getLesPersMorales() as $unePers)
		{
			if($unePers->getIdMorale() == $idPers)
				{
					if (empty($laRaisonSociale))
						$laRaisonSociale = $unePers->getRaisonSociale();

					if (empty($laFormeJuridique))
						$laFormeJuridique = $unePers->getFormeJuridique();

					if (empty($lAdresse))
						$lAdresse = $unePers->getAdresseMorale();

					if (empty($leTelephone))
						$leTelephone = $unePers->getTelephoneMorale();
				}
		}

		//Modification de la table Salarie
		$this->maBDD->updatePersMorale($idPers, $laRaisonSociale,$laFormeJuridique,$lAdresse,$leTelephone);
	}

	public function modifBien($idBien, $leNom, $lAdresse, $leCodeProprio)
	{
		//On vérifie si le champ saisi est vide et si c'est le cas, on rentre le champ avec les informations initiales
		foreach($this->tousLesBiens->getLesBiens() as $unBien)
		{
			if($unBien->getCode() == $idBien)
			{
				if (empty($leNom))
					$leNom = $unBien->getNom();

				if (empty($lAdresse))
					$lAdresse = $unBien->getAdresse();
			}
		}
		//Modification de la table Poste
		$this->maBDD->updateBien($idBien, $leNom, $lAdresse, $leCodeProprio);
	}

	//METHODE SUPPRIMANT UN ELEMENT--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	public function supprimerPersPhysique($idPers)
	{
		$this->maBDD->removePersPhysique($idPers);
	}

	public function supprimerPersMorale($idPers)
	{
		$this->maBDD->removePersMorale($idPers);
	}

	public function supprimerBien($idBien)
	{
		$this->maBDD->removeBien($idBien);
	}

	//Methode retournant le nombre de ressources
	public function donneNbPersPhysiques()
	{
		return $this->toutesLesPersPhysiques->NbPersPhysiques();
	}
	public function donneNbPersMorales()
	{
		return $this->toutesLesPersMorales->NbPersMorales();
	}

	public function donneNbBiens()
	{
		return $this->tousLesBiens->NbBiens();
	}

	//METHODE RETOURNANT LA LISTE DES differents elements-------------------------------------------------------------------------------------------------------
	public function listeLesPersPhysiques()
	{
		return $this->toutesLesPersPhysiques->listeDesPersPhysiques();
	}
	public function listeLesPersMorales()
	{
		return $this->toutesLesPersMorales->listeDesPersMorales();
	}
	public function listeLesBiens()
	{
		return $this->tousLesBiens->listeDesBiens($this->toutesLesPersPhysiques->getLesPersPhysiques(),$this->toutesLesPersMorales->getLesPersMorales());
	}

	//METHODE RETOURNANT LA LISTE DES DIFFERENTS ELEMENTS DANS DES BALISES <SELECT>-----------------------------------------------------------------
	public function lesPersPhysiquesAuFormatHTML($vue)
	{
		return $this->toutesLesPersPhysiques->lesPersPhysiquesAuFormatHTML($vue);
	}
	public function lesPersMoralesAuFormatHTML($vue)
	{
		return $this->toutesLesPersMorales->lesPersMoralesAuFormatHTML($vue);
	}
	public function lesBiensAuFormatHTML()
	{
		return $this->tousLesBiens->lesBiensAuFormatHTML();
	}	
	
}


?>