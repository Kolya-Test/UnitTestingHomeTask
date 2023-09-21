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
            Assert.IsNotNull(_article);
        }
        [TestMethod]
        public void UpdateText_TextAndUser_NotNull()
        {
            //Arange 
            Article _article = new Article();
            _article.Text = "Test DONE";
            _article.Editor = new User("John");
            //Act
            _article.UpdateText(_article.Text, _article.Editor);
            //Assert
            Assert.IsNotNull(_article.Text);
            Assert.IsNotNull( _article.Editor);
        }
        [TestMethod]
        public void UpdateText_Text_IsString()
        {
            //Arrange
            Article _article = new Article();
            _article.Text = "some text with type string!";
            //Act
            _article.UpdateText(_article.Text);
            //Assert
            Assert.IsInstanceOfType(_article.Text, typeof(string));
        }
    }
}
