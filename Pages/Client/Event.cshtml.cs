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
    public class ClientOrgModel : PageModel
    {
        private readonly ClientDbContext _context;

        public ClientOrgModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ClientOrganization ClientOrganization { get; set; }

        [ViewData]
        public SelectList OrgDateSettings { get; set; }

        [ViewData]
        public SelectList OrgTimeFormat { get; set; }

        [ViewData]
        public SelectList OrgTimeZone { get; set; }

        [ViewData]
        public SelectList OrgCurrency { get; set; }


        public IActionResult OnGet()
        {
            OrgDateSettings = new SelectList(_context.DateSetting, nameof(DateSetting.Id), nameof(DateSetting.Name));
            OrgTimeFormat = new SelectList(_context.TimeFormat, nameof(TimeFormat.Id), nameof(TimeFormat.Name));
            OrgTimeZone = new SelectList(_context.ClientTimeZone, nameof(ClientTimeZone.Id), nameof(ClientTimeZone.Name));
            OrgCurrency = new SelectList(_context.Currency, nameof(Currency.Id), nameof(Currency.Name));
            return Page();
        }



        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ClientOrganization.Add(ClientOrganization);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }


    }
}
