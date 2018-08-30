using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormationPOEWebAPI;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstTest()
        {
            int i = 1;
            i += 1;
            Assert.AreEqual(2, i);
            Book b = new Book();

        }

        [TestMethod]
        public void EFTest()
        {
            Model1 db = new Model1();
            List<Book> books = db.Books.ToList();
            Assert.IsTrue(books.Count > 0);
        }
    }
}
