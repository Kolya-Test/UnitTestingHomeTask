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
            Article _article = new Article(title);
            //Assert
            Assert.True(_article.HasTitle);
        }
        [Test]
        public void Editor_HasTitleHasText_NotNullEqual()
        {
            //Arrange
            string title = "Title";
            string text = "Text";
            //Act
            Article _article = new Article(title,text);
            //Assert
            Assert.True(_article.HasTitle);
            Assert.True(_article.HasText);
            Assert.That(title, Is.EqualTo(_article.Title));
            Assert.That(text, Is.EqualTo(_article.Text));
        }
        [Test]
        public void Editor_UpdateTextHasText_True()
        {
            //Arrange
            string title = "Title";
            string text = "Text";
            //Act
            Article _article = new Article(title);
            _article.UpdateText(text);
            //Assert
            Assert.True(_article.HasText);            
        }
        [Test]
        public void Editor_HasText_False_HasTitle_True()
        {
            //Arrange
            string title = "Title";
            //Act
            Article _article = new Article();
            _article.UpdateTitle(title);
            //Assert
            Assert.True(_article.HasTitle);
            Assert.False(_article.HasText);
        }
    }
}
