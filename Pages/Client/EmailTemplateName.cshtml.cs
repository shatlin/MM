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
    public class EmailTemplateNameModel : PageModel
    {
        private readonly ClientDbContext _context;

        public EmailTemplateNameModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<EmailTemplateName> EmailTemplateNameList { get;set; }

        [BindProperty]
        public EmailTemplateName EmailTemplateName { get; set; }

        public async Task<IActionResult> OnGetListAsync()
        {
            return new JsonResult(await _context.EmailTemplateName.ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.EmailTemplateName.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(EmailTemplateName EmailTemplateName)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (EmailTemplateName.Id > 0)
            {
                _context.Attach(EmailTemplateName).State = EntityState.Modified;
            }
            else
            {
                _context.EmailTemplateName.Add(EmailTemplateName);
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

            EmailTemplateName = await _context.EmailTemplateName.FindAsync(id);

            if (EmailTemplateName != null)
            {
                _context.EmailTemplateName.Remove(EmailTemplateName);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
