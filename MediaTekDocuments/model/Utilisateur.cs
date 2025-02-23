using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class Utilisateur
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }  
        public int id_service { get; set; }
        public string pwd_hash { get; set; }    
        public Utilisateur(int id, string nom, string prenom, int id_service, string pwd_hash)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.id_service = id_service;
            this.pwd_hash = pwd_hash;
        }  
    }
}
