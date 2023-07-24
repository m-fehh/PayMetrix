using System.Collections.Generic;
using PayMetrix.Roles.Dto;

namespace PayMetrix.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
