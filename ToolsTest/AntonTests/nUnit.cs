using NUnit.Framework;
using Tools;

namespace ToolsTest.AntonTests
{
    internal class nUnit
    {
        [Test]
        public void FindPosition_ReturnsNegativeOneForNullInput()
        {
            // Arrange
            string text = null;
            string findingText = "Hello, world!";

            // Act
            int result = TextTool.FindPosition(text, findingText);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void FindPosition_ReturnsZeroForEmptyInputs()
        {
            // Arrange
            string text = "";
            string findingText = "";

            // Act
            int result = TextTool.FindPosition(text, findingText);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void FindPosition_ReturnsIndexForSingleMatch()
        {
            // Arrange
            string text = "Hello, world!";
            string findingText = "Hello";

            // Act
            int result = TextTool.FindPosition(text, findingText);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void FindPosition_ReturnsNegativeOneForNoMatch()
        {
            // Arrange
            string text = "Hello, world!";
            string findingText = "World";

            // Act
            int result = TextTool.FindPosition(text, findingText);

            // Assert
            Assert.AreEqual(-1, result);
        }
    }
}
