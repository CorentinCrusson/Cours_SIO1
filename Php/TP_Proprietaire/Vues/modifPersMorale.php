<div class="centrePage">
<FORM action = 'index.php?vue=persMorale&action=modification' method = 'post'>
	<TABLE>
		<TR>
			<TD>
				Modification d'une Personne Morale
			</TD>

		<TABLE> <BR>
				
				<TH> Nom de la Personne Morale à Modifier </TH>
					<TD> 
						<?php
							echo $_SESSION['listeLesPersMorales'];
						?>
					</TD>	
		</TR>		
			<TR>
				<TH> La Nouvelle Raison Sociale de la Personne </TH>
				<TD>
					<INPUT type ='text' name ='raisonSociale'/>
				</TD>
			</TR>
			<TR>
				<TH> La Nouvelle Forme Juridique de la Personne </TH>
				<TD>
					<INPUT type ='text' name ='formeJuridique'/>
				</TD>		
			</TR>
			<TR>
				<TH> La Nouvelle Adresse de la Personne </TH>
				<TD>
					<INPUT type ='text' name ='adresse'/>
				</TD>		
			</TR>
			<TR>
				<TH> Le Nouveau Téléphone de la Personne </TH>
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