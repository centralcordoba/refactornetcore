using Sat.Recruitment.Api.Helpers;
using Sat.Recruitment.Api.IRepositories;
using Sat.Recruitment.Api.IServices;
using Sat.Recruitment.Api.Models;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Services
{


    public class UserService : IUserService
    {
        private readonly IUserRepositories _userRepositorie;
        public async Task <bool> ValidateUser(User user)
        {
            user = UserHelper.VerifiedUser(user);
            return await _userRepositorie.CreateUser(user);             
        }       
    }
}
