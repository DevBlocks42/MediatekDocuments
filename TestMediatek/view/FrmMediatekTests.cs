using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.view.Tests
{
    [TestClass()]
    public class FrmMediatekTests
    {
        [TestMethod()]
        public void ParutionDansAbonnementTest()
        {
            Assert.IsTrue(FrmMediatek.ParutionDansAbonnement("2023-01-01", "2023-12-31", "2023-06-15"));
            /*Assert.True(ParutionDansAbonnement("2023-01-01", "2023-12-31", "2023-06-15"))
            self.assertTrue(ParutionDansAbonnement("2023-01-01", "2023-12-31", "2023-01-01"))
            self.assertTrue(ParutionDansAbonnement("2023-01-01", "2023-12-31", "2023-12-31"))
            self.assertFalse(ParutionDansAbonnement("2023-01-01", "2023-12-31", "2022-12-31"))
            self.assertFalse(ParutionDansAbonnement("2023-01-01", "2023-12-31", "2024-01-01"))*/
        }
    }
}