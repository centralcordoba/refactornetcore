using Sat.Recruitment.Api.IRepositories;
using Sat.Recruitment.Api.Models;


namespace Sat.Recruitment.Api.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public WebApiDbContext Context { get; }

        public UnitOfWork(WebApiDbContext context)
        {
            Context = context;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
