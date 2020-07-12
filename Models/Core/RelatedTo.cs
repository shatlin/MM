using System;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class CoreRelatedTo
    {
        public CoreRelatedTo()
        {
            CoreBilling = new HashSet<CoreBilling>();
            CoreInvoice = new HashSet<CoreInvoice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<CoreBilling> CoreBilling { get; set; }
        public virtual ICollection<CoreInvoice> CoreInvoice { get; set; }
    }
}
