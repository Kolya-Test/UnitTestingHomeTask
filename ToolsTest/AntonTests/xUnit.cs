using Tools;
using Xunit;

namespace ToolsTest.AntonTests
{
    public class xUnit
    {
        [Fact]
        public void ToCapital_ReturnsEmptyStringForNullInput()
        {
            // Arrange
            string text = null;

            // Act
            string result = TextTool.ToCapital(text);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void ToCapital_ReturnsUppercaseStringForNonEmptyInput()
        {
            // Arrange
            string text = "Hello, world!";

            // Act
            string result = TextTool.ToCapital(text);

            // Assert
            Assert.Equal("HELLO, WORLD!", result);
        }
    }
}
