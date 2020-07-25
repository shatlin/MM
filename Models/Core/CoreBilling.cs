using System;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class CoreBilling
    {
        public int Id { get; set; }
        public int? InvoiceId { get; set; }
        public int RelatedToId { get; set; }
        public int RelatedRecordId { get; set; }
        public int PaymentGatewayId { get; set; }
        public DateTime? PaymentDueDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public string PaymentItem { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public string CommentsForPayer { get; set; }
        public string InternalNotes { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual CoreInvoice CoreInvoice { get; set; }
        public virtual CorePaymentGateway CorePaymentGateway { get; set; }
        public virtual CoreRelatedTo CoreRelatedTo { get; set; }
    }
}
