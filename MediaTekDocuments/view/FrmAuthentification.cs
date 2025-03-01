using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTekDocuments.controller;
using MediaTekDocuments.model;
using MediaTekDocuments.utils;

namespace MediaTekDocuments.view
{
    /// <summary>
    /// Classe d'affichage de la fenêtre d'authentification
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        private readonly FrmAuthentificationController controller;
        public FrmAuthentification()
        {
            InitializeComponent();
            controller = new FrmAuthentificationController();   
        }
        /// <summary>
        /// Méthode événementielle associée au clic sur le bouton de connexion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if(tbxLogin.Text.Length > 0 && tbxPwd.Text.Length > 0) {
                Utilisateur utilisateur = controller.GetUserInfos(tbxLogin.Text);
                if(utilisateur != null) {
                    if(utilisateur.Pwd_hash != "") { 
                        if(CryptoTools.VerifyPassword(tbxPwd.Text, utilisateur.Pwd_hash)) {
                            MessageBox.Show("Authentification réussie");
                            FrmMediatek frm = new FrmMediatek(utilisateur);
                            this.Hide();
                            frm.ShowDialog();
                            this.Close(); 
                         
                        } else {
                            MessageBox.Show("Le login ou mot de passe saisit est invalide.", "Erreur d'authentification");
                        }
                    }
                } else {
                    MessageBox.Show("Le login ou mot de passe saisit est invalide.", "Erreur d'authentification");
                }
            } else {
                MessageBox.Show("Veuillez renseigner tous les champs du formulaire d'authentification.", "Erreur de saisie");
            }
        }
    }
}
