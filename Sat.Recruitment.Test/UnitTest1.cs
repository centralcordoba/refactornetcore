using System;
using System.Dynamic;

using Microsoft.AspNetCore.Mvc;

using Sat.Recruitment.Api.Controllers;
using Sat.Recruitment.Api.Models;
using Xunit;

namespace Sat.Recruitment.Test
{
    [CollectionDefinition("Tests", DisableParallelization = true)]
    public class UnitTest1
    {
        [Fact]
        public void CreateUserTest()
        {
            var userController = new UsersController();
            User user = new User
            {
                Name ="test1",
                Address ="dasdas",
                Phone = "454564",
                Money = 45,
                UserType = "Test",
                Email = "test@gmail.com"
            };
            var result = userController.CreateUser(user).Result;

            Assert.Equal(true, result.IsSuccess);
            Assert.Equal("User Created", result.IsSuccess.ToString());
        }
       
    }
}
