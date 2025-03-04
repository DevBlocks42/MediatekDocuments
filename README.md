# Présentation

![MediaTek_Logo](https://github.com/user-attachments/assets/3a034b62-2087-406d-a5d2-8a42d5bb3457)


Cette application C# permet la gestion des documents, livres, dvd, revues et des abonnements d'une médiathèque. Elle repose sur une API écrite en PHP pour le dialogue avec la base de données.
Lien du dépôt original concernant le projet : https://github.com/CNED-SLAM/MediaTekDocuments


# Installation

## Installateur 
Pour installer l'application, télécharger les binaires d'installation dans le dossier "Installateur_MSI_EXE"

Lancer le fichier MSI.

Suivez les étapes classiques d'installation.

Lancez l'application installée.

Note : veillez à choisir un répertoire en racine du disque (comme spécifié par défaut dans l'installateur) Exemple : C:\MediaTek\...
Dans le cas contraire, le fichier logs pourrait ne pas être modifiable par le programme et générer une exception lors de l'exécution.
Si vous souhaitez tout de même installer l'application dans Program Files (x86) vous devrez ajouter les droits en écriture du groupe Utilisateurs sur le fichier logs.txt.

## Sources
Importer le dépôt dans visual studio.
Installer les dépendances requises : newtonsoft.json (NuGet).
Editer le fichier de configuration "App.config" afin de spécifier les bonnes informations de connexion à l'API soit en : 
  - Copiant la configuration générée par l'installateur pour se connecter à l'API distante hébergée sur internet et accessible à l'URL suivante : http://mediatek-documents.atwebpages.com/rest_mediatekdocuments/
  - Spécifier ses propres identifiants de connexion à l'API en cas de test local.

# Gestion des commandes de livres ou dvd 

# Gestion des abonnements de revues

# Authentification des utilisateurs 
