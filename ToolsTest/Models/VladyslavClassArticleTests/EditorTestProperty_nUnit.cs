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
        public void Editor_HasTitle_NotNull ()
        {
            //Arrange
            string title = "Title";
            //Act
            Article _editor = new Article(title);
            //Assert
            Assert.IsNotNull(_editor.HasTitle);
        }
        [Test]
        public void Editor_HasTitleHasText_NotNullEqual()
        {
            //Arrange
            string title = "Title";
            string text = "Text";
            //Act
            Article _editor = new Article(title,text);
            //Assert
            Assert.IsNotNull(_editor.HasTitle);
            Assert.IsNotNull(_editor.HasText);
            Assert.That(title, Is.EqualTo(_editor.Title));
            Assert.That(text, Is.EqualTo(_editor.Text));
        }
        [Test]
        public void Editor_HasText_TypeStringNotNull()
        {
            //Arrange
            string title = "Title";
            string text = "Text";
            //Act
            Article _editor = new Article(title,text);
            //Assert
            Assert.IsInstanceOf<string>(_editor.Title);
            Assert.IsInstanceOf<string>(_editor.Text);
            Assert.IsNotNull(_editor.HasText);
        }
    }
}
