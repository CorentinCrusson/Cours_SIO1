<div class="centrePage">
<FORM action = 'index.php?vue=bien&action=modification' method = 'post'>
	<TABLE>
		<TR>
			<TD>
				Modification d'un Bien
			</TD>			
			<TABLE> <BR>
		</TR>
		<TR>
				<TH> Nom du Bien à Modifier </TH>
					<TD> 
						<?php
							echo $_SESSION['listeLesBiens'];
						?>
					</TD>
		</TR>
		<TR>			
			<TH> Nouveau Nom du Bien</TH>
				<TD>
					<INPUT type ='text' name ='nomBien'/>
				</TD>
		</TR>
		<TR>
			<TH> Nouvelle Adresse du Bien</TH>
				<TD>
					<INPUT type ='text' name ='adresseBien'/>
				</TD>

		</TR>
		<TR>
			<TH> Nouveau Id du Propriétaire du Bien</TH>
				<TD> 
					<?php 
						echo $_SESSION['listeLesPers'];
					?>
				</TD>
			</TABLE>					
		</TR>		
		
		<TR>
			<TD colspan = '2' align = 'right'>
				<INPUT type="reset" value="Annuler"/>
				<INPUT type = 'submit' value = 'Valider'/>
			</TD>
		</TR>
	</TABLE>
</FORM>
</div>