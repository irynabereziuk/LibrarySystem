using System.Collections.Generic;

namespace LibrarySystem
{
    internal class UserRBAC
    {
        public string Name { get; }
        public List<Role> Roles { get; }
        public UserRBAC(string name, List<Role> roles)
        {
            Name = name;
            Roles = roles;
        }
    }
}