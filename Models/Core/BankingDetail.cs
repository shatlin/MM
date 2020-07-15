using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MM.CoreModels
{
    public partial class CoreBankingDetail
    {

        public int Id { get; set; }

        [Display(Name = "Account Type", Prompt = "Please select your account type")]
        [Required(ErrorMessage = "Account Type is required")]
        public int AccountTypeId { get; set; }

        [Display(Name = "Account Name", Prompt = "Please enter your Account Name")]
        [Required(ErrorMessage = "Account Name is required")]
        public string AccountName { get; set; }

        [Display(Name = "Bank Name", Prompt = "Please enter your Bank Name")]
        [Required(ErrorMessage = "Bank Name is required")]
        public string BankName { get; set; }

        [Display(Name = "Branch Name", Prompt = "Please enter your Branch Name")]
        [Required(ErrorMessage = "Branch Name is required")]
        public string BranchName { get; set; }

        [Display(Name = "Account Number", Prompt = "Please enter your Bank Account Number")]
        [Required(ErrorMessage = "Account Number is required")]
        public string AccountNumber { get; set; }

        [Display(Name = "Routing Code", Prompt = "Please enter your Bank Routing Code")]
        public string RoutingCode { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual CoreAccountType CoreAccountType { get; set; }
    }
}
