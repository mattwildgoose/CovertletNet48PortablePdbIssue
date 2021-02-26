using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetFrameworkCsPortableLibrary;
using NetFrameworkPortableLibrary;
using NetStandardPortableLibrary;

namespace Tests
{
    [TestClass]
    public class AllTests
    {
        [TestMethod]
        public void FrameworkMultiplier_Multiplies()
        {
            var result = FrameworkMultiplier.Multiply(2, 4);

            Assert.AreEqual(8, result);
        }
        
        [TestMethod]
        public void FrameworkCsMultiplier_Multiplies()
        {
            var result = FrameworkCsMultiplier.Multiply(2, 4);

            Assert.AreEqual(8, result);
        }


        [TestMethod]
        public void StandardMultiplier_Multiplies()
        {
            var result = StandardMultiplier.Multiply(2, 4);

            Assert.AreEqual(8, result);
        }
    }
}
