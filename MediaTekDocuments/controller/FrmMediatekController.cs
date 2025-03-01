using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.dal;
using System;

namespace MediaTekDocuments.controller
{
    /// <summary>
    /// Contrôleur lié à FrmMediatek
    /// </summary>
    class FrmMediatekController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;
        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmMediatekController()
        {
            access = Access.GetInstance();
        }
        /// <summary>
        /// getter sur la liste des genres
        /// </summary>
        /// <returns>Liste d'objets Genre</returns>
        public List<Categorie> GetAllGenres()
        {
            return access.GetAllGenres();
        }
        /// <summary>
        /// getter sur la liste des livres
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public List<Livre> GetAllLivres()
        {
            return access.GetAllLivres();
        }
        /// <summary>
        /// getter sur la liste des Dvd
        /// </summary>
        /// <returns>Liste d'objets dvd</returns>
        public List<Dvd> GetAllDvd()
        {
            return access.GetAllDvd();
        }
        /// <summary>
        /// getter sur la liste des revues
        /// </summary>
        /// <returns>Liste d'objets Revue</returns>
        public List<Revue> GetAllRevues()
        {
            return access.GetAllRevues();
        }

        /// <summary>
        /// getter sur les rayons
        /// </summary>
        /// <returns>Liste d'objets Rayon</returns>
        public List<Categorie> GetAllRayons()
        {
            return access.GetAllRayons();
        }
        /// <summary>
        /// getter sur les publics
        /// </summary>
        /// <returns>Liste d'objets Public</returns>
        public List<Categorie> GetAllPublics()
        {
            return access.GetAllPublics();
        }
        /// <summary>
        /// récupère les exemplaires d'une revue
        /// </summary>
        /// <param name="idDocuement">id de la revue concernée</param>
        /// <returns>Liste d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocuement)
        {
            return access.GetExemplairesRevue(idDocuement);
        }
        /// <summary>
        /// Récupère les commandes associées à un livre
        /// </summary>
        /// <param name="idLivre"></param>
        /// <returns>List<CommandeDocument></returns>
        public List<CommandeDocument> GetCommandesLivre(string idLivre)
        {
            return access.GetCommandesLivre(idLivre);
        }
        /// <summary>
        /// Getter sur les abonnements d'une revue
        /// </summary>
        /// <param name="idRevue"></param>
        /// <returns></returns>
        public List<Abonnement> GetAbonnementsRevue(string idRevue)
        {
            return access.GetAbonnementsRevue(idRevue);
        }
        /// <summary>
        /// Getter sur les abonnements qui expirent bientôt.
        /// </summary>
        /// <returns></returns>
        public List<Abonnement> GetAbonnementsExpirationProche()
        {
            return access.GetAbonnementsExpirationProche();
        }
        /// <summary>
        /// Supprime une commande
        /// </summary>
        /// <param name="idCommande"></param>
        /// <returns></returns>
        public bool SupprimerCommande(string idCommande)
        {
            return access.SupprimerCommande(idCommande);
        }
        /// <summary>
        /// Supprime un abonnement
        /// </summary>
        /// <param name="idAbonnement"></param>
        /// <returns></returns>
        public bool SupprimerAbonnement(string idAbonnement)
        {
            return access.SupprimerAbonnement(idAbonnement);
        }
        /// <summary>
        /// Enregistre une nouvelle commande de livre dans la base de données
        /// </summary>
        /// <param name="montant"></param>
        /// <param name="idLivre"></param>
        /// <param name="nbExemplaire"></param>
        /// <returns>bool</returns>
        public bool EnregistrerNouvelleCommande(double montant, string idLivre, int nbExemplaire)
        {
            return access.EnregistrerNouvelleCommande(montant, idLivre, nbExemplaire);
        }
        /// <summary>
        /// Modifier le suivi d'une commande
        /// </summary>
        /// <param name="idCommande"></param>
        /// <param name="idSuivi"></param>
        /// <returns></returns>
        public bool ModifierSuiviCommande(string idCommande, int idSuivi)
        {
            return access.ModifierSuiviCommande(idCommande, idSuivi);
        }
        /// <summary>
        /// Enregistre un nouvel abonnement
        /// </summary>
        /// <param name="montant"></param>
        /// <param name="idRevue"></param>
        /// <param name="dateFinAbonnement"></param>
        /// <returns></returns>
        public bool EnregistrerAbonnement(double montant, string idRevue, DateTime dateFinAbonnement)
        {
            return access.EnregistrerAbonnement(montant, idRevue, dateFinAbonnement);
        }
        /// <summary>
        /// Retourne la liste de tous les suivis possibles
        /// </summary>
        /// <returns>Liste d'objets Suivi</returns>
        public List<Suivi> GetSuivis()
        {
            return access.GetSuivis();
        }
        /// <summary>
        /// Crée un exemplaire d'une revue dans la bdd
        /// </summary>
        /// <param name="exemplaire">L'objet Exemplaire concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            return access.CreerExemplaire(exemplaire);
        }
    }
}
