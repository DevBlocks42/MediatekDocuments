Feature: RechercheLivreTitre

A short summary of the feature

@tag1
Scenario: recherche_livre_titre
	Given Je saisis le début du titre "Cata" dans la barre de recherche
	Then Les informations du livre Catastrophes au brésil s'affichent dans la DataGridView
