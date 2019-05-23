using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using supplyc.Configuration;

namespace supplyc.Web.Host.Startup
{
    [DependsOn(
       typeof(supplycWebCoreModule))]
    public class supplycWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public supplycWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(supplycWebHostModule).GetAssembly());
        }
    }
}
