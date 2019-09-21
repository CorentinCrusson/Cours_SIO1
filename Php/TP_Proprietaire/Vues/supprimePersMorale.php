<div class="centrePage">
<FORM action = 'index.php?vue=persMorale&action=suppresion' method = 'post'>
	<TABLE>
		<TR>
			<TD>
				Suppresion d'une Personne Morale
			</TD>			
			<TABLE> <BR>
			
				<TH> Nom de la Personne Morale à Supprimer </TH>
					<TD> 
						<?php
							echo $_SESSION['listeLesPersMorales'];
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