<div class="centrePage">
<FORM action = 'index.php?vue=bien&action=suppresion' method = 'post'>
	<TABLE>
		<TR>
			<TD>
				Suppresion d'un Bien
			</TD>			
			<TABLE> <BR>
			
				<TH> Libelle du Bien à Supprimer </TH>
					<TD> 
						<?php
							echo $_SESSION['listeLesBiens'];
						?>
					</TD>
		</TR>			
			</TABLE>	
		
		<TR>
			<TD colspan = '2' align = 'right'>
				<INPUT type="reset" value="Annuler"/>
				<INPUT type = 'submit' value = 'Valider'/>
			</TD>
		</TR>
	</TABLE>
</FORM>
</div>