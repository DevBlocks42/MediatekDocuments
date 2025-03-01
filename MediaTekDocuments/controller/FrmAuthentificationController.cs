using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTekDocuments.dal;
using MediaTekDocuments.model;

namespace MediaTekDocuments.controller
{
    /// <summary>
    /// Contrôleur de la vue FrmAuthentification
    /// </summary>
    public class FrmAuthentificationController
    {
        private readonly Access access;
        public FrmAuthentificationController()
        {
            access = Access.GetInstance();  
        }
        /// <summary>
        /// Récupère les informations de l'utilisateur
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public Utilisateur GetUserInfos(string login)
        {
            return access.GetUserInfos(login);
        }
    }
}
