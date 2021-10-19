using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace UnitTest_Mock.Models
{
    public class ApiDbContext : IdentityDbContext{
        public virtual DbSet<Employee> employees {get; set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options){}
    }
    
}