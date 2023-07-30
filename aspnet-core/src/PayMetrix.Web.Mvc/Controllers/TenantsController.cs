using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using PayMetrix.Authorization;
using PayMetrix.Controllers;
using PayMetrix.MultiTenancy;
using PayMetrix.Users;
using PayMetrix.MultiTenancy.Dto;

namespace PayMetrix.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : PayMetrixControllerBase
    {
        private readonly ITenantAppService _tenantAppService;
        private readonly IUserAppService _userAppService;

        public TenantsController(ITenantAppService tenantAppService, IUserAppService userAppService)
        {
            _tenantAppService = tenantAppService;
            _userAppService = userAppService;
        }

        public ActionResult Index() => View();

        public async Task<ActionResult> EditModal(int tenantId)
        {
            var tenantDto = await _tenantAppService.GetAsync(new EntityDto(tenantId));
            return PartialView("_EditModal", tenantDto);
        }

        public async Task<ActionResult> GetUserByTenantId(int tenantId)
        {
            var userDto = await _userAppService.GetUserByTenantId(tenantId);
            return PartialView("_GetUserByTenantModal", userDto);
        }
    }
}
