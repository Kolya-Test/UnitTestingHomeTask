using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Tools.Models;

namespace ToolsTest.Models.VladyslavClassArticleTests
{
    [TestClass]
    public class UpdateTextMethod_MSTest
    {
        [TestMethod]
        public void UpdateText_Text_NotNull()
        {
            //Arrange
            Article _article = new Article();
            string _text = "Hello";
            //Act
            _article.UpdateText(_text);
            //Assert
            Assert.IsNotNull(_article.Text);
        }
        [TestMethod]
        public void UpdateText_TextAndUser_NotNull()
        {
            //Arange 
            Article _article = new Article();
            string text = "Test DONE";
            User editor = new User("John");
            //Act
            _article.UpdateText(text, editor);
            //Assert
            Assert.IsNotNull(_article.Text);
            Assert.IsNotNull( _article.Editor);
        }
        [TestMethod]
        public void UpdateTitle_Text_IsString()
        {
            //Arrange
            Article _article = new Article();
            string title = "Tytle is string!";
            //Act
            _article.UpdateTitle(title);
            //Assert
            Assert.IsInstanceOfType(_article.Title, typeof(string));
        }
    }
}
