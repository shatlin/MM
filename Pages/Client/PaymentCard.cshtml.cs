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
    public class PaymentCardModel : PageModel
    {
        private readonly ClientDbContext _context;

        public PaymentCardModel(ClientDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<PaymentCard> PaymentCardList { get;set; }

        [BindProperty]
        public PaymentCard PaymentCard { get; set; }

        public async Task<IActionResult> OnGetListAsync()
        {
            return new JsonResult(await _context.PaymentCard.ToListAsync());
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.PaymentCard.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
 
        public async Task<IActionResult> OnPostSaveAsync(PaymentCard PaymentCard)
        {

            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }

            if (PaymentCard.Id > 0)
            {
                _context.Attach(PaymentCard).State = EntityState.Modified;
            }
            else
            {
                _context.PaymentCard.Add(PaymentCard);
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

            PaymentCard = await _context.PaymentCard.FindAsync(id);

            if (PaymentCard != null)
            {
                _context.PaymentCard.Remove(PaymentCard);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
