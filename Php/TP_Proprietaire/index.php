<?php
include "Controleur.php";

	if (!isset($_SESSION['Controleur']))
	{
		$monControleur = new Controleur();
		$_SESSION['Controleur'] = $monControleur;
		session_start();
	}
	else
	{
		$monControleur = $_SESSION['Controleur'];
	}
	//Affichage du menu
	$monControleur->afficheMenu();

	//Affichage En-Tête
	$monControleur->afficheEnTete();
	
	//AFFICHAGE DE LA VUE
	if ((isset($_GET['vue']))&& (isset($_GET['action'])))
		$monControleur->affichePage($_GET['vue'],$_GET['action']);
	else
		$monControleur->afficheNews();
?>
<html>
	<head>
		<title>
			Salarie
		</title>
		<meta http-equiv="content-type" content="text/html" charset=UTF-8" />
		<LINK rel=STYLESHEET href="styleProprietaire.css" type="text/css"/>
	</head>
</html>