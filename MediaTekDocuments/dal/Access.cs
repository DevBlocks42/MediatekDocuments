using System;
using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.manager;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Linq;
using System.Xml.Linq;
using System.Globalization;

namespace MediaTekDocuments.dal
{
    /// <summary>
    /// Classe d'accès aux données
    /// </summary>
    public class Access
    {
        /// <summary>
        /// adresse de l'API
        /// </summary>
        private static readonly string uriApi = "http://localhost/rest_mediatekdocuments/";
        /// <summary>
        /// instance unique de la classe
        /// </summary>
        private static Access instance = null;
        /// <summary>
        /// instance de ApiRest pour envoyer des demandes vers l'api et recevoir la réponse
        /// </summary>
        private readonly ApiRest api = null;
        /// <summary>
        /// méthode HTTP pour select
        /// </summary>
        private const string GET = "GET";
        /// <summary>
        /// méthode HTTP pour insert
        /// </summary>
        private const string POST = "POST";
        /// <summary>
        /// méthode HTTP pour delete
        /// </summary>
        private const string DELETE = "DELETE"; 
        /// <summary>
        /// méthode HTTP pour update
        /// </summary>
        private const string PUT = "PUT";   
        /// Méthode privée pour créer un singleton
        /// initialise l'accès à l'API
        /// </summary>
        private Access()
        {
            String authenticationString;
            try
            {
                authenticationString = ConfigurationManager.ConnectionStrings["access"].ConnectionString;
                api = ApiRest.GetInstance(uriApi, authenticationString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }
        /// <summary>
        /// Création et retour de l'instance unique de la classe
        /// </summary>
        /// <returns>instance unique de la classe</returns>
        public static Access GetInstance()
        {
            if(instance == null)
            {
                instance = new Access();
            }
            return instance;
        }
        /// <summary>
        /// Retourne tous les genres à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Genre</returns>
        public List<Categorie> GetAllGenres()
        {
            IEnumerable<Genre> lesGenres = TraitementRecup<Genre>(GET, "genre", null);
            return new List<Categorie>(lesGenres);
        }
        /// <summary>
        /// Retourne tous les rayons à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Rayon</returns>
        public List<Categorie> GetAllRayons()
        {
            IEnumerable<Rayon> lesRayons = TraitementRecup<Rayon>(GET, "rayon", null);
            return new List<Categorie>(lesRayons);
        }
        /// <summary>
        /// Retourne toutes les catégories de public à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Public</returns>
        public List<Categorie> GetAllPublics()
        {
            IEnumerable<Public> lesPublics = TraitementRecup<Public>(GET, "public", null);
            return new List<Categorie>(lesPublics);
        }
        /// <summary>
        /// Retourne toutes les livres à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public List<Livre> GetAllLivres()
        {
            List<Livre> lesLivres = TraitementRecup<Livre>(GET, "livre", null);
            return lesLivres;
        }
        /// <summary>
        /// Retourne toutes les dvd à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Dvd</returns>
        public List<Dvd> GetAllDvd()
        {
            List<Dvd> lesDvd = TraitementRecup<Dvd>(GET, "dvd", null);
            return lesDvd;
        }
        /// <summary>
        /// Retourne toutes les revues à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Revue</returns>
        public List<Revue> GetAllRevues()
        {
            List<Revue> lesRevues = TraitementRecup<Revue>(GET, "revue", null);
            return lesRevues;
        }
        /// <summary>
        /// Retourne les exemplaires d'une revue
        /// </summary>
        /// <param name="idDocument">id de la revue concernée</param>
        /// <returns>Liste d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocument)
        {
            String jsonIdDocument = ConvertToJson("id", idDocument);
            List<Exemplaire> lesExemplaires = TraitementRecup<Exemplaire>(GET, "exemplaire/" + jsonIdDocument, null);
            return lesExemplaires;
        }
        /// <summary>
        /// Retourne les commandes d'un livre
        /// </summary>
        /// <param name="idLivre">id du livre concerné</param>
        /// <returns>Liste d'objets CommandeDocument</returns>
        public List<CommandeDocument> GetCommandesLivre(string idLivre)
        {
            String jsonIdLivre = ConvertToJson("idLivreDvd", idLivre);
            List<CommandeDocument> lesCommandes = TraitementRecup<CommandeDocument>(GET, "commandes/" + jsonIdLivre, null);
            return lesCommandes;
        }
        public List<Abonnement> GetAbonnementsRevue(string idRevue)
        {
            String jsonIdRevue = ConvertToJson("idRevue", idRevue);
            try { 
                List<Abonnement> lesAbonnements = TraitementRecup<Abonnement>(GET, "abonnements/" + jsonIdRevue, null);
                return lesAbonnements;
            } catch(Exception e) {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public List<Suivi> GetSuivis()
        {
            List<Suivi> lesSuivis = TraitementRecup<Suivi>(GET, "suivi", null);
            return lesSuivis;
        }
        /// <summary>
        /// Supprime une commande de la table commandedocument
        /// </summary>
        /// <param name="idCommande">numéro de commande</param>
        /// <returns></returns>
        public bool SupprimerCommande(string idCommande)
        {
            Object jsonId = ConvertToJson("id", idCommande);    
            try {
                Console.WriteLine(jsonId);
                TraitementRecup<CommandeDocument>(DELETE, "commandedocument/" + jsonId, null);
                return true;
            } catch (Exception ex) {
                Console.WriteLine(ex);
                return false;
            }
        }
        /// <summary>
        /// Supprime un abonnement
        /// </summary>
        /// <param name="idAbonnement"></param>
        /// <returns></returns>
        public bool SupprimerAbonnement(string idAbonnement)
        {
            Object jsonId = ConvertToJson("id", idAbonnement);
            try { 
                TraitementRecup<CommandeDocument>(DELETE, "abonnement/" + jsonId, null);
                return true;
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public List<Abonnement> GetAbonnementsExpirationProche()
        {
            List<Abonnement> abos = new List<Abonnement> ();    
            DateTime maxDate = DateTime.Today;
            maxDate = maxDate.AddDays(30);
            string jsonMaxDate = ConvertToJson("maxDate", maxDate.ToString("yyyy-MM-dd"));
            Console.WriteLine(jsonMaxDate); 
            try { 
                abos = TraitementRecup<Abonnement>(GET, "abonnements_30jours/" +jsonMaxDate, null);
            } catch(Exception ex) {
                Console.WriteLine(ex); 
            }
            return abos;
        }
        /// <summary>
        /// Modifie l'état de suivi d'une commande avec l'état selectionné
        /// </summary>
        /// <param name="idCommande"></param>
        /// <param name="idSuivi"></param>
        /// <returns></returns>
        public bool ModifierSuiviCommande(string idCommande, int idSuivi) 
        {
            string jsonIdSuivi = ConvertToJson("idSuivi", idSuivi);
            Console.WriteLine(jsonIdSuivi);
            try { 
                TraitementRecup<CommandeDocument>(PUT, "commandedocument/" + idCommande, "champs=" + jsonIdSuivi);
                return true;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Enregistre une nouvelle commande de livre dans la base de données
        /// </summary>
        /// <param name="montant"></param>
        /// <param name="idLivre"></param>
        /// <param name="nbExemplaire"></param>
        /// <returns>true si l'insertion s'est bien passée, false sinon</returns>
        public bool EnregistrerNouvelleCommande(double montant, string idLivre, int nbExemplaire)
        {
            #pragma warning disable IDE0028
            Dictionary<Object, Object> parametres = new Dictionary<Object, Object>();
            #pragma warning restore IDE0028
            parametres.Add("dateCommande", DateTime.Now.ToString("yyyy-MM-dd"));
            parametres.Add("montant", montant);
            parametres.Add("idSuivi", 1);
            parametres.Add("idLivreDvd", idLivre);
            parametres.Add("nbExemplaire", nbExemplaire);
            string jsonArray = ConvertToJsonArray(parametres);
            try {
                TraitementRecup<Commande>(POST, "insert_commande", "champs=" + jsonArray);
                return true;
            } catch { 
                return false; 
            }
        }
        public bool EnregistrerAbonnement(double montant, string idRevue, DateTime dateFinAbonnement)
        {
            #pragma warning disable IDE0028
            Dictionary<Object, Object> parametres = new Dictionary<Object, Object>();
            #pragma warning restore IDE0028
            parametres.Add("dateCommande", DateTime.Now.ToString("yyyy-MM-dd"));
            parametres.Add("montant", montant);
            parametres.Add("DateFinAbonnement", dateFinAbonnement.ToString("yyyy-MM-dd"));
            parametres.Add("IdRevue", idRevue);
            string jsonArray = ConvertToJsonArray(parametres);
            try {
                TraitementRecup<Abonnement>(POST, "insert_abonnement", "champs=" + jsonArray);
                return true;
            } catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        /// <summary>
        /// ecriture d'un exemplaire en base de données
        /// </summary>
        /// <param name="exemplaire">exemplaire à insérer</param>
        /// <returns>true si l'insertion a pu se faire (retour != null)</returns>
        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            String jsonExemplaire = JsonConvert.SerializeObject(exemplaire, new CustomDateTimeConverter());
            try {
                List<Exemplaire> liste = TraitementRecup<Exemplaire>(POST, "exemplaire", "champs=" + jsonExemplaire);
                return (liste != null);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public Utilisateur GetUserInfos(string login)
        {
            if(login.Length <= 0 || login == null) {
                return null;
            }
            List<Utilisateur> utilisateur;
            try {
                string jsonLogin = ConvertToJson("login", login);
                utilisateur = TraitementRecup<Utilisateur>(GET, "utilisateur/" + jsonLogin, null);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
            if(utilisateur.Count > 0) { 
                return utilisateur[0];
            } else {
                return null;
            }
        }
        /// <summary>
        /// Traitement de la récupération du retour de l'api, avec conversion du json en liste pour les select (GET)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="methode">verbe HTTP (GET, POST, PUT, DELETE)</param>
        /// <param name="message">information envoyée dans l'url</param>
        /// <param name="parametres">paramètres à envoyer dans le body, au format "chp1=val1&chp2=val2&..."</param>
        /// <returns>liste d'objets récupérés (ou liste vide)</returns>
        private List<T> TraitementRecup<T> (String methode, String message, String parametres)
        {
            // trans
            List<T> liste = new List<T>();
            try
            {
                JObject retour = api.RecupDistant(methode, message, parametres);
                // extraction du code retourné
                String code = (String)retour["code"];
                if (code.Equals("200"))
                {
                    // dans le cas du GET (select), récupération de la liste d'objets
                    if (methode.Equals(GET))
                    {
                        String resultString = JsonConvert.SerializeObject(retour["result"]);
                        // construction de la liste d'objets à partir du retour de l'api
                        liste = JsonConvert.DeserializeObject<List<T>>(resultString, new CustomBooleanJsonConverter());
                    }
                }
                else
                {
                    Console.WriteLine("code erreur = " + code + " message = " + (String)retour["message"]);
                }
            }catch(Exception e)
            {
                Console.WriteLine("Erreur lors de l'accès à l'API : "+e.Message);
                Environment.Exit(0);
            }
            return liste;
        }
        /// <summary>
        /// Convertit en json un couple nom/valeur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="valeur"></param>
        /// <returns>couple au format json</returns>
        private static String ConvertToJson(Object nom, Object valeur)
        {
            #pragma warning disable IDE0028
            Dictionary<Object, Object> dictionary = new Dictionary<Object, Object>();
            #pragma warning restore IDE0028
            dictionary.Add(nom, valeur);
            return JsonConvert.SerializeObject(dictionary);
        }
        /// <summary>
        /// Convertit une liste(dictionnaire) de couple nom/valeur au format JSON
        /// </summary>
        /// <param name="nomsValeurs"></param>
        /// <returns></returns>
        private static String ConvertToJsonArray(Dictionary<Object, Object> nomsValeurs)
        {
            Dictionary<Object, Object> dictionary = new Dictionary<Object, Object>();
            foreach (var ligne in nomsValeurs)
            {
                dictionary.Add(ligne.Key, ligne.Value);
            }
            return JsonConvert.SerializeObject(dictionary);
        }
        /// <summary>
        /// Modification du convertisseur Json pour gérer le format de date
        /// </summary>
        private sealed class CustomDateTimeConverter : IsoDateTimeConverter
        {
            public CustomDateTimeConverter()
            {
                base.DateTimeFormat = "yyyy-MM-dd";
            }
        }
        /// <summary>
        /// Modification du convertisseur Json pour prendre en compte les booléens
        /// classe trouvée sur le site :
        /// https://www.thecodebuzz.com/newtonsoft-jsonreaderexception-could-not-convert-string-to-boolean/
        /// </summary>
        private sealed class CustomBooleanJsonConverter : JsonConverter<bool>
        {
            public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                return Convert.ToBoolean(reader.ValueType == typeof(string) ? Convert.ToByte(reader.Value) : reader.Value);
            }
            public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }
        }
    }
}
