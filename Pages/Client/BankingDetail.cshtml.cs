using System;
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
        public IList<BankingDetail> BankingDetailList { get; set; }

        [BindProperty]
        public BankingDetail BankingDetail { get; set; }

        [ViewData]
        public SelectList AccountTypeId { get; set; }

        public IActionResult OnGet()
        {
            AccountTypeId = new SelectList(_context.AccountType, nameof(AccountType.Id), nameof(AccountType.Name));
            
            return Page();
        }

        public async Task<IActionResult> OnGetListAsync()
        {
            var test = new JsonResult(_context.BankingDetail.Include(x => x.AccountType).ToList());

            try
            {

                var result = JsonConvert.SerializeObject(test);
            }
            catch (Exception ex)
            {

                ;
            }



           

            return new JsonResult(await _context.BankingDetail.Include(x=>x.AccountType).ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.BankingDetail.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(BankingDetail BankingDetail)
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
