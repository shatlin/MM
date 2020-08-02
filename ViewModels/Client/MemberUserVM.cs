using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Xunit;
using Xunit.Sdk;

namespace MM.ClientModels
{
    public partial class MemberUserVM
    {
        public int Id { get; set; }
        public string ApplicaitonUserId { get; set; }

        [Display(Name = "Contact Number", Prompt = "Enter Phone Number")]
        [Required(ErrorMessage = "Phone Number is required")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email ID", Prompt = "Enter email id")]
        [Required(ErrorMessage = "Email ID is required")]
        public string Email { get; set; }

        [Display(Name = "First Name", Prompt = "Enter First Name")]
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }


        [Display(Name = "Middle Name", Prompt = "Enter Middle Name")]
        //[Required(ErrorMessage = "Middle Name is required")] 
        public string MiddleName { get; set; }

        [Display(Name = "Last Name", Prompt = "Enter Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password", Prompt = "Enter Password (Min. 6 char)")]
        public string Pwd { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password", Prompt = "Retype same Password")]
        [Compare("Pwd", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPwd { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Gender is required")]
        public int GenderId { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "Title is required")]
        public int TitleId { get; set; }

        [Display(Name = "Date of Birth", Prompt = "Enter your Birthday")]
        [Required(ErrorMessage = "Birthday is required")]
        public DateTime? BirthDay { get; set; }

        [Display(Name = "Member Branch")]
        [Required(ErrorMessage = "Member Branch is required")]
        public int? MemberBranchId { get; set; }
        public string MemberBranchName { get; set; }

        [Display(Name = "Organization")]
        [Required(ErrorMessage = "Organization is required")]
        public int? OrganizationId { get; set; }
        public string OrganizationName { get; set; }

        [Display(Name = "Referral Type")]
        
        public int? ReferralTypeId { get; set; }
        public string ReferralTypeName { get; set; }

        [Display(Name = "Organization Structure")]
        [Required(ErrorMessage = "Organization Structure is required")]
        public int? OrganizationStructureId { get; set; }
        public string OrganizationStructureName { get; set; }

        [Display(Name = "Member Code",
                 Prompt ="Enter Member Code")]
        [Required(ErrorMessage = "Member Code is required")]
        public string MemberCode { get; set; }

        [Display(Name = "Join Date",
                 Prompt = "Enter Join Date")]
        //[Required(ErrorMessage = "Join Date is required")]
        public DateTime JoinDate { get; set; }

        [Display(Name = "Renewal Date",
                 Prompt = "Enter Next Renewal Date")]
        //[Required(ErrorMessage = "Renewal Date is required")]
        public DateTime NextRenewalDate { get; set; }

        [Display(Name = "Membership Confirmation")]
        public bool MembershipConfirmed { get; set; }

        [Display(Name = "Membership Confirm Date",
                 Prompt = "Enter Membership Confirmed Date")]
        //[Required(ErrorMessage = "Confirm Date is required")]
        public DateTime ConfirmedDate { get; set; }

        [Display(Name = "Member Status")]
        //[Required(ErrorMessage = "Member Status is required")]
        public int? MemberStatusId { get; set; }
        public string MemberStatusName { get; set; }

        [Display(Name = "Member Level")]
        //[Required(ErrorMessage = "Member Level is required")]
        public int? MemberLevelId { get; set; }
        public string MemberLevelName { get; set; }

        [Display(Name = "Member Team")]
        //[Required(ErrorMessage = "Member Team is required")]
        public int? MemberTeamId { get; set; }
        public string MemberTeamName { get; set; }

        [Display(Name = "Member Type")]
        //[Required(ErrorMessage = "Member Type is required")]
        public int MemberTypeId { get; set; }
        public string MemberTypeName { get; set; }

        [Display(Name = "Member Photo")]
        //[Required(ErrorMessage = "Member Photo is required")]
        public byte[] Photo { get; set; }

        [Display(Name = "About Member",
                 Prompt ="Enter notes about Member")]
        //[Required(ErrorMessage = "Member Status is required")]
        public string Notes { get; set; }

        [Display(Name = "Is Billing Contact")]
        [Required(ErrorMessage = "Billing Contact status is required")]
        public bool IsBillingContact { get; set; }

        [Display(Name = "Branch Contact")]
        [Required(ErrorMessage = "Branch Contact status is required")]
        public bool IsBranchContact { get; set; }

        [Display(Name = "Terms Accepted")]
        [Required(ErrorMessage = "Term status is required")]
        public bool TermAccepted { get; set; }

        [Display(Name = "Is Active")]
        [Required(ErrorMessage = "Active status is required")]
        public bool IsActive { get; set; }



    }


}
