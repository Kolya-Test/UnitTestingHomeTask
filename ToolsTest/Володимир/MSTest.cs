using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using nAssert = NUnit.Framework.Assert;
using xAssert = Xunit.Assert;
using Theory = Xunit.TheoryAttribute;
using Tools;
using Tools.Models;

namespace ToolsTest.Володимир
{
    [TestClass]
    public class MSTest
    {
        //TryReplaceText GetCapitalTitle HasText
        [TestMethod]
        public void TestGetCapitalTitle()
        {
            //arrange
            Article article = new Article { Title = "same article" };

            //act
            string result = article.GetCapitalTitle();

            // Assert
            Assert.AreEqual("Same article", result);

        }
        [TestMethod]
        public void TestGetCapitalTitleIsNull()
        {
            //arrange
            Article article = new Article { Title = null };

            //act
            string result = article.GetCapitalTitle();

            // Assert
            Assert.IsNull(result);

        }
        [TestMethod]
        public void TestGetCapitalTitleIsEmpty()
        {
            //arrange
            Article article = new Article { Title = " " };

            //act
            string result = article.GetCapitalTitle();

            // Assert
            Assert.AreEqual(" ", result);

        }
    }
}
