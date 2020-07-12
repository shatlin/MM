using System;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class CoreRolePermissionXref
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int Permissionid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual CorePermission CorePermission { get; set; }
        public virtual CoreRole CoreRole { get; set; }
    }
}
