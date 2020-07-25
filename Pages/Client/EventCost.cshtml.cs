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
    public class EventCostModel : PageModel
    {
        private readonly ClientDbContext _context;

        public EventCostModel(ClientDbContext context)
        {
            _context = context;
        }



        [BindProperty]
        public EventCost EventCost { get; set; }

        [ViewData]
        public SelectList Events { get; set; }

        [ViewData]
        public SelectList EventCostItems { get; set; }

        [BindProperty]
        public List<Event> EventList { get; set; }

        [BindProperty]
        public List<EventCostItem> EventCostItemList { get; set; }

        private string errorMessage;

        // called first time the page is loaded.
        public IActionResult OnGet()
        {
            EventList = _context.Event.ToList();
            Events = new SelectList(EventList, nameof(Event.Id), nameof(Event.EventUniqueName));

            EventCostItemList = _context.EventCostItem.ToList();
            Events = new SelectList(EventCostItemList, nameof(EventCostItem.Id), nameof(EventCostItem.Name));

            return Page();
        }

        // called to load and refresh grid
        public IActionResult OnGetList()
        {
            var eclist = _context.EventCost.Include(x => x.Event).Include(x => x.EventCostItem).ToList();
            List <EventCostVM> EventCostVMList = new List<EventCostVM>();
           
            try
            {
                foreach (var eventCost in eclist)
                {
                    EventCostVM ecVM = new EventCostVM
                    {
                        Id = eventCost.Id,
                        EventCostItemId = eventCost.EventCostItem.Id,
                        EventCostItemName = eventCost.EventCostItem.Name,
                        EventId = eventCost.Event.Id,
                        EventName = eventCost.Event.EventUniqueName,
                        IsActive = eventCost.IsActive,
                        Amount = eventCost.Amount
                    };
                    EventCostVMList.Add(ecVM);
                }
                return new JsonResult(EventCostVMList);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return new JsonResult(new { success = false, message = "Error. Please check values entered "+ errorMessage });
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.EventCost.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
        public async Task<IActionResult> OnPostSaveAsync(EventCost EventCost)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }
            if (EventCost.Id > 0)
            {
                _context.Attach(EventCost).State = EntityState.Modified;
            }
            else
            {
                _context.EventCost.Add(EventCost);
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

            EventCost = await _context.EventCost.FindAsync(id);

            if (EventCost != null)
            {
                _context.EventCost.Remove(EventCost);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
