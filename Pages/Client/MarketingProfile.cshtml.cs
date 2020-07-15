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
    public class MarketingProfileModel : PageModel
    {
        private readonly ClientDbContext _context;

        public MarketingProfileModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<MarketingProfile> MarketingProfileList { get;set; }

        [BindProperty]
        public MarketingProfile MarketingProfile { get; set; }

        public async Task<IActionResult> OnGetListAsync()
        {
            return new JsonResult(await _context.MarketingProfile.ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.MarketingProfile.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(MarketingProfile MarketingProfile)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (MarketingProfile.Id > 0)
            {
                _context.Attach(MarketingProfile).State = EntityState.Modified;
            }
            else
            {
                _context.MarketingProfile.Add(MarketingProfile);
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

            MarketingProfile = await _context.MarketingProfile.FindAsync(id);

            if (MarketingProfile != null)
            {
                _context.MarketingProfile.Remove(MarketingProfile);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
