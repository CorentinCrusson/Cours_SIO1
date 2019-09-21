<div class="centrePage">
	<FORM action="index.php?vue=persMorale&action=enregistrer" method="POST">

	<TABLE>
		<TR>
			<TD>
				Saisie de la Personne Morale
			</TD>
			<TABLE> <BR>
					<TR>
							<TH> Raison Sociale de la Personne </TH>
							<TD><INPUT type = 'text' name = 'raisonSociale'/></TD>
					</TR>
					
					<TR>
							<TH> Forme Juridique de la personne </TH>
							<TD><INPUT type = 'text' name = 'formeJuridique'/></TD>
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