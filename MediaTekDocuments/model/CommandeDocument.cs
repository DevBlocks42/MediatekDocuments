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
        public string idLivreDvd { get; }
        public int idSuivi { get; }
        public int nbExemplaire { get; }

        public CommandeDocument(string id, DateTime dateCommande, double montant, string idLivreDvd, int idSuivi, int nbExemplaire) : base(id, dateCommande, montant)
        {
            this.idLivreDvd = idLivreDvd;
            this.idSuivi = idSuivi;
            this.nbExemplaire = nbExemplaire;
        }
    }
}
