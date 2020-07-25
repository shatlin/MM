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
    public class PlanMasterModel : PageModel
    {
        private readonly ClientDbContext _context;

        public PlanMasterModel(ClientDbContext context)
        {
            _context = context;
        }


        [BindProperty]
        public PlanMaster PlanMaster { get; set; }

        [ViewData]
        public SelectList MemberCategories { get; set; }

        [ViewData]
        public SelectList PaymentMethods { get; set; }

        [BindProperty]
        public List<MemberCategory> MemberCategoryList { get; set; }

        [BindProperty]
        public List<PaymentSetting> PaymentMethodList { get; set; }

        private string errorMessage;

        // called first time the page is loaded.
        public IActionResult OnGet()
        {
            MemberCategoryList = _context.MemberCategory.ToList();
            MemberCategories = new SelectList(MemberCategoryList, nameof(MemberCategory.Id), nameof(MemberCategory.Name));

            PaymentMethodList = _context.PaymentSetting.ToList();
            PaymentMethods = new SelectList(PaymentMethodList, nameof(PaymentSetting.Id), nameof(PaymentSetting.Name));
            
            return Page();

        }

        // called to load and refresh grid
        public IActionResult OnGetList()
        {
           
            var PlanMasterList = _context.PlanMaster.Include(x => x.PaymentMethod).Include(x=>x.MemberCategory).ToList();
            List <PlanMasterVM> PlanMasterVMList = new List<PlanMasterVM>();
            try
            {
                foreach (var planMaster in PlanMasterList)
                {
                    PlanMasterVM pmVM = new PlanMasterVM
                    {
                        Id = PlanMaster.Id,
                        Name = PlanMaster.Name,
                        Description = PlanMaster.Description,
                        MemberCategoryId = PlanMaster.MemberCategory.Id,
                        MemberCategoryName = PlanMaster.MemberCategory.Name,
                        IsLimited = PlanMaster.IsLimited,
                        LimitToMemberCount = PlanMaster.LimitToMemberCount,
                        ApplyTaxSettings = PlanMaster.ApplyTaxSettings,
                        PaymentMethodId = PlanMaster.PaymentMethod.Id,
                        PaymentMethodName = PlanMaster.PaymentMethod.Name,
                        CanPublicApply = PlanMaster.CanPublicApply,
                    };
                    PlanMasterVMList.Add(pmVM);
                }
                return new JsonResult(PlanMasterVMList);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return new JsonResult(new { success = false, message = "Error. Please check values entered "+ errorMessage });
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.PlanMaster.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
        public async Task<IActionResult> OnPostSaveAsync(PlanMaster PlanMaster)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }
            if (PlanMaster.Id > 0)
            {
                _context.Attach(PlanMaster).State = EntityState.Modified;
            }
            else
            {
                _context.PlanMaster.Add(PlanMaster);
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

            PlanMaster = await _context.PlanMaster.FindAsync(id);

            if (PlanMaster != null)
            {
                _context.PlanMaster.Remove(PlanMaster);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
