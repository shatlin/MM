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
    public class MemberLevelModel : PageModel
    {
        private readonly ClientDbContext _context;

        public MemberLevelModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<MemberLevel> MemberLevelList { get;set; }

        [BindProperty]
        public MemberLevel MemberLevel { get; set; }

        public async Task<IActionResult> OnGetListAsync()
        {
            return new JsonResult(await _context.MemberLevel.ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.MemberLevel.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(MemberLevel MemberLevel)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (MemberLevel.Id > 0)
            {
                _context.Attach(MemberLevel).State = EntityState.Modified;
            }
            else
            {
                _context.MemberLevel.Add(MemberLevel);
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

            MemberLevel = await _context.MemberLevel.FindAsync(id);

            if (MemberLevel != null)
            {
                _context.MemberLevel.Remove(MemberLevel);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such reccord found to delete" });

        }
    }
}
