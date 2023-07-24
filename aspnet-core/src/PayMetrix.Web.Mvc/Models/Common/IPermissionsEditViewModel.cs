using System.Collections.Generic;
using PayMetrix.Roles.Dto;

namespace PayMetrix.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}