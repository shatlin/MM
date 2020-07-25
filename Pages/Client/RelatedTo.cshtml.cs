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
    public class RelatedToModel : PageModel
    {
        private readonly ClientDbContext _context;

        public RelatedToModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<RelatedTo> RelatedToList { get;set; }

        [BindProperty]
        public RelatedTo RelatedTo { get; set; }

        public async Task<IActionResult> OnGetListAsync()
        {
            return new JsonResult(await _context.RelatedTo.ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.RelatedTo.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(RelatedTo RelatedTo)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (RelatedTo.Id > 0)
            {
                _context.Attach(RelatedTo).State = EntityState.Modified;
            }
            else
            {
                _context.RelatedTo.Add(RelatedTo);
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

            RelatedTo = await _context.RelatedTo.FindAsync(id);

            if (RelatedTo != null)
            {
                _context.RelatedTo.Remove(RelatedTo);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
