using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MM.ClientModels;

namespace MM.Pages.Client
{
    [Authorize(Policy = "SetUp")]
    public class TitleModel : PageModel
    {
        private readonly ClientDbContext _context;
        private readonly IAuthorizationService _authorizationService;

        public TitleModel(ClientDbContext context, IAuthorizationService authorizationService)
        {
            _context = context;
            _authorizationService = authorizationService;
        }

        [BindProperty]
        public IList<Title> TitleList { get;set; }


        [ViewData]
        public bool AuthorizedForDelete{ get; set; }

        [BindProperty]
        public Title Title { get; set; }

        public async Task<IActionResult> OnGetListAsync()
        {
            return new JsonResult(await _context.Title.ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.Title.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(Title title)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (title.Id > 0)
            {
                _context.Attach(title).State = EntityState.Modified;
            }
            else
            {
                _context.Title.Add(title);
            }
             await _context.SaveChangesAsync();
            return new JsonResult( new { success = true, message = "Saved successfully" });
        }

         public async Task<IActionResult> OnGetDeleteAsync(int? id)
        {

            var isAuthorized = await _authorizationService.AuthorizeAsync(User, "AllowSetupDelete");

            if (!isAuthorized.Succeeded)
            {
                return new JsonResult(new { success = false, message = "Authorization failed." });
            }

            if (id == null)
            {
                return new JsonResult(new { success = false, message = "No such record found to delete" });
            }

            Title = await _context.Title.FindAsync(id);

            if (Title != null)
            {
                _context.Title.Remove(Title);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });
        }
    }
}
