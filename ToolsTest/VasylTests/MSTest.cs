using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Tools;
using Tools.Models;

namespace ToolsTest.VasylTests
{
    [TestClass]
    public class MSTest
    {
        [TestMethod]
        public void TestGetSentences_ReturnsArrayOfSentences()
        {
            // Arrange
            string articleText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            Article article = new Article();
            article.Text = articleText;

            // Act
            string[] sentences = article.GetSentences();

            // Assert
            Assert.IsNotNull(sentences);
            Assert.AreEqual(4, sentences.Length);
            Assert.AreEqual("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", sentences[0]);
            Assert.AreEqual(" Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", sentences[1]);
            Assert.AreEqual(" Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", sentences[2]);
            Assert.AreEqual(" Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum", sentences[3]);
        }

        [TestMethod]
        public void TestGetSentences_ReturnsNullForNullArticleText()
        {
            // Arrange
            Article article = new Article(null);

            // Act
            string[] sentences = article.GetSentences();

            // Assert
            Assert.IsNull(sentences);
        }

        [TestMethod]
        public void TestGetSentences_ReturnsEmptyArrayForEmptyArticleText()
        {
            // Arrange
            Article article = new Article();
            article.Text = string.Empty;

            // Act
            string[] sentences = article.GetSentences();

            // Assert
            Assert.IsNotNull(sentences);
            Assert.AreEqual(0, sentences.Length);
        }
    }
}
