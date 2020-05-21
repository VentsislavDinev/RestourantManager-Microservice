using Abp.Authorization;
using Restourant.Manager.Authorization.Roles;
using Restourant.Manager.Authorization.Users;

namespace Restourant.Manager.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
