<?php
	echo 'Votre panier est composé de...';
	echo '<table border="1">';

		for ($j=0;$j<$_COOKIE['art1'];$j++)
		{
			echo '<tr>';

			echo '<td>';
			echo 'Produit 1';
			echo '</td>';

			echo '<td>';
			echo '<a href="ajoutPanier?idSuppr=1"> Supprimer </a>';
			echo '</td>';

			echo '</tr>';
		}
		
		for ($j=0;$j<$_COOKIE['art2'];$j++)
		{
			echo '<tr>';

			echo '<td>';
			echo 'Produit 2';
			echo '</td>';

			echo '<td>';
			echo '<a href="ajoutPanier?idSuppr=2"> Supprimer </a>';
			echo '</td>';

			echo '</tr>';
		}

		for ($j=0;$j<$_COOKIE['art3'];$j++)
		{
			echo '<tr>';

			echo '<td>';
			echo 'Produit 3';
			echo '</td>';

			echo '<td>';
			echo '<a href="ajoutPanier?idSuppr=3"> Supprimer </a>';
			echo '</td>';

			echo '</tr>';	
		}

		for ($j=0;$j<$_COOKIE['art4'];$j++)
		{
			echo '<tr>';

			echo '<td>';
			echo 'Produit 4';
			echo '</td>';

			echo '<td>';
			echo '<a href="ajoutPanier?idSuppr=4"> Supprimer </a>';
			echo '</td>';

			echo '</tr>';	
		}

	echo '</table>';
?>
<BR>
<FORM action="shop.php" method="POST">
	<INPUT type="submit" value="Retour au shop"/>
</FORM>