using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetFrameworkFullLibrary;
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
        public void FrameworkFullMultiplier_Multiplies()
        {
            var result = FrameworkFullMultiplier.Multiply(2, 4);

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
