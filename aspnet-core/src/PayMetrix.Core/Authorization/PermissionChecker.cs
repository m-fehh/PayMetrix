using Abp.Authorization;
using PayMetrix.Authorization.Roles;
using PayMetrix.Authorization.Users;

namespace PayMetrix.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
