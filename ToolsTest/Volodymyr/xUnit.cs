using Tools;

using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Tools.Models;


namespace ToolsTest.Volodymyr
{
    public class xUnit
    {
        [Fact]
        public void TryReplaceText()
        {
            // Arrange
            Article article = new Article { Text = "this is old text in the article" };
            string newText = "new text";
            string oldText = "old text";

            // Act
            bool result = article.TryReplaceText(oldText, newText);

            // Assert
            Assert.IsTrue(result);
            Assert.Equals("this is new text in the article", article.Text);
        }
        [Fact]
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
        [Fact]
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
