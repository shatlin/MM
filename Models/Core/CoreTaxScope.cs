using System;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class CoreTaxScope
    {
        public int Id { get; set; }
        public string TaxScopeCode { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
