using System.Collections.Generic;
using Restourant.Manager.Roles.Dto;

namespace Restourant.Manager.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}