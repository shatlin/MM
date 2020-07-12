using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MM.ClientModels;

namespace MM.Pages.Client
{
    public class EquipmentModel : PageModel
    {
        private readonly ClientDbContext _context;

        public EquipmentModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<Equipment> EquipmentList { get;set; }

        [BindProperty]
        public Equipment Equipment { get; set; }

        public async Task<IActionResult> OnGetListAsync()
        {
            return new JsonResult(await _context.Equipment.ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.Equipment.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(Equipment Equipment)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (Equipment.Id > 0)
            {
                _context.Attach(Equipment).State = EntityState.Modified;
            }
            else
            {
                _context.Equipment.Add(Equipment);
            }
             await _context.SaveChangesAsync();
            return new JsonResult( new { success = true, message = "Saved successfully" });
        }

         public async Task<IActionResult> OnGetDeleteAsync(int? id)
        {

            if (id == null)
            {
                return new JsonResult(new { success = false, message = "No such reccord found to delete" });
            }

            Equipment = await _context.Equipment.FindAsync(id);

            if (Equipment != null)
            {
                _context.Equipment.Remove(Equipment);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such reccord found to delete" });

        }
    }
}
