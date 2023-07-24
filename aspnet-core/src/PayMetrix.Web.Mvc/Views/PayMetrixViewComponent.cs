using Abp.AspNetCore.Mvc.ViewComponents;

namespace PayMetrix.Web.Views
{
    public abstract class PayMetrixViewComponent : AbpViewComponent
    {
        protected PayMetrixViewComponent()
        {
            LocalizationSourceName = PayMetrixConsts.LocalizationSourceName;
        }
    }
}
