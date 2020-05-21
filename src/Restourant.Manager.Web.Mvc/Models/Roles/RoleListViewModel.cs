using System.Collections.Generic;
using Restourant.Manager.Roles.Dto;

namespace Restourant.Manager.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
