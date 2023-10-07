using Tools;
using Xunit;

using Tools.Models;
namespace ToolsTest.Volodymyr
{
    public class xUnit
    {
        [Fact]
        public void TryReplaceText()
        {
            // Arrange
            Article article = new Article { Text = " Text = this is old text in the article" };
            string newText = "new text";
            string oldText = "old text";

            // Act
            bool result = article.TryReplaceText(oldText, newText);

            // Assert
            Assert.True(result);
            Assert.Equal("this is new text in the article", article.Text);
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
            Assert.False(result);

            Assert.Null(article.Text);
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
            Assert.False(result);
            Assert.Equal(" ", article.Text);

        }

    }
}
