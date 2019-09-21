<?php	
	session_start();
?>
<!DOCTYPE html>
<html>
<head>
	<title>Accueil</title>
</head>
<body>
	<FORM action="shop.php" method=POST>
		
		<label>  Identifiant :  </label>
		<INPUT type="text" name=login></INPUT>
		<BR><BR>
		<INPUT type="reset" value='annuler'>
		<INPUT type="submit" value='valider'>
	</FORM>
</body>
</html>