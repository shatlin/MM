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
    public class TaxPolicyModel : PageModel
    {
        private readonly ClientDbContext _context;

        public TaxPolicyModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<TaxPolicy> TaxPolicyList { get;set; }

        [BindProperty]
        public TaxPolicy TaxPolicy { get; set; }

        public async Task<IActionResult> OnGetListAsync()
        {
            return new JsonResult(await _context.TaxPolicy.ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.TaxPolicy.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(TaxPolicy TaxPolicy)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (TaxPolicy.Id > 0)
            {
                _context.Attach(TaxPolicy).State = EntityState.Modified;
            }
            else
            {
                _context.TaxPolicy.Add(TaxPolicy);
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

            TaxPolicy = await _context.TaxPolicy.FindAsync(id);

            if (TaxPolicy != null)
            {
                _context.TaxPolicy.Remove(TaxPolicy);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
