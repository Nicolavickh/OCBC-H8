using Microsoft.EntityFrameworkCore;
using TodoAppRefreshToken.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TodoAppRefreshToken.Data
{
    public class ApiDbContext : IdentityDbContext{
        public virtual DbSet<ItemData> Items {get; set;}
        public virtual DbSet<RefreshToken> RefreshToken {get; set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options){

        }
    }
    
}