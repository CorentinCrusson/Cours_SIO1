<div class="centrePage">
	<FORM action="index.php?vue=persPhysique&action=enregistrer" method="POST">

	<TABLE>
		<TR>
			<TD>
				Saisie de la Personne Physique
			</TD>
			<TABLE> <BR>
					<TR>
							<TH> Nom de la Personne </TH>
							<TD><INPUT type = 'text' name = 'nomPers'/></TD>
					</TR>
					
					<TR>
							<TH> Prenom de la personne </TH>
							<TD><INPUT type = 'text' name = 'prenomPers'/></TD>
					</TR>
					
					<TR>
							<TH> Adresse de la Personne </TH>
							<TD><INPUT type = 'text' name = 'adresse'/></TD>
					</TR>

					<TR>
							<TH> Telephone de la Personne </TH>
							<TD><INPUT type = 'text' name = 'telephone'/></TD>
					</TR>
			</TABLE>		
		</TR>
		
		<TR>
			<TD colspan = '2' align = 'right'>
				<INPUT type = 'reset' value = 'Annuler'/>
				<INPUT type = 'submit' value = 'Valider'/>
			</TD>
		</TR>
	</TABLE>


	</FORM>

</div>