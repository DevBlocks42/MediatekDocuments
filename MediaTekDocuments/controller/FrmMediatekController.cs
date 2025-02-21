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
        public List<CommandeDocument> getCommandesLivre(string idLivre)
        {
            return access.getCommandesLivre(idLivre);
        }
        public List<Abonnement> getAbonnementsRevue(string idRevue)
        {
            return access.getAbonnementsRevue(idRevue);
        }
        public List<Abonnement> getAbonnementsExpirationProche()
        {
            return access.getAbonnementsExpirationProche();
        }
        /// <summary>
        /// Enregistre une nouvelle commande de livre dans la base de données
        /// </summary>
        /// <param name="montant"></param>
        /// <param name="idLivre"></param>
        /// <param name="nbExemplaire"></param>
        /// <returns>bool</returns>
        public bool supprimerCommande(string idCommande)
        {
            return access.supprimerCommande(idCommande);
        }
        public bool supprimerAbonnement(string idAbonnement)
        {
            return access.supprimerAbonnement(idAbonnement);
        }
        public bool enregistrerNouvelleCommande(double montant, string idLivre, int nbExemplaire)
        {
            return access.enregistrerNouvelleCommande(montant, idLivre, nbExemplaire);
        }
        public bool modifierSuiviCommande(string idCommande, int idSuivi)
        {
            return access.modifierSuiviCommande(idCommande, idSuivi);
        }
        public bool enregistrerAbonnement(double montant, string idRevue, DateTime dateFinAbonnement)
        {
            return access.enregistrerAbonnement(montant, idRevue, dateFinAbonnement);
        }
        /// <summary>
        /// Retourne la liste de tous les suivis possibles
        /// </summary>
        /// <returns>Liste d'objets Suivi</returns>
        public List<Suivi> getSuivis()
        {
            return access.getSuivis();
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
