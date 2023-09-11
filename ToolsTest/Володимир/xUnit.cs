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
    public class xUnit
    {
        [Fact]
        public void TryReplaceText()
        {
            // Arrange
            Article article = new Article { Text = "this is article has text" };
            string newText = "new text";
            string oldText = "old text";

            // Act

            bool result = article.TryReplaceText(oldText, newText);
            // Assert
            Assert.IsTrue(result);
           
        }
        public void TryReplaceTextIsNull()
        {
            // Arrange
            Article article = new Article { Text = null };
            string newText = "new text";
            string oldText = "old text";

            // Act

            bool result = article.TryReplaceText(oldText, newText);
            // Assert
            Assert.IsFalse(result);
            Assert.IsNull(article.Text);
        }
        public void TryReplaceTextIsEmpty()
        {
            // Arrange
            Article article = new Article { Text = " " };
            string newText = "new text";
            string oldText = "old text";

            // Act

            bool result = article.TryReplaceText(oldText, newText);
            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(" ", article.Text);

        }
        
    }
}
