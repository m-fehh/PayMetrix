using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace PayMetrix.Web.Views
{
    public abstract class PayMetrixRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PayMetrixRazorPage()
        {
            LocalizationSourceName = PayMetrixConsts.LocalizationSourceName;
        }
    }
}
