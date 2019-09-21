<div class="centrePage">
<FORM action="index.php?vue=bien&action=enregistrer" method="POST">
	<TABLE>
		<TR>
			<TD>
				Saisie du Bien
			</TD>
			<TABLE> <BR>
					<TR>
							<TH> Nom du Bien </TH>
							<TD><INPUT type = 'text' name = 'nomBien'/></TD>
					</TR>
					<TR>
							<TH> Adresse du Bien </TH>
							<TD><INPUT type = 'text' name = 'adresseBien'/></TD>
					</TR>
					<TR>
							<TH> Id du Proprietaire </TH>
							<TD><?php 
									echo $_SESSION['listeLesPers'];
								?>								
							</TD>
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