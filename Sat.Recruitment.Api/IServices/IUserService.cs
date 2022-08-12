using Sat.Recruitment.Api.Models;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.IServices
{
    public interface IUserService
    {
        Task <bool> ValidateUser(User user);
        
    }
}
