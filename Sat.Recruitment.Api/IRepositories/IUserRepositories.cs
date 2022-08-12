using Sat.Recruitment.Api.Models;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.IRepositories
{
    interface IUserRepositories
    {     
       Task<bool> CreateUser(User user);
    }
}
