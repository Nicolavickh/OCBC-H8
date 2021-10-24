using Microsoft.EntityFrameworkCore;
using Bank_PaymentDetails.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Bank_PaymentDetails.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<ItemData> Items {get; set;}
        public virtual DbSet<RefreshToken> RefreshToken {get; set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options){}
    }
}