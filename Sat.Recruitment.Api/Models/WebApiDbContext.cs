using System.Data.Entity;


namespace Sat.Recruitment.Api.Models
{
    public class WebApiDbContext : DbContext
    {
        public WebApiDbContext() { }        

        public DbSet<User> Users { get; set; }       

       
    }
}
