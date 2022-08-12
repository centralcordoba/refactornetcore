using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sat.Recruitment.Api.IServices;
using Sat.Recruitment.Api.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Controllers
{
    

    [ApiController]
    [Route("[controller]")]
    public partial class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        private readonly List<User> _users = new List<User>();

        public object User(User user)
        {
            throw new NotImplementedException();
        }

        public UsersController(IUserService userService)
        {
            _userService = userService;

        }

        public UsersController()
        {
        }

        [HttpPost]
        [Route("/create-user")]
        public async Task<Result> CreateUser([FromBody] User user)
        {


            var result = await _userService.ValidateUser(user);

            try
            {
                if (result)
                {
                    return new Result()
                    {
                        IsSuccess = true,
                        Errors = "User Created"
                    };
                }
                else
                {
                    return new Result()
                    {
                        IsSuccess = false,
                        Errors = "The user is duplicated"
                    };
                };

            }
            catch (Exception)
            {

                throw;
            }
        }
           
    }
   
}
