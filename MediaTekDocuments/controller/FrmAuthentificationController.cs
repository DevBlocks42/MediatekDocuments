using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTekDocuments.dal;
using MediaTekDocuments.model;

namespace MediaTekDocuments.controller
{
    public class FrmAuthentificationController
    {
        private readonly Access access;
        public FrmAuthentificationController()
        {
            access = Access.GetInstance();  
        }
        public Utilisateur getUserInfos(string login)
        {
            return access.getUserInfos(login);
        }
    }
}
