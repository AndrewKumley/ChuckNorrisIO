using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using System;

namespace ChuckNorrisIO.UnitTest
{
    [TestClass]
    public class ChuckNorrisUnitTest
    {
        [TestMethod]
        public void CategoriesShouldReturnNonEmptySequence()
        {
            ChuckNorrisClient client = new ChuckNorrisClient();
            IEnumerable<string> categories = client.Categories();
            Assert.IsTrue(categories.Any());
        }
    }
}
