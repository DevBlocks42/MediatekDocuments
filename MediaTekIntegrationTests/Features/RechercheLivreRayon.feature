Feature: RechercheLivreRayon

A short summary of the feature

@tag1
Scenario: recherche_livre_rayon
	Given Je sélectionne le type de rayon "Jeunesse BD" dans le CBX
	Then On observe le seul livre présent dans la DGV nommé "Sacré Pêre Noël"
