using System.Collections.Generic;

namespace LibrarySystem
{
    internal class Role
    {
        public string Name { get; }
        public List<Permission> Permissions { get; }

        public Role(string name, List<Permission> permissions)
        {
            Name = name;
            Permissions = permissions;
        }
    }
}
