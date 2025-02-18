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
        public int id { get; }
        public string libelle { get; }

        public Suivi(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
        public override string ToString()
        {
            return libelle;
        }
    }
}
