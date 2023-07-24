using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using PayMetrix.Controllers;

namespace PayMetrix.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : PayMetrixControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
