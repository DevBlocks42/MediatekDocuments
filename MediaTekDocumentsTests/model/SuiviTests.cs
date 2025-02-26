using System;
using System.Collections.Generic;
using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocumentsTests.model
{
    [TestClass]
    public class SuiviTests
    {
        private List<Suivi> suivis = new List<Suivi>();
        private List<string> libelles = new List<string>() { "en cours", "réglée", "livrée", "relancée" }; 
        [TestMethod]
        public void SuiviTest()
        {
            for (int i = 0; i < libelles.Count; i++)
            {
                suivis.Add(new Suivi(i + 1, libelles[i]));
                Assert.AreEqual(libelles[i], suivis[i].Libelle);
            }
        }
        [TestMethod]
        public void SuiviToStringTest()
        {
            for(int i = 0; i <  suivis.Count; i++) {
                Assert.AreEqual(libelles[i], suivis[i].Libelle);
            }
        }
    }
}
