using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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



        public async Task<IActionResult> OnPostAsync()
        {

            foreach (var modelState in ViewData.ModelState.Values)
            {
                foreach (ModelError error in modelState.Errors)
                {
                   // error.des
                  //  DoSomethingWith(error);
                }
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ClientUser.Add(ClientUser);

            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }


    }
}
