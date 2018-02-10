using Abp.Authorization;
using TrainCore.Authorization.Roles;
using TrainCore.Authorization.Users;

namespace TrainCore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
