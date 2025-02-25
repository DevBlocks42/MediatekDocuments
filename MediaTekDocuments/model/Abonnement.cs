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
        public Abonnement(string id, DateTime dateCommande, double montant, DateTime dateFinAbonnement, string idRevue) : base(id, dateCommande, montant)
        {
            this.DateFinAbonnement = dateFinAbonnement; 
            this.IdRevue = idRevue; 
        }
    }
}
