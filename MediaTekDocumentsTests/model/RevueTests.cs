using System;
using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocumentsTests.model
{
    [TestClass]
    public class RevueTests
    {
        [TestMethod]
        public void RevueTest()
        {
            Revue revue = new Revue("00001", "Science & Vie", "", "10009", "Documentaire", "00003", "Tous public", "00001", "Rayon test", "ME", 12);
            Assert.AreEqual("00001", revue.Id);
            Assert.AreEqual("Science & Vie", revue.Titre);
            Assert.AreEqual("", revue.Image);
            Assert.AreEqual("10009", revue.IdGenre);
            Assert.AreEqual("Documentaire", revue.Genre);
            Assert.AreEqual("00003", revue.IdPublic);
            Assert.AreEqual("Tous public", revue.Public);
            Assert.AreEqual("00001", revue.IdRayon);
            Assert.AreEqual("Rayon test", revue.Rayon);
            Assert.AreEqual("ME", revue.Periodicite);
            Assert.AreEqual(12, revue.DelaiMiseADispo);
        }
    }
}
