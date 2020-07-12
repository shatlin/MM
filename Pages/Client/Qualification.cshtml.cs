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
    public class QualificationModel : PageModel
    {
        private readonly ClientDbContext _context;

        public QualificationModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<Qualification> QualificationList { get;set; }

        [BindProperty]
        public Qualification Qualification { get; set; }

        public async Task<IActionResult> OnGetListAsync()
        {
            return new JsonResult(await _context.Qualification.ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.Qualification.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(Qualification Qualification)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (Qualification.Id > 0)
            {
                _context.Attach(Qualification).State = EntityState.Modified;
            }
            else
            {
                _context.Qualification.Add(Qualification);
            }
             await _context.SaveChangesAsync();
            return new JsonResult( new { success = true, message = "Saved successfully" });
        }

         public async Task<IActionResult> OnGetDeleteAsync(int? id)
        {

            if (id == null)
            {
                return new JsonResult(new { success = false, message = "No such reccord found to delete" });
            }

            Qualification = await _context.Qualification.FindAsync(id);

            if (Qualification != null)
            {
                _context.Qualification.Remove(Qualification);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such reccord found to delete" });

        }
    }
}
