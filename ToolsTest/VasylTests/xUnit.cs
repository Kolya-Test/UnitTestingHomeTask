using System;
using System.Collections.Generic;
using System.Text;
using Tools.Models;
using Xunit;

namespace ToolsTest.VasylTests
{
    public class xUnit
    {
        [Fact]
        public void EmailProperty_CanBeSetAndRetrieved()
        {
            // Arrange
            string expectedEmail = "test@example.com";
            User user = new User("John");

            // Act
            user.Email = expectedEmail;
            string actualEmail = user.Email;

            // Assert
            Assert.Equal(expectedEmail, actualEmail);
        }
    }
}
