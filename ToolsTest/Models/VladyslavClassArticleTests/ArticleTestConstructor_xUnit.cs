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
            User _user = new User("Tommy");
            string title = null;
            //Act
            Article _article = new Article(_user);
            //Assert
            Assert.Null(title);
            Assert.IsType<User>(_article.Autor);
        }
        [Fact]
        public void CtorArticle_HasTitleAndText_TypeString()
        {
            //Arrange
            string title = "Title";   
            User _user = new User();
            //Act
            Article _article = new Article(title);
            //Assert
            Assert.IsType<string>(_article.Title);
            Assert.NotNull(_user);
        }
        [Fact]
        public void Ctor_AutorTitleText_NotNull()
        {
            //Arrange
            string _title = "Title";
            //Act
            Article _article = new Article(_title);
            //Assert            
            Assert.NotNull(_article.Title);
            Assert.Equal(_title, _article.Title);
        }
    }
}
