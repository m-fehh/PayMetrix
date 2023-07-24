﻿using System.Collections.Generic;
using PayMetrix.Roles.Dto;

namespace PayMetrix.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
