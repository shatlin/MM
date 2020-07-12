using System;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class CoreCurrency
    {
        public CoreCurrency()
        {
            CorePlanDetail = new HashSet<CorePlanDetail>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<CorePlanDetail> CorePlanDetail { get; set; }
    }
}
