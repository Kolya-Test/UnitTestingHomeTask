using System;
using System.Collections.Generic;
using System.Text;
using Tools.Models;
using Xunit;

namespace ToolsTest.Models.VladyslavClassArticleTests
{
    public class ArticleTestConstructor_xUnit
    {
        [Fact]
        public void CtorArticle_HasType_User()
        {
            //Arrange
            Article _article = new Article();
            User _user = new User("Tommy");
            //Act
            _article.Autor = _user;
            //Assert
            Assert.IsType<User>(_article.Autor);
        }
        [Fact]
        public void CtorArticle_HasTitleAndText_TypeString()
        {
            //Arrange
            Article _article = new Article();
            //Act
            _article.Title = "Title";
            _article.Text = "Text";
            //Assert
            Assert.IsType<string>(_article.Title);
            Assert.IsType<string>(_article.Text);
        }
        [Fact]
        public void Ctor_AutorTitleText_NotNull()
        {
            //Arrange
            Article _article = new Article();
            //Act
            _article.Autor = new User("Bill");
            _article.Title = "Title";
            _article.Text = "Text";
            //Assert
            Assert.NotNull(_article.Autor);
            Assert.NotNull(_article.Title);
            Assert.NotNull(_article.Text);
        }
    }
}
