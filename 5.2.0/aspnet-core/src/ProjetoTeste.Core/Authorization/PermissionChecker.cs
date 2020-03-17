using Abp.Authorization;
using ProjetoTeste.Authorization.Roles;
using ProjetoTeste.Authorization.Users;

namespace ProjetoTeste.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
