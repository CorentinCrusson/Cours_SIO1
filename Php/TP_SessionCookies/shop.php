<?php  
	session_start();

	//Si la session login n'existe pas, on l'instancie
	if (!isset($_SESSION['login']))
	{
		$loginUser = $_POST['login'];
		$_SESSION['login'] = $loginUser;
	}	
	//On Vérifie si le login est égale à admin
	if ($_SESSION['login'] == 'admin')
	{

		//On initialise les cookies si il n'existe pas 
		if(!isset($_COOKIE['nbrArtPanier']))
		{
			setcookie ("nbrArtPanier",0,(time()+3600));
		}
		if(!isset($_COOKIE['art1']))
		{
			setcookie ("art1",0,(time()+3600));
			echo 'coucou'; 
		}
		if(!isset($_COOKIE['art2']))
		{
			setcookie ("art2",0,(time()+3600)); 
		}
		if(!isset($_COOKIE['art3']))
		{
			setcookie ("art3",0,(time()+3600)); 
		}
		if(!isset($_COOKIE['art4']))
		{
			setcookie ("art4",0,(time()+3600)); 
		}

		echo 'Vous êtes maitenant connecté';
		echo '<table border="1">
						   <tr>
						      <td>Produit 1</td>
						      <td>
						      	<a href="ajoutPanier.php?idProd=1"> Ajouter au panier </a>      
						      </td>
						   </tr>
						   <tr>
						   	  <td>Produit 2</td>
						      <td>
						      	<a href="ajoutPanier.php?idProd=2"> Ajouter au panier </a>  	
						      </td>
						   </tr>
						   <tr>
						   	  <td>Produit 3</td>
						      <td>
						      	<a href="ajoutPanier.php?idProd=3"> Ajouter au panier </a>  	
						      </td>
						   </tr>
						   <tr>
						   	  <td>Produit 4</td>
						      <td>
						      	<a href="ajoutPanier.php?idProd=4"> Ajouter au panier </a>  	
						      </td>
						   </tr>								
						</table>';
						echo '<FORM action="panier.php" method="POST">
										<INPUT type="submit" value="Voir mon Panier"/>
								</FORM>';
	}
	else 
	{
		echo 'Session refusée ';
		echo '<FORM action=index.php>
			<INPUT type=submit value="Retourner à l\'accueil"/>
			</FORM>';
		session_destroy();
	}

?>