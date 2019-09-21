<div class="centrePage">
<FORM action = 'index.php?vue=persPhysique&action=suppresion' method = 'post'>
	<TABLE>
		<TR>
			<TD>
				Suppresion d'une Personne Physique
			</TD>			
			<TABLE> <BR>
			
				<TH> Nom de la Personne Physique à Supprimer </TH>
					<TD> 
						<?php
							echo $_SESSION['listeLesPersPhysiques'];
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