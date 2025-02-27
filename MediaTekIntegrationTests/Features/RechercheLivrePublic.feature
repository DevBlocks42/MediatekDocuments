Feature: RechercheLivrePublic

A short summary of the feature

@tag1
Scenario: recherche_livre_public
	Given Je saisis le type de public "Jeunesse" dans le combobox
	Then On observe l'unique livre nommé "Sacré Pêre Noël" dans la DataGridView
