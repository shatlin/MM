using System;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class CorePlanDetail
    {
        public int Id { get; set; }
        public int PlanMasterId { get; set; }
        public int CurrencyId { get; set; }
        public int PlanFrequencyId { get; set; }
        public decimal Amount { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual CoreCurrency Currency { get; set; }
        public virtual CorePlanFrequency CorePlanFrequency { get; set; }
        public virtual CorePlanMaster CorePlanMaster { get; set; }
    }
}
