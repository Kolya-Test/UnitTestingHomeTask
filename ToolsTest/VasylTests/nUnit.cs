using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tools.Models;

namespace ToolsTest.VasylTests
{
    internal class nUnit
    {
        [Test]
        public void Constructor_WithValidUser_SetsAutor()
        {
            // Arrange
            User user = new User("Lorem Ipsum");

            // Act
            Article article = new Article(user);

            // Assert
            Assert.AreEqual(user, article.Autor);
        }

        [Test]
        public void Constructor_WithNullUser_SetsUndefinedAutor()
        {
            // Arrange
            User user = null;

            // Act
            Article article = new Article(user);

            // Assert
            Assert.AreEqual(User.Undefined, article.Autor);
        }
    }
}
