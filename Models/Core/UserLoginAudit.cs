using System;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class CoreUserLoginAudit
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
    }
}
