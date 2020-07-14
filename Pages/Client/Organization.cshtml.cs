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
    public class OrganizationModel : PageModel
    {
        private readonly ClientDbContext _context;

        public OrganizationModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<Organization> OrganizationList { get;set; }

        [BindProperty]
        public Organization Organization { get; set; }

        public async Task<IActionResult> OnGetListAsync()
        {
            return new JsonResult(await _context.Organization.ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.Organization.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(Organization Organization)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (Organization.Id > 0)
            {
                _context.Attach(Organization).State = EntityState.Modified;
            }
            else
            {
                _context.Organization.Add(Organization);
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

            Organization = await _context.Organization.FindAsync(id);

            if (Organization != null)
            {
                _context.Organization.Remove(Organization);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
