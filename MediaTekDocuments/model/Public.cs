﻿
namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Public (public concerné par le document) hérite de Categorie
    /// </summary>
    public class Public : Categorie
    {
        /// <summary>
        /// Constructeur de l'objet
        /// </summary>
        /// <param name="id"></param>
        /// <param name="libelle"></param>
        public Public(string id, string libelle) : base(id, libelle)
        {
        }

    }
}
