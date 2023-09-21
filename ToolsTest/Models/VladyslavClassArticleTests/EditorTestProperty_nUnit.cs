using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Tools.Models;

namespace ToolsTest.Models.VladyslavClassArticleTests
{
    [TestFixture]
    public class EditorTestProperty_nUnit
    {
        [Test]
        public void Editor_Property_Type ()
        {
            //Arrange
            Article _editor = new Article ();
            //Act
            _editor.Editor = new User("Peter");
            //Assert
            Assert.IsInstanceOf<User>(_editor.Editor);
        }
        [Test]
        public void Editor_Name_NotNull()
        {
            //Arrange
            Article _editor = new Article();
            //Act
            _editor.Editor = new User("SomeName");
            //Assert
            Assert.IsNotNull( _editor.Editor.Name);
        }
        [Test]
        public void Editor_Name_TypeString()
        {
            //Arrange
            Article _editor = new Article();
            //Act
            _editor.Editor = new User("NameHasTypeString");
            //Assert
            Assert.IsInstanceOf<string>(_editor.Editor.Name);
        }
    }
}
