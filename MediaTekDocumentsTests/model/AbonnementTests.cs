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
    public class AbonnementTests
    {
        [TestMethod()]
        public void AbonnementTest()
        {
            DateTime dateCommande = DateTime.Parse("20/02/2025 00:00:00");
            DateTime dateFinAbo = DateTime.Parse("01/03/2025 00:00:00");
            string id = "00001";
            string idRevue = "10001";
            Abonnement abonnement = new Abonnement(id, dateCommande, 10.99, dateFinAbo, idRevue);
            Assert.AreEqual(id, abonnement.id);
            Assert.AreEqual(dateCommande, abonnement.dateCommande);
            Assert.AreEqual(10.99, abonnement.montant);
            Assert.AreEqual(dateFinAbo, abonnement.DateFinAbonnement);
            Assert.AreEqual(idRevue, abonnement.IdRevue);
        }
    }
}