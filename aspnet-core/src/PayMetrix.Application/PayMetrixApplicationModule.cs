using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PayMetrix.Authorization;

namespace PayMetrix
{
    [DependsOn(
        typeof(PayMetrixCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PayMetrixApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PayMetrixAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PayMetrixApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
