using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindImageResolutionNET.Parser;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Tests
{
    [TestClass]
    public class TestParser
    {
        [TestMethod]
        public void Test1()
        {
            string config = "[{<ScanInformation>.}{<Width>px}]";
            var result = MatchedCurlyBrackets.Parse(config);

            var firstElement = result.ElementAt(0);
            Assert.AreEqual(firstElement.Prefix, "[");
            Assert.AreEqual(firstElement.Text, "<ScanInformation>.");
            Assert.AreEqual(firstElement.Suffix, "");

            //Angle Brackets
            Assert.AreEqual(firstElement.Value.Prefix, "");
            Assert.AreEqual(firstElement.Value.Text, "ScanInformation");
            Assert.AreEqual(firstElement.Value.Suffix, ".");

            var secondElement = result.ElementAt(1);
            Assert.AreEqual(secondElement.Prefix, "");
            Assert.AreEqual(secondElement.Text, "<Width>px");
            Assert.AreEqual(secondElement.Suffix, "]");

            //Angle Brackets
            Assert.AreEqual(secondElement.Value.Prefix, "");
            Assert.AreEqual(secondElement.Value.Text, "Width");
            Assert.AreEqual(secondElement.Value.Suffix, "px");
        }
    }
}
