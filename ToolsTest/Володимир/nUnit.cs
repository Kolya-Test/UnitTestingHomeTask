using System;
using Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using nAssert = NUnit.Framework.Assert;
using xAssert = Xunit.Assert;
using Theory = Xunit.TheoryAttribute;
using Tools.Models;
namespace ToolsTest.Володимир
{
    public class nUnit
    {
        [Test]
        public void TestHasText()
        {
            // Arrange
            Article article = new Article { Text = "this is article has text" };
           string searchText = "text";
            // Act
            bool result = article.HasText(searchText);

            // Assert
            Assert.IsTrue(result);
        }
        public void TestHasTextIsEmpty()
        {
            // Arrange
            Article article = new Article { Text = "" };
            string searchText = "text";
            // Act
            bool result = article.HasText(searchText);

            // Assert
            Assert.IsFalse(result);
        }
        public void TestHasTextIsNull()
        {
            // Arrange
            Article article = new Article { Text = null };
            string searchText = "text";
            // Act
            bool result = article.HasText(searchText);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
