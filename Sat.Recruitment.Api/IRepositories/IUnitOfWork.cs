using Sat.Recruitment.Api.Models;
using System;

namespace Sat.Recruitment.Api.IRepositories
{
    interface IUnitOfWork : IDisposable
    {
        WebApiDbContext Context { get; }
        void Commit();
    }

}
