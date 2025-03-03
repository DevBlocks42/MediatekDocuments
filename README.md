# Installation

## Installateur 
Pour installer l'application, télécharger les binaires d'installation dans le dossier "Installateur_MSI_EXE"
Lancer le fichier MSI.
Suivez les étapes classiques d'installation.
Lancez l'application installée.
Note : veillez à choisir un répertoire en racine du disque (comme spécifié par défaut dans l'installateur) Exemple : C:\MediaTek\...
Dans le cas contraire, le fichier logs pourrait ne pas être modifiable par le programme et générer une exception lors de l'exécution.

## Sources
Importer le dépôt dans visual studio.
Installer les dépendances requises : newtonsoft.json (NuGet).
Editer le fichier de configuration "App.config" afin de spécifier les bonnes informations de connexion à l'API : 
  - Copier la configuration générée par l'installateur
  - Spécifier ses propres identifiants de connexion à l'API en cas de test local.

# Gestion des commandes de livres ou dvd 

# Gestion des abonnements de revues

# Authentification des utilisateurs 
