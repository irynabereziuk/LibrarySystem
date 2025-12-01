using System.Linq;

namespace LibrarySystem
{
    internal class AuthorizationService
    {
        public bool CheckPermission(UserRBAC user, string permissionCode)
        {
            return user.Roles
                       .SelectMany(r => r.Permissions)
                       .Any(p => p.Code == permissionCode);
        }
    }
}

