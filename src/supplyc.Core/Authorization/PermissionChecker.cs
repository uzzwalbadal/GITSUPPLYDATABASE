using Abp.Authorization;
using supplyc.Authorization.Roles;
using supplyc.Authorization.Users;

namespace supplyc.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
