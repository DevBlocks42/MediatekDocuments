using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model.Tests
{
    [TestClass()]
    public class SuiviTests
    {
        private List<Suivi> suivis;
        [TestMethod()]
        public void SuiviTest()
        {
            suivis.Add(new Suivi(1, "en cours"));
            suivis.Add(new Suivi(2, "réglée"));
            suivis.Add(new Suivi(3, "livrée"));
            suivis.Add(new Suivi(4, "relancée"));
            Assert.AreEqual("en cours", suivis[0].Libelle);
            Assert.AreEqual("réglée", suivis[1].Libelle);
            Assert.AreEqual("livrée", suivis[2].Libelle);
            Assert.AreEqual("relancée", suivis[3].Libelle);
        }

        [TestMethod()]
        public void ToStringTest()
        {

        }
    }
}