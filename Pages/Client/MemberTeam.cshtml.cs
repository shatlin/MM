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
    public class MemberTeamModel : PageModel
    {
        private readonly ClientDbContext _context;

        public MemberTeamModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<MemberTeam> MemberTeamList { get;set; }

        [BindProperty]
        public MemberTeam MemberTeam { get; set; }

        public async Task<IActionResult> OnGetListAsync()
        {
            return new JsonResult(await _context.MemberTeam.ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.MemberTeam.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(MemberTeam MemberTeam)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (MemberTeam.Id > 0)
            {
                _context.Attach(MemberTeam).State = EntityState.Modified;
            }
            else
            {
                _context.MemberTeam.Add(MemberTeam);
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

            MemberTeam = await _context.MemberTeam.FindAsync(id);

            if (MemberTeam != null)
            {
                _context.MemberTeam.Remove(MemberTeam);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
