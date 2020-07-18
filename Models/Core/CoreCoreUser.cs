using System;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class CoreUser
    {
        public CoreUser()
        {
            CoreUserRoleXref = new HashSet<CoreUserRoleXref>();
        }

        public int Id { get; set; }
        public int TitleId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public bool EmailActivated { get; set; }
        public string Notes { get; set; }
        public int GenderId { get; set; }
        public bool IsInternalUser { get; set; }
        public bool TermsAccepted { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual CoreGender CoreGender { get; set; }
        public virtual CoreTitle CoreTitle { get; set; }
        public virtual ICollection<CoreUserRoleXref> CoreUserRoleXref { get; set; }
    }
}
