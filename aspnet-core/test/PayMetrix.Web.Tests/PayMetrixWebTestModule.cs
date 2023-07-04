using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PayMetrix.EntityFrameworkCore;
using PayMetrix.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace PayMetrix.Web.Tests
{
    [DependsOn(
        typeof(PayMetrixWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class PayMetrixWebTestModule : AbpModule
    {
        public PayMetrixWebTestModule(PayMetrixEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PayMetrixWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(PayMetrixWebMvcModule).Assembly);
        }
    }
}