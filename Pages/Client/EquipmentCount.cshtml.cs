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
    public class EquipmentCountModel : PageModel
    {
        private readonly ClientDbContext _context;

        public EquipmentCountModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<EquipmentCount> EquipmentCountList { get; set; }

        [BindProperty]
        public EquipmentCount EquipmentCount { get; set; }

        [ViewData]
        public SelectList EquipmentIdList { get; set; }

        public IActionResult OnGet()
        {
            EquipmentIdList = new SelectList(_context.Equipment, nameof(Equipment.Id), nameof(Equipment.Name));
            
            return Page();
        }

        public async Task<IActionResult> OnGetListAsync()
        {

            return new JsonResult(await _context.EquipmentCount.ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.EquipmentCount.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(EquipmentCount EquipmentCount)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (EquipmentCount.Id > 0)
            {
                _context.Attach(EquipmentCount).State = EntityState.Modified;
            }
            else
            {
                _context.EquipmentCount.Add(EquipmentCount);
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

            EquipmentCount = await _context.EquipmentCount.FindAsync(id);

            if (EquipmentCount != null)
            {
                _context.EquipmentCount.Remove(EquipmentCount);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
