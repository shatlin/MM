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
    public class EventMinuteModel : PageModel
    {
        private readonly ClientDbContext _context;

        public EventMinuteModel(ClientDbContext context)
        {
            _context = context;
        }



        [BindProperty]
        public EventMinute EventMinute { get; set; }

        [ViewData]
        public SelectList Events { get; set; }

        [ViewData]
        public SelectList Status { get; set; }

        [BindProperty]
        public List<Event> EventList { get; set; }

        [BindProperty]
        public List<EventMinuteStatus> StatusList { get; set; }

        private string errorMessage;

        // called first time the page is loaded.
        public IActionResult OnGet()
        {
            EventList = _context.Event.ToList();
            Events = new SelectList(EventList, nameof(Event.Id), nameof(Event.EventUniqueName));

            StatusList = _context.EventMinuteStatus.ToList();
            Status = new SelectList(StatusList, nameof(EventMinuteStatus.Id), nameof(EventMinuteStatus.Name));

            return Page();
        }

        // called to load and refresh grid
        public IActionResult OnGetList()
        {
            var emlist = _context.EventMinute.Include(x => x.Event).Include(x => x.MinuteStatus).ToList();
            List <EventMinuteVM> EventMinuteVMList = new List<EventMinuteVM>();
           
            try
            {
                foreach (var eventMinute in emlist)
                {
                    EventMinuteVM emVM = new EventMinuteVM
                    {
                        Id = eventMinute.Id,
                        EventId = eventMinute.Event.Id,
                        EventName = eventMinute.Event.EventUniqueName,
                        MinuteStatusId = eventMinute.MinuteStatus.Id,
                        MinuteStatusName = eventMinute.MinuteStatus.Name,
                        Heading = eventMinute.Heading,
                        SubHeading = eventMinute.SubHeading,
                        Minute = eventMinute.Minute,
                        RaisedBy = eventMinute.RaisedBy,
                        AssignedTo = eventMinute.AssignedTo
                    };
                    EventMinuteVMList.Add(emVM);
                }
                return new JsonResult(EventMinuteVMList);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return new JsonResult(new { success = false, message = "Error. Please check values entered "+ errorMessage });
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.EventMinute.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
        public async Task<IActionResult> OnPostSaveAsync(EventMinute EventMinute)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }
            if (EventMinute.Id > 0)
            {
                _context.Attach(EventMinute).State = EntityState.Modified;
            }
            else
            {
                _context.EventMinute.Add(EventMinute);
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

            EventMinute = await _context.EventMinute.FindAsync(id);

            if (EventMinute != null)
            {
                _context.EventMinute.Remove(EventMinute);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
