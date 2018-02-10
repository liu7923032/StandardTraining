using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TrainCore.Configuration;
using TrainCore.Web;

namespace TrainCore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TrainCoreDbContextFactory : IDesignTimeDbContextFactory<TrainCoreDbContext>
    {
        public TrainCoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TrainCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TrainCoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TrainCoreConsts.ConnectionStringName));

            return new TrainCoreDbContext(builder.Options);
        }
    }
}
