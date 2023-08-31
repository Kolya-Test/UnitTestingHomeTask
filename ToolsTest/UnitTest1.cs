using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using nAssert = NUnit.Framework.Assert;
using xAssert = Xunit.Assert;
using Theory = Xunit.TheoryAttribute;
using Tools;

namespace ToolsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetColorNameRed()
        {
            // Проверяем, что метод возвращает строку "Red" для свойства RedColorName
            Assert.AreEqual("Red", TextTool.RedColorName);
        }

        [TestMethod]
        public void TestGetColorNameOrange()
        {
            // Проверяем, что метод возвращает строку "Orange" для свойства OrangeColorName
            Assert.AreEqual("Orange", TextTool.OrangeColorName);
        }

        [TestMethod]
        public void TestGetColorNameYellow()
        {
            // Проверяем, что метод возвращает строку "Yellow" для свойства YellowColorName
            Assert.AreEqual("Yellow", TextTool.YellowColorName);
        }
    }

}
