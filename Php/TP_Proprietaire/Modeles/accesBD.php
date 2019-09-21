<?php

class accesBD
{
	private $hote;
	private $login;
	private $passwd;
	private $base;
	private $conn;

	//CONSTRUCTEUR
	public function __Construct()
	{
		$this->hote="localhost";
		$this->login="root";
		$this->passwd="";
		$this->base="bddproprietaire";
		$this->connexion();

	}

	private function connexion()
	{
		try
        {
            $this->conn = new PDO("mysql:host=".$this->hote.";dbname=".$this->base.";charset=utf8", $this->login, $this->passwd);
            $this->boolConnexion = true;
        }
        catch(PDOException $e)
        {
            die("Connection à la base de données échouée".$e->getMessage());
        }
	}

	public function chargement($uneTable)
	{
		$lesInfos=null;
		$nbTuples=0;
		if ($uneTable == 'personne_morale') {
			$stringQuery="SELECT DISTINCT m.*, p.adresse, p.telephone FROM PERSONNE p, PERSONNE_MORALE m WHERE p.pers_id = m.pers_id ORDER BY pers_id";
		} 
		else if ($uneTable == 'personne_physique')
		{
			$stringQuery="SELECT DISTINCT phy.*, p.adresse, p.telephone FROM PERSONNE p, PERSONNE_PHYSIQUE phy WHERE p.pers_id = phy.pers_id ORDER BY pers_id";
		} 
		else
		{
			$stringQuery="SELECT * FROM ";
			$stringQuery = $this->specialCase($stringQuery,$uneTable);
		}

		//définition de la requête SQL
		//On prépare la requete
		$query = $this->conn->prepare($stringQuery);
		//POUR chaque tuple retourné par la requête SQL
		if($query->execute())
		{
			while($row = $query->fetch(PDO::FETCH_NUM))
			{
				$lesInfos[$nbTuples] = $row;
				$nbTuples++;				
			}
		}
		else
		{
			die('Problème dans chargement : '.$query->errorCode());
		}

		//retour du tableau à deux dimension
		return $lesInfos;
	}

	public function insertPersPhysique($leNom,$lePrenom,$lAdresse,$leTelephone)
	{
		//génération automatique de l'identifiant
		$sonId = $this->donneProchainIdentifiant("personne","pers_id");

		$requete = $this->conn->prepare("INSERT INTO PERSONNE (pers_id,adresse,telephone) VALUES (?,?,?)");
		$requete->bindValue(1,$sonId);		
		$requete->bindValue(2,$lAdresse);
		$requete->bindValue(3,$leTelephone);		
		$requete->execute();

		$requete = $this->conn->prepare("INSERT INTO PERSONNE_PHYSIQUE (pers_id,nom,prenom) VALUES (?,?,?)");
		//définition de la requête SQL
		$requete->bindValue(1,$sonId);
		$requete->bindValue(2,$leNom);
		$requete->bindValue(3,$lePrenom);

		//exécution de la requête SQL
		if(!$requete->execute())
		{
			die("Erreur dans insertPersPhysique : ".$requete->errorCode());
		}

		//retour de l'identifiant du nouveau tuple
		return $sonId;
	}

	public function insertPersMorale($laRaisonSociale,$laFormeJuridique,$lAdresse,$leTelephone)
	{
		//génération automatique de l'identifiant
		$sonId = $this->donneProchainIdentifiant("personne","pers_id");

		$requete = $this->conn->prepare("INSERT INTO PERSONNE (pers_id,adresse,telephone) VALUES (?,?,?)");
		$requete->bindValue(1,$sonId);		
		$requete->bindValue(2,$lAdresse);
		$requete->bindValue(3,$leTelephone);
		$requete->execute();

		$requete = $this->conn->prepare("INSERT INTO PERSONNE_MORALE (pers_id,raison_sociale,forme_juridique) VALUES (?,?,?)");
		//définition de la requête SQL
		$requete->bindValue(1,$sonId);
		$requete->bindValue(2,$laRaisonSociale);
		$requete->bindValue(3,$laFormeJuridique);

		//exécution de la requête SQL
		if(!$requete->execute())
		{
			die("Erreur dans insertPersMorale : ".$requete->errorCode());
		}

		//retour de l'identifiant du nouveau tuple
		return $sonId;
	}

