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
    public class MemberStatusModel : PageModel
    {
        private readonly ClientDbContext _context;

        public MemberStatusModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<MemberStatus> MemberStatusList { get;set; }

        [BindProperty]
        public MemberStatus MemberStatus { get; set; }

        public async Task<IActionResult> OnGetListAsync()
        {
            return new JsonResult(await _context.MemberStatus.ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.MemberStatus.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(MemberStatus MemberStatus)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (MemberStatus.Id > 0)
            {
                _context.Attach(MemberStatus).State = EntityState.Modified;
            }
            else
            {
                _context.MemberStatus.Add(MemberStatus);
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

            MemberStatus = await _context.MemberStatus.FindAsync(id);

            if (MemberStatus != null)
            {
                _context.MemberStatus.Remove(MemberStatus);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such reccord found to delete" });

        }
    }
}
