using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MM.ClientModels;
using Newtonsoft.Json;

namespace MM.Pages.Client
{
    public class BankingDetailModel : PageModel
    {
        private readonly ClientDbContext _context;

        public BankingDetailModel(ClientDbContext context)
        {
            _context = context;
        }



        [BindProperty]
        public BankingDetail BankingDetail { get; set; }

        [ViewData]
        public SelectList AccountTypes { get; set; }

        [BindProperty]
        public List<AccountType> AccountTypeList { get; set; }
        
        private string errorMessage;

        // called first time the page is loaded.
        public IActionResult OnGet()
        {
            AccountTypeList = _context.AccountType.ToList();
            AccountTypes = new SelectList(AccountTypeList, nameof(AccountType.Id), nameof(AccountType.Name));
            return Page();
        }

        // called to load and refresh grid
        public IActionResult OnGetList()
        {
            var blist = _context.BankingDetail.Include(x=>x.AccountType).ToList();
            List <BankingDetailVM> bankingDetailVMList = new List<BankingDetailVM>();
           
            try
            {
                foreach (var bankingDetail in blist)
                {
                    BankingDetailVM bdVM = new BankingDetailVM
                    {
                        Id = bankingDetail.Id,
                        AccName= bankingDetail.AccountType.Name,
                        AccountTypeId = bankingDetail.AccountTypeId,
                        BankName = bankingDetail.BankName,
                        BranchName = bankingDetail.BranchName,
                        AccountNumber = bankingDetail.AccountNumber,
                        RoutingCode = bankingDetail.RoutingCode
                    };
                    bankingDetailVMList.Add(bdVM);
                }
                return new JsonResult(bankingDetailVMList);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return new JsonResult(new { success = false, message = "Error. Please check values entered "+ errorMessage });
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.BankingDetail.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
        public async Task<IActionResult> OnPostSaveAsync()
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }
            if (BankingDetail.Id > 0)
            {
                _context.Attach(BankingDetail).State = EntityState.Modified;
            }
            else
            {
                _context.BankingDetail.Add(BankingDetail);
            }
             await _context.SaveChangesAsync();
            return new JsonResult( new { success = true, message = "Saved successfully" });
        }

         public async Task<IActionResult> OnGetDeleteAsync(int? id)
        {

            if (id == null)
            {
                return new JsonResult(new { success = false, message = "No such record found to delete" });
            }

            BankingDetail = await _context.BankingDetail.FindAsync(id);

            if (BankingDetail != null)
            {
                _context.BankingDetail.Remove(BankingDetail);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
