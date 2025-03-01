using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Commande
    /// </summary>
    public class Commande
    {
        public string id { get; }
        public DateTime dateCommande { get; }
        public double montant { get; }
        /// <summary>
        /// Constructeur de l'objet
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dateCommande"></param>
        /// <param name="montant"></param>
        public Commande(string id, DateTime dateCommande, double montant) 
        {
            this.id = id;
            this.dateCommande = dateCommande;   
            this.montant = montant;
        }
    }
}
