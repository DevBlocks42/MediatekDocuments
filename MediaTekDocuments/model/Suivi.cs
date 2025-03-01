using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier représentant les états de suivi d'une commande
    /// </summary>
    public class Suivi
    {
        public int Id { get; }
        public string Libelle { get; }
        /// <summary>
        /// Constructeur de l'objet
        /// </summary>
        /// <param name="id"></param>
        /// <param name="libelle"></param>
        public Suivi(int id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }
        /// <summary>
        /// Méthode d'affichage de la classe Suivi
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Libelle;
        }
    }
}
