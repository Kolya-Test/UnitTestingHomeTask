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
        public void CtorArticle_IsType_User()
        {
            //Arrange
            User _user = new User("Tommy");           
            //Act
            Article _article = new Article(_user);
            //Assert            
            Assert.IsType<User>(_article.Autor);
        }
        [Fact]
        public void CtorArticle_HasTitleHasText_NotNull()
        {
            //Arrange
            string _title = "Title";  
            string _text = "Text";
            //Act
            Article _article = new Article(_title, _text);
            //Assert
            Assert.NotNull(_article);          
        }
        [Fact]
        public void Ctor_Title_NotNull_Equal()
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
