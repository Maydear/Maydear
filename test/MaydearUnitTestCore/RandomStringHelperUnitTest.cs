

using Maydear.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaydearUnitTestCore
{
    [TestClass]
    public  class RandomStringHelperUnitTest
    {
        [TestMethod]
        public void NextNumberString()
        {

            System.Console.WriteLine(RandomStringHelper.NextNumberString(4));
        }

        [TestMethod]
        public void NextAsciiString()
        {

            System.Console.WriteLine(RandomStringHelper.NextAsciiString(4));
        }

        [TestMethod]
        public void NextLettersString()
        {

            System.Console.WriteLine(RandomStringHelper.NextLettersString(4));
        }
    }
}
