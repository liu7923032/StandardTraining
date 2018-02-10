using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TrainCore.Configuration;

namespace TrainCore.Web.Host.Startup
{
    [DependsOn(
       typeof(TrainCoreWebCoreModule))]
    public class TrainCoreWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TrainCoreWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TrainCoreWebHostModule).GetAssembly());
        }
    }
}
