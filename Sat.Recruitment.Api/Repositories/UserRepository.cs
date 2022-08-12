using Sat.Recruitment.Api.IRepositories;
using Sat.Recruitment.Api.Models;
using System;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Repositories
{
    public class UserRepository : IUserRepositories
    {
        private readonly IUnitOfWork _unitOfWork;
        public async Task<bool> CreateUser(User user)
        {
            bool created = false;
            var reader = Helpers.UserHelper.ReadUsersFromFile(user);
           
            var aux = user.Email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);

            var atIndex = aux[0].IndexOf("+", StringComparison.Ordinal);

            aux[0] = atIndex < 0 ? aux[0].Replace(".", "") : aux[0].Replace(".", "").Remove(atIndex);

            user.Email = string.Join("@", new string[] { aux[0], aux[1] });

            try
            {
                while (reader.Peek() >= 0)
                {
                    var line = reader.ReadLineAsync().Result;
                    var userDB = new User
                    {
                        Name = line.Split(',')[0].ToString(),
                        Email = line.Split(',')[1].ToString(),
                        Phone = line.Split(',')[2].ToString(),
                        Address = line.Split(',')[3].ToString(),
                        UserType = line.Split(',')[4].ToString(),
                        Money = decimal.Parse(line.Split(',')[5].ToString()),
                    };
                    
                    //var save = await _unitOfWork.Context.Set<T>().AllAsync(userDB);

                    //if (save != null)
                    //    created = true;
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return created;
        }                
       
    }
}
