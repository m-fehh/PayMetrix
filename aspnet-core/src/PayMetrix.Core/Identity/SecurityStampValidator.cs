using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using PayMetrix.Authorization.Roles;
using PayMetrix.Authorization.Users;
using PayMetrix.MultiTenancy;
using Microsoft.Extensions.Logging;
using Abp.Domain.Uow;

namespace PayMetrix.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory,
            IUnitOfWorkManager unitOfWorkManager)
            : base(options, signInManager, systemClock, loggerFactory, unitOfWorkManager)
        {
        }
    }
}
