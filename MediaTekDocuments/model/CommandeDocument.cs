using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier fille de Commande, réprésentant la commande d'un document
    /// </summary>
    public class CommandeDocument : Commande
    {
        public string IdLivreDvd { get; }
        public int IdSuivi { get; }
        public int NbExemplaire { get; }
        /// <summary>
        /// Constructeur de l'objet
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dateCommande"></param>
        /// <param name="montant"></param>
        /// <param name="idLivreDvd"></param>
        /// <param name="idSuivi"></param>
        /// <param name="nbExemplaire"></param>
        public CommandeDocument(string id, DateTime dateCommande, double montant, string idLivreDvd, int idSuivi, int nbExemplaire) : base(id, dateCommande, montant)
        {
            this.IdLivreDvd = idLivreDvd;
            this.IdSuivi = idSuivi;
            this.NbExemplaire = nbExemplaire;
        }
    }
}
