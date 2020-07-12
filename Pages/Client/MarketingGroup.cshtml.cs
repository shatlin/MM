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
    public class MarketingGroupModel : PageModel
    {
        private readonly ClientDbContext _context;

        public MarketingGroupModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<MarketingGroup> MarketingGroupList { get;set; }

        [BindProperty]
        public MarketingGroup MarketingGroup { get; set; }

        public async Task<IActionResult> OnGetListAsync()
        {
            return new JsonResult(await _context.MarketingGroup.ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.MarketingGroup.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(MarketingGroup MarketingGroup)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (MarketingGroup.Id > 0)
            {
                _context.Attach(MarketingGroup).State = EntityState.Modified;
            }
            else
            {
                _context.MarketingGroup.Add(MarketingGroup);
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

            MarketingGroup = await _context.MarketingGroup.FindAsync(id);

            if (MarketingGroup != null)
            {
                _context.MarketingGroup.Remove(MarketingGroup);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such reccord found to delete" });

        }
    }
}