	public function insertBien($leNom, $lAdresse, $leCodeProprio)
	{
		//génération automatique de l'identifiant
		$sonId = $this->donneProchainIdentifiant("BIEN_IMMOBILIER","code");

		$requete = $this->conn->prepare("INSERT INTO BIEN_IMMOBILIER (code,nom,adresse,codeProprietaire) VALUES (?,?,?,?)");

		//définition de la requête SQL
		$requete->bindValue(1,$sonId);
		$requete->bindValue(2,$leNom);
		$requete->bindValue(3,$lAdresse);
		$requete->bindValue(4,$leCodeProprio);

		//exécution de la requête SQL
		if(!$requete->execute())
		{
			die("Erreur dans insertBien : ".$requete->errorCode());
		}

		//retour de l'identifiant du nouveau tuple
		return $sonId;
	}

	public function updateBien($code, $leNom, $lAdresse, $leCodeProprio)
	{
		$requete = $this->conn->prepare("UPDATE BIEN_IMMOBILIER set nom = '".$leNom."',adresse = '".$lAdresse."', codeProprietaire = '".$leCodeProprio."' WHERE code = ".$code.";");

		if(!$requete->execute())
		{
			die("Erreur dans modifBien : ".$requete->errorCode());
		}
	}

	public function updatePersMorale($idPers, $laRaisonSociale,$laFormeJuridique,$lAdresse,$leTelephone)
	{
		$requete = $this->conn->prepare("UPDATE PERSONNE_MORALE set raison_sociale = '".$laRaisonSociale."',forme_juridique = '".$laFormeJuridique."' WHERE pers_id = ".$idPers.";");
		$requete->execute();
		$requete = $this->conn->prepare("UPDATE PERSONNE set adresse = '".$lAdresse."', telephone = '".$leTelephone."' WHERE pers_id = ".$idPers.";");

		if(!$requete->execute())
		{
			die("Erreur dans modifPersMorale : ".$requete->errorCode());
		}
	}

	public function updatePersPhysique($idPers, $leNom,$lePrenom,$lAdresse,$leTelephone)
	{
		$requete = $this->conn->prepare("UPDATE PERSONNE_PHYSIQUE set nom = '".$leNom."',prenom = '".$lePrenom."' WHERE pers_id = ".$idPers.";");
		$requete->execute();
		$requete = $this->conn->prepare("UPDATE PERSONNE set adresse = '".$lAdresse."', telephone = '".$leTelephone."' WHERE pers_id = ".$idPers.";");

		if(!$requete->execute())
		{
			die("Erreur dans modifPersPhysique : ".$requete->errorCode());
		}
	}

	public function removePersPhysique($idPers)
	{
		$requete = $this->conn->prepare("DELETE FROM personne_physique WHERE pers_id = ".$idPers.";");
		$requete->execute();
		$requete = $this->conn->prepare("DELETE FROM personne WHERE pers_id = ".$idPers.";");

		if(!$requete->execute())
		{
			die("Erreur dans supprimer Personne Physique : ".$requete->errorCode());
		}
	}

	public function removePersMorale($idPers)
	{
		$requete = $this->conn->prepare("DELETE FROM personne_morale WHERE pers_id = ".$idPers.";");
		$requete->execute();
		$requete = $this->conn->prepare("DELETE FROM personne WHERE pers_id = ".$idPers.";");

		if(!$requete->execute())
		{
			die("Erreur dans supprimer Personne Morale : ".$requete->errorCode());
		}
	}

	public function removeBien($idBien)
	{
		$requete = $this->conn->prepare("DELETE FROM bien_immobilier WHERE code = ".$idBien.";");

		if(!$requete->execute())
		{
			die("Erreur dans supprimer Bien Immobilier : ".$requete->errorCode());
		}
	}

	private function specialCase($stringQuery,$uneTable)
		{
			$uneTable = strtoupper($uneTable);
			switch ($uneTable) {
				case 'PERSONNE':
					$stringQuery.='PERSONNE ORDER BY pers_id';
					break;
				case 'BIEN_IMMOBILIER':
					$stringQuery.='BIEN_IMMOBILIER ORDER BY code';
					break;
				default:
					die('Pas une table valide');
					break;
			}
			return $stringQuery;

		}

		private function donneProchainIdentifiant($uneTable,$unIdentifiant)
			{
				//$prochainId[0]=0;
				//définition de la requête SQL
				$stringQuery = $this->specialCase("SELECT * FROM ",$uneTable);
				$requete = $this->conn->prepare($stringQuery);
				$requete->bindValue(1,$unIdentifiant);

				//exécution de la requête SQL
				if($requete->execute())
				{
					$nbT=0;
					//Retourne le prochain identifiant
					while($row = $requete->fetch(PDO::FETCH_NUM))
					{

						$nbT = $row[0];
					}
					return $nbT+1;
				}
				else
				{
					die('Erreur sur donneProchainIdentifiant : '+$requete->errorCode());
				}
			}
		
	}


?>