using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MM.ClientModels;

namespace MM.Pages.Client
{
    public class RegisterOldModel : PageModel
    {
        private readonly ClientDbContext _context;

        public RegisterOldModel(ClientDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Title Title { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Title.Add(Title);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
