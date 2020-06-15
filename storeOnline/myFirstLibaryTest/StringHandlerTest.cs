using System;
using storeOnlineLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace storeOnlineLibaryTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InstertSpcacesIsValid()
        {
            var source = "SonicScrew";
            var expected = "Sonic Screw";
            var actual = source.InsertSpaces();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InstertSpcacesSame()
        {
            var source = "Sonic Screw";
            var expected = "Sonic Screw";
            var actual = source.InsertSpaces();
            Assert.AreEqual(expected, actual);
        }
    }
}
