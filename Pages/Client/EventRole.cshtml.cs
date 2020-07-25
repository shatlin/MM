using System;
using System.Collections;
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
using Newtonsoft.Json;

namespace MM.Pages.Client
{
    public class EventRoleModel : PageModel
    {
        private readonly ClientDbContext _context;

        public EventRoleModel(ClientDbContext context)
        {
            _context = context;
        }



        [BindProperty]
        public EventRole EventRole { get; set; }

        [ViewData]
        public SelectList EventRoles { get; set; }

        [BindProperty]
        public List<Event> EventList { get; set; }
        
        private string errorMessage;

        // called first time the page is loaded.
        public IActionResult OnGet()
        {
            EventList = _context.Event.ToList();
            EventRoles = new SelectList(EventList, nameof(Event.Id), nameof(Event.EventUniqueName));
            return Page();
        }

        // called to load and refresh grid
        public IActionResult OnGetList()
        {
            var evlist = _context.EventRole.Include(x=>x.Event).ToList();
            List <EventRoleVM> EventRoleVMList = new List<EventRoleVM>();
           
            try
            {
                foreach (var eventRole in evlist)
                {
                    EventRoleVM evVM = new EventRoleVM
                    {
                        Id = EventRole.Id,
                        Name = EventRole.Name,
                        EventId = EventRole.Event.Id,
                        EventName = EventRole.Event.EventUniqueName,
                        Description = EventRole.Description
                        
                    };
                    EventRoleVMList.Add(evVM);
                }
                return new JsonResult(EventRoleVMList);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return new JsonResult(new { success = false, message = "Error. Please check values entered "+ errorMessage });
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.EventRole.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
        public async Task<IActionResult> OnPostSaveAsync(EventRole EventRole)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }
            if (EventRole.Id > 0)
            {
                _context.Attach(EventRole).State = EntityState.Modified;
            }
            else
            {
                _context.EventRole.Add(EventRole);
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

            EventRole = await _context.EventRole.FindAsync(id);

            if (EventRole != null)
            {
                _context.EventRole.Remove(EventRole);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
