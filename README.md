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

<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <configSections></configSections>
  <startup>
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
  </startup>
  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <dependentAssembly>
        <assemblyIdentity name="Newtonsoft.Json" publicKeyToken="30ad4fe6b2a6aeed" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-13.0.0.0" newVersion="13.0.0.0" />
      </dependentAssembly>
      <dependentAssembly>
        <assemblyIdentity name="System.Buffers" publicKeyToken="cc7b13ffcd2ddd51" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-4.0.4.0" newVersion="4.0.4.0" />
      </dependentAssembly>
      <dependentAssembly>
        <assemblyIdentity name="System.Runtime.CompilerServices.Unsafe" publicKeyToken="b03f5f7f11d50a3a" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-6.0.1.0" newVersion="6.0.1.0" />
      </dependentAssembly>
      <dependentAssembly>
        <assemblyIdentity name="System.Threading.Tasks.Extensions" publicKeyToken="cc7b13ffcd2ddd51" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-4.2.1.0" newVersion="4.2.1.0" />
      </dependentAssembly>
    </assemblyBinding>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <dependentAssembly>
        <assemblyIdentity name="System.Numerics.Vectors" publicKeyToken="b03f5f7f11d50a3a" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-4.1.5.0" newVersion="4.1.5.0" />
      </dependentAssembly>
    </assemblyBinding>
  </runtime>
  <connectionStrings>
    <clear />
    <add name="access" connectionString="Pour obtenir les identifiants contacter devblocks42@keemail.me" />
    <add name="API_URI" connectionString="http://mediatek-documents.atwebpages.com/rest_mediatekdocuments/" />
    <add name="log_file_location" connectionString="./logs.txt" />
  </connectionStrings>
</configuration>


# Gestion des commandes de livres ou dvd 

# Gestion des abonnements de revues

# Authentification des utilisateurs 
