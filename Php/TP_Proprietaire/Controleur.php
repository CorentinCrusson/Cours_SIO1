<?php
	//Include gestionProprietaire
	include('Modeles/gestionProprietaire.php');

	//La classe
	class Controleur
	{
		//Attributs
		private $monService;

		//Constructeur
		public function __Construct()
		{
			$this->monService = new gestionProprietaire();
		}

		//------------------------------------------------------------------------------------------------------------------------------------------------------------------------- Methode d'affichage ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		public function afficheMenu()
		{
			require('Vues/HabillagePage/menu.php');
		}

		public function afficheEnTete()
		{
			require('Vues/HabillagePage/entete.php');
		}

		public function afficheNews()
		{
			require ('Vues/HabillagePage/news.php');
		}

		//-------------------Affichage de la Page en fonction du choix dans le menu--------------------------------

		public function affichePage($vue,$action)
		{
			switch ($vue) {
				case 'persPhysique':
					$this->vuePersPhysique($action);
					break;
				case 'persMorale':
					$this->vuePersMorale($action);
					break;
				case 'bien':
					$this->vueBien($action);
					break;
			}
		}

		//--------------------------------------------------------------VUE Persone Physique ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		public function vuePersPhysique($action)
		{
			switch($action)
			{
				case 'ajouter':
					$_SESSION['listeLesPersPhysiques'] = $this->monService->lesPersPhysiquesAuFormatHTML("");
					require 'Vues/saisiePersPhysique.php';

					break;

				case 'voir':
					if ($this->monService->donneNbPersPhysiques()==0)
					{
						$message = "Il n'existe pas de personnes physiques";
						$lien = 'index.php?vue=persPhysique&action=ajouter';
						$_SESSION['message'] = $message;
						$_SESSION['lien'] = $lien;
						require 'Vues/erreur.php';
					}
					else
					{
						$_SESSION['lesPersPhysiques'] = $this->monService->listeLesPersPhysiques();
						require 'Vues/voirPersPhysique.php';
					}
					break;

				case 'modifier':
					$_SESSION['listeLesPersPhysiques'] = $this->monService->lesPersPhysiquesAuFormatHTML("");
					require 'Vues/modifPersPhysique.php';

					break;

				case "modification":
					$idPers = $_POST['id'];
					$nomPers = $_POST['nomPers'];
					$prenomPers = $_POST['prenomPers'];
					$adresse = $_POST['adresse'];
					$telephone = $_POST['telephone'];
					
					if (empty($idPers))
					{
						$message = "Veuillez saisir les informations sur la Personne Physique à modifier";
						$lien = 'index.php?vue=persPhysique&action=modifier';
						$_SESSION['message'] = $message;
						$_SESSION['lien'] = $lien;
						require 'Vues/erreur.php';
					}
					else if (strlen($telephone) > 10)
					{
						$message = "Veuillez saisir moins de 10 chiffres sur le numéro de la personne à modifier";
						$lien = 'index.php?vue=persPhysique&action=modifier';
						$_SESSION['message'] = $message;
						$_SESSION['lien'] = $lien;
						require 'Vues/erreur.php';
					}
					else
					{
						$this->monService->modifPersPhysique($idPers, $nomPers, $prenomPers, $adresse, $telephone);
						require 'Vues/enregistrer.php';
					}
					break;

				case 'supprimer':
					$_SESSION['listeLesPersPhysiques'] = $this->monService->lesPersPhysiquesAuFormatHTML("");
					require 'Vues/supprimePersPhysique.php';
					break;

				case "suppresion":
					$idPers = $_POST['id'];
					
					if (empty($idPers))
					{
						$message = "Veuillez saisir les informations sur la personne physique à modifier";
						$lien = 'index.php?vue=persPhysique&action=modifier';
						$_SESSION['message'] = $message;
						$_SESSION['lien'] = $lien;
						require 'Vues/erreur.php';
					}
					else if ($this->monService->donneNbPersPhysiques()==1)
					{
						$message = "Si vous supprimer ce persPhysique, il n'y aura plus de persPhysique dans l'entreprise.";
						$lien = 'index.php?vue=persPhysique&action=supprimer';
						$_SESSION['message'] = $message;
						$_SESSION['lien'] = $lien;
						require 'Vues/erreur.php';
					}
					else
					{
						$this->monService->supprimerPersPhysique($idPers);
						require 'Vues/enregistrer.php';
					}
					break;


				case 'enregistrer':
					$nomPers = $_POST['nomPers'];
					$prenomPers = $_POST['prenomPers'];
					$adresse = $_POST['adresse'];
					$telephone = $_POST['telephone'];

					if (empty($nomPers)||empty($prenomPers)||empty($adresse))
						{
							
							$message = "Veuillez saisir les informations";							
							$lien = 'index.php?vue=persPhysique&action=ajouter';
							$_SESSION['message'] = $message;
							$_SESSION['lien'] = $lien;
							require 'Vues/erreur.php';
						}
					else if (strlen($telephone) > 10)
					{
						$message = "Veuillez saisir moins de 10 chiffres sur le numéro de la personne à enregistrer";
						$lien = 'index.php?vue=persPhysique&action=ajouter';
						$_SESSION['message'] = $message;
						$_SESSION['lien'] = $lien;
						require 'Vues/erreur.php';
					}
					else
						{
							$this->monService->ajouteUnePersPhysique($nomPers,$prenomPers,$adresse, $telephone);
							require 'Vues/enregistrer.php';
							//$_SESSION['Controleur'] = serialize($this);
						}

					break;
			}

		}
		//--------------------------------------------------------------VUE Persone Morale ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		public function vuePersMorale($action)
		{
			switch($action)
			{
				case 'ajouter':
					$_SESSION['listeLesPersMorales'] = $this->monService->lesPersMoralesAuFormatHTML("");
					require 'Vues/saisiePersMorale.php';

					break;

				case 'voir':
					if ($this->monService->donneNbPersMorales()==0)
					{
						$message = "Il n'existe pas de personnes morales";
						$lien = 'index.php?vue=persMorale&action=ajouter';
						$_SESSION['message'] = $message;
						$_SESSION['lien'] = $lien;
						require 'Vues/erreur.php';
					}
					else
					{
						$_SESSION['lesPersMorales'] = $this->monService->listeLesPersMorales();
						require 'Vues/voirPersMorale.php';
					}
					break;

				case 'modifier':
					$_SESSION['listeLesPersMorales'] = $this->monService->lesPersMoralesAuFormatHTML("");
					require 'Vues/modifPersMorale.php';

					break;

				case "modification":
					$idPers = $_POST['id'];
					$raisonSociale = $_POST['raisonSociale'];
					$formeJuridique = $_POST['formeJuridique'];
					$adresse = $_POST['adresse'];
					$telephone = $_POST['telephone'];
					
					if (empty($idPers))
					{
						$message = "Veuillez saisir les informations sur la Personne Morale à modifier";
						$lien = 'index.php?vue=persMorale&action=modifier';
						$_SESSION['message'] = $message;
						$_SESSION['lien'] = $lien;
						require 'Vues/erreur.php';
					}
					else if (strlen($telephone) > 10)
					{
						$message = "Veuillez saisir moins de 10 chiffres sur le numéro de la personne à modifier";
						$lien = 'index.php?vue=persMorale&action=modifier';
						$_SESSION['message'] = $message;
						$_SESSION['lien'] = $lien;
						require 'Vues/erreur.php';
					}
					else
					{
						$this->monService->modifPersMorale($idPers, $raisonSociale, $formeJuridique, $adresse, $telephone);
						require 'Vues/enregistrer.php';
					}
					break;

				case 'supprimer':
					$_SESSION['listeLesPersMorales'] = $this->monService->lesPersMoralesAuFormatHTML("");
					require 'Vues/supprimePersMorale.php';
					break;

				case "suppresion":
					$idPers = $_POST['id'];
					
					if (empty($idPers))
					{
						$message = "Veuillez saisir les informations sur la personne morale à modifier";
						$lien = 'index.php?vue=persMorale&action=modifier';
						$_SESSION['message'] = $message;
						$_SESSION['lien'] = $lien;
						require 'Vues/erreur.php';
					}					
					else if ($this->monService->donneNbPersMorales()==1)
					{
						$message = "Si vous supprimer cette Personne Morale, il n'y aura plus de personnes Morales dans l'entreprise.";
						$lien = 'index.php?vue=persMorale&action=supprimer';
						$_SESSION['message'] = $message;
						$_SESSION['lien'] = $lien;
						require 'Vues/erreur.php';
					}
					else
					{
						$this->monService->supprimerPersMorale($idPers);
						require 'Vues/enregistrer.php';
					}
					break;


				case 'enregistrer':
					$raisonSociale = $_POST['raisonSociale'];
					$formeJuridique = $_POST['formeJuridique'];
					$adresse = $_POST['adresse'];
					$telephone = $_POST['telephone'];

					if (empty($raisonSociale)||empty($formeJuridique)||empty($adresse)||empty($telephone))
						{
							
							$message = "Veuillez saisir les informations";							
							$lien = 'index.php?vue=persPhysique&action=ajouter';
							$_SESSION['message'] = $message;
							$_SESSION['lien'] = $lien;
							require 'Vues/erreur.php';
						}
					else if (strlen($telephone) > 10)
					{
						$message = "Veuillez saisir moins de 10 chiffres sur le numéro de la personne à enregistrer";
						$lien = 'index.php?vue=persMorale&action=ajouter';
						$_SESSION['message'] = $message;
						$_SESSION['lien'] = $lien;
						require 'Vues/erreur.php';
					}
					else
						{
							$this->monService->ajouteUnePersMorale($raisonSociale,$formeJuridique,$adresse, $telephone);
							require 'Vues/enregistrer.php';
							//$_SESSION['Controleur'] = serialize($this);
						}

					break;
			}

		}

		//--------------------------------------------------------------VUE BIEN----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

		public function vueBien($action)
		{
			switch($action)
			{
				case 'ajouter':
					$_SESSION['listeLesPers'] = $this->monService->lesPersPhysiquesAuFormatHTML("bien").$this->monService->lesPersMoralesAuFormatHTML("bien");		
					require ('Vues/saisieBien.php');

					break;

				case 'voir':
					if ($this->monService->donneNbBiens()==0)
						{
							$message = "Il n'existe pas de biens";
							$lien = 'index.php?vue=bien&action=ajouter';
							$_SESSION['message'] = $message;
							$_SESSION['lien'] = $lien;
						} 
					else
						{
							$_SESSION['lesBiens'] = $this->monService->listeLesBiens();
							require 'Vues/voirBien.php';
						}
					break;

				case 'modifier':			
					$_SESSION['listeLesPers'] = $this->monService->lesPersPhysiquesAuFormatHTML("bien").$this->monService->lesPersMoralesAuFormatHTML("bien");				
					$_SESSION['listeLesBiens'] = $this->monService->lesBiensAuFormatHTML();
					require 'Vues/modifBien.php';
					break;

				case "modification":
					$idBien = $_POST['code'];
					$nom = $_POST['nomBien'];
					$adresse = $_POST['adresseBien'];
					$idProprio = $_POST['id'];

					if (empty($idBien))
					{
						$message = "Veuillez saisir les informations sur le Bien à modifier";
						$lien = 'index.php?vue=bien&action=modifier';
						$_SESSION['message'] = $message;
						$_SESSION['lien'] = $lien;
						require 'Vues/erreur.php';
					}					
					else
					{
						$this->monService->modifBien($idBien, $nom, $adresse, $idProprio);
						require 'Vues/enregistrer.php';
					}
					break;

				case 'supprimer':
					$_SESSION['listeLesBiens'] = $this->monService->lesBiensAuFormatHTML();
					require 'Vues/supprimeBien.php';

					break;

				case "suppresion":
					$idBien = $_POST['code'];
					if (empty($idBien))
					{
						$message = "Veuillez saisir les informations sur le bien à supprimer";
						$lien = 'index.php?vue=bien&action=supprimer';
						$_SESSION['message'] = $message;
						$_SESSION['lien'] = $lien;
						require 'Vues/erreur.php';
					}
					else if ($this->monService->donneNbBiens()==1)
					{
						$message = "Si vous supprimer ce bien, il n'y aura plus de biens immobiliers.";
						$lien = 'index.php?vue=bien&action=supprimer';
						$_SESSION['message'] = $message;
						$_SESSION['lien'] = $lien;
						require 'Vues/erreur.php';
					}
					else
					{
						$this->monService->supprimerBien($idBien);
						require 'Vues/enregistrer.php';
					}
					break;

				case 'enregistrer':
					$nom = $_POST['nomBien'];
					$adresse = $_POST['adresseBien'];
					$idProprio = $_POST['id'];

					if (empty($nom) || empty($adresse))
						{
							
							$message = "Veuillez saisir les informations";
							$lien = 'index.php?vue=bien&action=ajouter';
							$_SESSION['message'] = $message;
							$_SESSION['lien'] = $lien;
							require 'Vues/erreur.php';
						}
					else
						{
							$this->monService->ajouteUnBien($nom, $adresse, $idProprio);
							require 'Vues/enregistrer.php';
							//$_SESSION['Controleur'] = serialize($this);
						}

					break;
			}


		}

	}


?>