// Це шаблон для побудови класу тестів

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using nAssert = NUnit.Framework.Assert;
using xAssert = Xunit.Assert;
using Theory = Xunit.TheoryAttribute;

namespace ToolsTest
{
    [TestClass]
    public class UnitTest1_Template
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }

}
