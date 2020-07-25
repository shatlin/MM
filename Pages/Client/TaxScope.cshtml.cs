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
    public class TaxScopeModel : PageModel
    {
        private readonly ClientDbContext _context;

        public TaxScopeModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<TaxScope> TaxScopeList { get;set; }

        [BindProperty]
        public TaxScope TaxScope { get; set; }

        public async Task<IActionResult> OnGetListAsync()
        {
            return new JsonResult(await _context.TaxScope.ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.TaxScope.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(TaxScope TaxScope)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (TaxScope.Id > 0)
            {
                _context.Attach(TaxScope).State = EntityState.Modified;
            }
            else
            {
                _context.TaxScope.Add(TaxScope);
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

            TaxScope = await _context.TaxScope.FindAsync(id);

            if (TaxScope != null)
            {
                _context.TaxScope.Remove(TaxScope);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
