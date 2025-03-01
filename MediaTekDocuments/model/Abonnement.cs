using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Abonnement, hérite de commande
    /// </summary>
    public class Abonnement : Commande
    { 
        public DateTime DateFinAbonnement { get; set; } 
        public string IdRevue { get; set; }
        /// <summary>
        /// Constructeur de l'objet
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dateCommande"></param>
        /// <param name="montant"></param>
        /// <param name="dateFinAbonnement"></param>
        /// <param name="idRevue"></param>
        public Abonnement(string id, DateTime dateCommande, double montant, DateTime dateFinAbonnement, string idRevue) : base(id, dateCommande, montant)
        {
            this.DateFinAbonnement = dateFinAbonnement; 
            this.IdRevue = idRevue; 
        }
    }
}
