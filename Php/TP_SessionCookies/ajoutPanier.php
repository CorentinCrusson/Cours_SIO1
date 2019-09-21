<?php
	session_start();

	//Si l'on souhaite ajouter un produit au panier
	if (isset($_GET['idProd']))
	{
		$idArticle = $_GET['idProd'];
		switch($idArticle)
		{
			case 1:
				setcookie ("nbrArtPanier", $_COOKIE['nbrArtPanier']+1,(time()+3600));
				setcookie ("art1", $_COOKIE['art1']+1,(time()+3600));
				break;

			case 2:
				setcookie ("nbrArtPanier", $_COOKIE['nbrArtPanier']+1,(time()+3600));
				setcookie ("art2", $_COOKIE['art2']+1,(time()+3600));
				break;

			case 3:
				setcookie ("nbrArtPanier", $_COOKIE['nbrArtPanier']+1,(time()+3600));
				setcookie ("art3", $_COOKIE['art3']+1,(time()+3600));
				break;

			case 4:
				setcookie ("nbrArtPanier", $_COOKIE['nbrArtPanier']+1,(time()+3600));
				setcookie ("art4", $_COOKIE['art4']+1,(time()+3600));
				break;
		}
		echo 'Le Produit '.$idArticle. ' a été ajouté au panier';	
?>
		<FORM action="shop.php">
			<input type="submit" value='Retour à la page précédente'/>
		</FORM>
<?php 
	}
	//Si l'on souhaite supprimer un produit au panier
	else if(isset($_GET['idSuppr']))
	{
		$idArticleSuppr = $_GET['idSuppr'];
		switch($idArticleSuppr)
		{
			case 1:
				setcookie ("nbrArtPanier", $_COOKIE['nbrArtPanier']-1,(time()+3600));
				setcookie ("art1", $_COOKIE['art1']-1,(time()+3600));
				break;

			case 2:
				setcookie ("nbrArtPanier", $_COOKIE['nbrArtPanier']-1,(time()+3600));
				setcookie ("art2", $_COOKIE['art2']-1,(time()+3600));
				break;

			case 3:
				setcookie ("nbrArtPanier", $_COOKIE['nbrArtPanier']-1,(time()+3600));
				setcookie ("art3", $_COOKIE['art3']-1,(time()+3600));
				break;

			case 4:
				setcookie ("nbrArtPanier", $_COOKIE['nbrArtPanier']-1,(time()+3600));
				setcookie ("art4", $_COOKIE['art4']-1,(time()+3600));
				break;
		}
		echo 'Le Produit '.$idArticleSuppr. ' a été supprimé du panier';
		echo '<FORM action="panier.php">
			<input type="submit" value="Retour à votre panier"/>
		</FORM>';
	}

?>
		
