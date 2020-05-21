using System.Collections.Generic;
using Restourant.Manager.Roles.Dto;

namespace Restourant.Manager.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
