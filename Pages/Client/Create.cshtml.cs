using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MM.CoreModels;
using MM.ClientModels;

namespace MM.Pages.Client
{
    public class CreateModel : PageModel
    {
        private readonly CoreDBContext _context;

        public CreateModel(CoreDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ClientOrganization Client { get; set; }

        [BindProperty]
        public ClientUser ClientUser { get; set; }
   
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            string ConnectionString = _context.ClientDBConnectionMasters.FirstOrDefault().ConnectionString + Client.Name;


            DbEntry dbEntry = new DbEntry();
                dbEntry.DbName = "mm_" + Client.Name;
                dbEntry.ConnectionString = ConnectionString;
                _context.Dbentries.Add(dbEntry);
                await _context.SaveChangesAsync();

            ClientDbEntry ClientdbEntry = new ClientDbEntry();
                ClientdbEntry.Email = ClientUser.Email;
                ClientdbEntry.DbEntryId = dbEntry.Id;
                _context.Clientdbentries.Add(ClientdbEntry);
                await _context.SaveChangesAsync();

            ClientDbContext clientdbContext = new ClientDbContext(ConnectionString);
                clientdbContext.Database.EnsureCreated();
                //clientdbContext.ClientOrganization.Add(Client);
                //clientdbContext.User.Add(ClientUser);
                //await clientdbContext.SaveChangesAsync();
                return RedirectToPage("./Index");
        }
    }
}
