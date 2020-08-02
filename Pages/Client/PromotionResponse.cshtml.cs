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
    public class PromotionResponseModel : PageModel
    {
        private readonly ClientDbContext _context;

        public PromotionResponseModel(ClientDbContext context)
        {
            _context = context;
        }



        [BindProperty]
        public PromotionResponse PromotionResponse { get; set; }

        [ViewData]
        public SelectList Promotions { get; set; }

        [ViewData]
        public List<SelectListItem> Members { get; set; }

        [ViewData]
        public SelectList ResponseTypes { get; set; }

        [BindProperty]
        public List<PromotionMaster> PromotionList { get; set; }

        [BindProperty]
        public List<MemberUser> MembersList { get; set; }

        [BindProperty]
        public List<PromotionResponseType> ResponseList { get; set; }

        private string errorMessage;

        // called first time the page is loaded.
        public IActionResult OnGet()
        {
            PromotionList = _context.PromotionMaster.ToList();
            Promotions = new SelectList(PromotionList, nameof(PromotionMaster.Id), nameof(PromotionMaster.Name));

            MembersList = _context.MemberUser.ToList();
            Members = new List<SelectListItem>();

            foreach (var memberUser in MembersList)
            {
                Members.Add(new SelectListItem
                {
                    Value = memberUser.Id.ToString(),
                    Text = memberUser.ApplicationUser.FirstName
                });
            }

            ResponseList = _context.PromotionResponseType.ToList();
            ResponseTypes = new SelectList(ResponseList, nameof(PromotionResponseType.Id), nameof(PromotionResponseType.Name));

            return Page();
        }

        // called to load and refresh grid
        public IActionResult OnGetList()
        {
            var prList = _context.PromotionResponse.Include(x => x.PromotionMaster).Include(x => x.Member.ApplicationUser).Include(x => x.PromotionResponseType).ToList();
            List<PromotionResponseVM> PromotionResponseVMList = new List<PromotionResponseVM>();

            try
            {
                foreach (var promotionResponse in prList)
                {
                    PromotionResponseVM prVM = new PromotionResponseVM
                    {
                        Id = promotionResponse.Id,
                        PromotionMasterId = promotionResponse.PromotionMaster.Id,
                        PromotionMasterName = promotionResponse.PromotionMaster.Name,
                        MemberId = promotionResponse.Member.Id,
                        MemberFirstName = promotionResponse.Member.ApplicationUser.FirstName,
                        MemberLastName = promotionResponse.Member.ApplicationUser.LastName,
                        PromotionResponseTypeId = promotionResponse.PromotionResponseTypeNavigation.Id,
                        PromotionResponseTypeName = promotionResponse.PromotionResponseTypeNavigation.Name,
                        ResponseDate = promotionResponse.ResponseDate
                    };
                    PromotionResponseVMList.Add(prVM);
                }
                return new JsonResult(PromotionResponseVMList);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return new JsonResult(new { success = false, message = "Error. Please check values entered "+ errorMessage });
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.PromotionResponse.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
        public async Task<IActionResult> OnPostSaveAsync(PromotionResponse PromotionResponse)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }
            if (PromotionResponse.Id > 0)
            {
                _context.Attach(PromotionResponse).State = EntityState.Modified;
            }
            else
            {
                _context.PromotionResponse.Add(PromotionResponse);
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

            PromotionResponse = await _context.PromotionResponse.FindAsync(id);

            if (PromotionResponse != null)
            {
                _context.PromotionResponse.Remove(PromotionResponse);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
