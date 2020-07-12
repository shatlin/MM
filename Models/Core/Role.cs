using System;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class CoreRole
    {
        public CoreRole()
        {
            CoreRolePermissionXref = new HashSet<CoreRolePermissionXref>();
            CoreUserRoleXref = new HashSet<CoreUserRoleXref>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<CoreRolePermissionXref> CoreRolePermissionXref { get; set; }
        public virtual ICollection<CoreUserRoleXref> CoreUserRoleXref { get; set; }
    }
}
