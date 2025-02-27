using System;
using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocumentsTests
{
    [TestClass]
    public class UtilisateurTests
    {
        [TestMethod]
        public void UtilisateurTest()
        {
            Utilisateur utilisateur = new Utilisateur(1, "Doe", "John", 1, "sha512PBKDF2Base64Repr==");
            Assert.AreEqual(1, utilisateur.Id);
            Assert.AreEqual("Doe", utilisateur.Nom);
            Assert.AreEqual("John", utilisateur.Prenom);
            Assert.AreEqual(1, utilisateur.Id_service);
            Assert.AreEqual("sha512PBKDF2Base64Repr==", utilisateur.Pwd_hash);
        }
    }
}
