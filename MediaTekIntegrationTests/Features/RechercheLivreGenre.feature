Feature: RechercheLivreGenre

A short summary of the feature

@tag1
Scenario: rechercher_livre_genre
	Given Je sélectionne le genre correspondant à science fiction dans le GroupBox
	Then On observe l'unique livre nommé La Planète des singes dans la DataGridView
