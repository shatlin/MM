using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MM.ClientModels;

namespace MM.Pages.Client
{
    public class InvoiceSettingModel : PageModel
    {
        private readonly ClientDbContext _context;

        public InvoiceSettingModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<InvoiceSetting> InvoiceSettingList { get;set; }

        [BindProperty]
        public InvoiceSetting InvoiceSetting { get; set; }

        public async Task<IActionResult> OnGetListAsync()
        {
            return new JsonResult(await _context.InvoiceSetting.ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.InvoiceSetting.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(InvoiceSetting InvoiceSetting)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (InvoiceSetting.Id > 0)
            {
                _context.Attach(InvoiceSetting).State = EntityState.Modified;
            }
            else
            {
                _context.InvoiceSetting.Add(InvoiceSetting);
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

            InvoiceSetting = await _context.InvoiceSetting.FindAsync(id);

            if (InvoiceSetting != null)
            {
                _context.InvoiceSetting.Remove(InvoiceSetting);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
