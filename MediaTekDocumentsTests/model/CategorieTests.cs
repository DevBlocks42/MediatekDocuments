using System;
using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocumentsTests.model
{
    [TestClass]
    public class CategorieTests
    {
        [TestMethod]
        public void CategorieToStringTest()
        {
            Genre genre = new Genre("00001", "Horreur");
            Assert.AreEqual("Horreur", genre.ToString());   
        }
    }
}
