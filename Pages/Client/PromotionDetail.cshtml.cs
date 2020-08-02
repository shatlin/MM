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
    public class PromotionDetailModel : PageModel
    {
        private readonly ClientDbContext _context;

        public PromotionDetailModel(ClientDbContext context)
        {
            _context = context;
        }



        [BindProperty]
        public PromotionDetail PromotionDetail { get; set; }

        [ViewData]
        public SelectList Promotions { get; set; }

        [ViewData]
        public SelectList Types { get; set; }

        [ViewData]
        public SelectList Levels { get; set; }

        [BindProperty]
        public List<PromotionMaster> PromotionList { get; set; }

        [BindProperty]
        public List<MemberType> TypeList { get; set; }

        [BindProperty]
        public List<MemberLevel> LevelList { get; set; }

        private string errorMessage;

        // called first time the page is loaded.
        public IActionResult OnGet()
        {
            PromotionList = _context.PromotionMaster.ToList();
            Promotions = new SelectList(PromotionList, nameof(PromotionMaster.Id), nameof(PromotionMaster.Name));

            TypeList = _context.MemberType.ToList();
            Types = new SelectList(TypeList, nameof(MemberType.Id), nameof(MemberType.Name));

            LevelList = _context.MemberLevel.ToList();
            Levels = new SelectList(LevelList, nameof(MemberLevel.Id), nameof(MemberLevel.Name));
            return Page();
        }

        // called to load and refresh grid
        public IActionResult OnGetList()
        {
            var pdlist = _context.PromotionDetail.Include(x => x.PromotionMaster).Include(x=>x.MemberType).Include(x => x.MemberLevel).ToList();
            List <PromotionDetailVM> PromotionDetailVMList = new List<PromotionDetailVM>();
           
            try
            {
                foreach (var promotionDetail in pdlist)
                {
                    PromotionDetailVM pdVM = new PromotionDetailVM
                    {
                        Id = PromotionDetail.Id,
                        PromotionMasterId= PromotionDetail.PromotionMaster.Id,
                        PromotionMasterName = PromotionDetail.PromotionMaster.Name,
                        MemberTypeId = PromotionDetail.MemberType.Id,
                        MemberTypeName = PromotionDetail.MemberType.Name,
                        MemberLevelId = PromotionDetail.MemberLevel.Id,
                        MemberLevelName = PromotionDetail.MemberLevel.Name,
                        DiscountPercentage = PromotionDetail.DiscountPercentage
   
                    };
                    PromotionDetailVMList.Add(pdVM);
                }
                return new JsonResult(PromotionDetailVMList);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return new JsonResult(new { success = false, message = "Error. Please check values entered "+ errorMessage });
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.PromotionDetail.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
        public async Task<IActionResult> OnPostSaveAsync(PromotionDetail PromotionDetail)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }
            if (PromotionDetail.Id > 0)
            {
                _context.Attach(PromotionDetail).State = EntityState.Modified;
            }
            else
            {
                _context.PromotionDetail.Add(PromotionDetail);
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

            PromotionDetail = await _context.PromotionDetail.FindAsync(id);

            if (PromotionDetail != null)
            {
                _context.PromotionDetail.Remove(PromotionDetail);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
