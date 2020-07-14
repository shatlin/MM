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
    public class EmailTypeModel : PageModel
    {
        private readonly ClientDbContext _context;

        public EmailTypeModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<EmailType> EmailTypeList { get;set; }

        [BindProperty]
        public EmailType EmailType { get; set; }

        public async Task<IActionResult> OnGetListAsync()
        {
            return new JsonResult(await _context.EmailType.ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.EmailType.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(EmailType EmailType)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (EmailType.Id > 0)
            {
                _context.Attach(EmailType).State = EntityState.Modified;
            }
            else
            {
                _context.EmailType.Add(EmailType);
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

            EmailType = await _context.EmailType.FindAsync(id);

            if (EmailType != null)
            {
                _context.EmailType.Remove(EmailType);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
