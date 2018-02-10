using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TrainCore.Authorization.Roles;
using TrainCore.Authorization.Users;
using TrainCore.MultiTenancy;

namespace TrainCore.EntityFrameworkCore
{
    public class TrainCoreDbContext : AbpZeroDbContext<Tenant, Role, User, TrainCoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TrainCoreDbContext(DbContextOptions<TrainCoreDbContext> options)
            : base(options)
        {
        }
    }
}
