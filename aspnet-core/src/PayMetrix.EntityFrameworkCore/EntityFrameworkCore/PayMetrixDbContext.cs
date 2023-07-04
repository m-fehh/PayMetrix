using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PayMetrix.Authorization.Roles;
using PayMetrix.Authorization.Users;
using PayMetrix.MultiTenancy;

namespace PayMetrix.EntityFrameworkCore
{
    public class PayMetrixDbContext : AbpZeroDbContext<Tenant, Role, User, PayMetrixDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PayMetrixDbContext(DbContextOptions<PayMetrixDbContext> options)
            : base(options)
        {
        }
    }
}
