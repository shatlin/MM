using System;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class CoreInvoice
    {
        public CoreInvoice()
        {
            CoreBilling = new HashSet<CoreBilling>();
        }

        public int Id { get; set; }
        public string InvoiceCode { get; set; }
        public int? RelatedToId { get; set; }
        public int? RelatedRecordId { get; set; }
        public int InvoiceStatusId { get; set; }
        public int PaymentGatewayId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceItem { get; set; }
        public decimal InvoiceAmount { get; set; }
        public string CommentsForPayer { get; set; }
        public string InternalNotes { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual CoreInvoiceStatus CoreInvoiceStatus { get; set; }
        public virtual CorePaymentGateway CorePaymentGateway { get; set; }
        public virtual CoreRelatedTo CoreRelatedTo { get; set; }
        public virtual ICollection<CoreBilling> CoreBilling { get; set; }
    }
}
