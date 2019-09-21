<div class="centrePage">
<FORM action = 'index.php?vue=persPhysique&action=modification' method = 'post'>
	<TABLE>
		<TR>
			<TD>
				Modification d'une Personne Physique
			</TD>

		<TABLE> <BR>
				
				<TH> Nom de la Personne Physique à Modifier </TH>
					<TD> 
						<?php
							echo $_SESSION['listeLesPersPhysiques'];
						?>
					</TD>	
		</TR>		
			<TR>
				<TH> Le Nouveau Nom de la Personne Physique </TH>
				<TD>
					<INPUT type ='text' name ='nomPers'/>
				</TD>
			</TR>
			<TR>
				<TH> Le Nouveau Prénom de la Personne Physique </TH>
				<TD>
					<INPUT type ='text' name ='prenomPers'/>
				</TD>		
			</TR>
			<TR>
				<TH> La Nouvelle Adresse de la Personne Physique </TH>
				<TD>
					<INPUT type ='text' name ='adresse'/>
				</TD>		
			</TR>
			<TR>
				<TH> Le Nouveau Téléphone de la Personne Physique </TH>
				<TD>
					<INPUT type ='text' name ='telephone'/>
				</TD>		
			</TR>
			<TR>
				
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