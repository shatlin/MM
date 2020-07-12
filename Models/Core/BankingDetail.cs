using System;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class CoreBankingDetail
    {
        public int Id { get; set; }
        public int? AccountTypeId { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string AccountNumber { get; set; }
        public string RoutingCode { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual CoreAccountType CoreAccountType { get; set; }
    }
}
