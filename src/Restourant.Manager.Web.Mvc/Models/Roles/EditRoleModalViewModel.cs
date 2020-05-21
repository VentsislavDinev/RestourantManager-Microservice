using Abp.AutoMapper;
using Restourant.Manager.Roles.Dto;
using Restourant.Manager.Web.Models.Common;

namespace Restourant.Manager.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
