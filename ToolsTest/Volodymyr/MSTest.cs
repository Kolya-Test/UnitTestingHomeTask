using Microsoft.VisualStudio.TestTools.UnitTesting;

using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

using Tools;
using Tools.Models;

namespace ToolsTest.Volodymyr
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
            Assert.AreEqual(" SAME ARTICLE", result);

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
