using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }  
        public int Id_service { get; set; }
        public string Pwd_hash { get; set; }    
        /// <summary>
        /// Constructeur de l'objet.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="id_service"></param>
        /// <param name="pwd_hash"></param>
        public Utilisateur(int id, string nom, string prenom, int id_service, string pwd_hash)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Id_service = id_service;
            this.Pwd_hash = pwd_hash;
        }  
    }
}
