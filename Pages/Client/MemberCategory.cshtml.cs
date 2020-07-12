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
    public class MemberCategoryModel : PageModel
    {
        private readonly ClientDbContext _context;

        public MemberCategoryModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<MemberCategory> MemberCategoryList { get;set; }

        [BindProperty]
        public MemberCategory MemberCategory { get; set; }

        public async Task<IActionResult> OnGetListAsync()
        {
            return new JsonResult(await _context.MemberCategory.ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.MemberCategory.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(MemberCategory MemberCategory)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (MemberCategory.Id > 0)
            {
                _context.Attach(MemberCategory).State = EntityState.Modified;
            }
            else
            {
                _context.MemberCategory.Add(MemberCategory);
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

            MemberCategory = await _context.MemberCategory.FindAsync(id);

            if (MemberCategory != null)
            {
                _context.MemberCategory.Remove(MemberCategory);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such reccord found to delete" });

        }
    }
}
