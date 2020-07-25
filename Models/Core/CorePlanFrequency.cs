using System;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class CorePlanFrequency
    {
        public CorePlanFrequency()
        {
            CorePlanDetail = new HashSet<CorePlanDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<CorePlanDetail> CorePlanDetail { get; set; }
    }
}
