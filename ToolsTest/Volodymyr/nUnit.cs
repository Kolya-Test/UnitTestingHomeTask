using Tools;
using NUnit.Framework;
using Tools.Models;

namespace ToolsTest.Volodymyr
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

        [Test]
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

        [Test]
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

