using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MM.ClientModels;

namespace MM.Pages.Client
{
    public class RegisterModel : PageModel
    {
        private readonly ClientDbContext _context;

        public RegisterModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<ClientUser> ClientUserList { get; set; }

        [BindProperty]
        public ClientUser ClientUser { get; set; }

        [ViewData]
        public SelectList ClientTitles { get; set; }

        [ViewData]
        public SelectList ClientDesignations { get; set; }

        [ViewData]
        public SelectList ClientGenders { get; set; }

        [ViewData]
        public SelectList ClientReferralTypes { get; set; }


        public IActionResult OnGet()
        {
            ClientTitles = new SelectList(_context.Title, nameof(Title.Id), nameof(Title.Name));
            ClientDesignations = new SelectList(_context.Designation, nameof(Designation.Id), nameof(Designation.Name));
            ClientGenders = new SelectList(_context.Gender, nameof(Gender.Id), nameof(Gender.Name));
            ClientReferralTypes = new SelectList(_context.ReferralType, nameof(ReferralType.Id), nameof(ReferralType.Name));

            return Page();
        }


        public async Task<IActionResult> OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.ClientUser.Where(x => x.Id == id).FirstOrDefaultAsync());

        }

        public async Task<IActionResult> OnPostSaveAsync(ClientUser ClientUser)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (ClientUser.Id > 0)
            {
                _context.Attach(ClientUser).State = EntityState.Modified;
            }
            else
            {
                _context.ClientUser.Add(ClientUser);
            }
            await _context.SaveChangesAsync();
            return new JsonResult(new { success = true, message = "Saved successfully" });
        }

        public async Task<IActionResult> OnGetDeleteAsync(int? id)
        {

            if (id == null)
            {
                return new JsonResult(new { success = false, message = "No such reccord found to delete" });
            }
            ClientUser = await _context.ClientUser.FindAsync(id);

            if (ClientUser != null)
            {
                _context.ClientUser.Remove(ClientUser);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such reccord found to delete" });

        }
    }
}
