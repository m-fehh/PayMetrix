using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PayMetrix.Configuration;

namespace PayMetrix.Web.Host.Startup
{
    [DependsOn(
       typeof(PayMetrixWebCoreModule))]
    public class PayMetrixWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PayMetrixWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PayMetrixWebHostModule).GetAssembly());
        }
    }
}
