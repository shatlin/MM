using System;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class CoreAddress
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int AddressTypeId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string BuidlingName { get; set; }
        public string ComplexName { get; set; }
        public string StreetName { get; set; }
        public int? CityId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string PostalCode { get; set; }
        public string PrimaryContactNo { get; set; }
        public string SecondaryContactNo { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string FaxNumber { get; set; }
        public string Gpscoordinates { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual CoreAddressType CoreAddressType { get; set; }
        public virtual CoreCity CoreCity { get; set; }
        public virtual CoreCountry CoreCountry { get; set; }
        public virtual CoreState CoreState { get; set; }
    }
}
