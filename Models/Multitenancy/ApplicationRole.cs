using System;

namespace MM.ClientModels
{
    public class ApplicationRole : IdentiyRoleMultiTenant<string, string>
    {
        public ApplicationRole(string roleName) : base(roleName) { }
    }

   
}