using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using supplyc.Authorization;

namespace supplyc
{
    [DependsOn(
        typeof(supplycCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class supplycApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<supplycAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(supplycApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
