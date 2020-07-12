using System;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class CoreUserRoleXref
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual CoreRole CoreRole { get; set; }
        public virtual CoreUser CoreUser { get; set; }
    }
}
