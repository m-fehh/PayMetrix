using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace PayMetrix.Controllers
{
    public abstract class PayMetrixControllerBase: AbpController
    {
        protected PayMetrixControllerBase()
        {
            LocalizationSourceName = PayMetrixConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
