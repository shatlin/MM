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
    public class CpdmemberCategorySetUpModel : PageModel
    {
        private readonly ClientDbContext _context;

        public CpdmemberCategorySetUpModel(ClientDbContext context)
        {
            _context = context;
        }



        [BindProperty]
        public CpdmemberCategorySetUp CpdmemberCategorySetUp { get; set; }

        [ViewData]
        public SelectList MemberCategories { get; set; }

        [ViewData]
        public SelectList RelatedTos { get; set; }

        [BindProperty]
        public List<MemberCategory> MemberCategoryList { get; set; }

        [BindProperty]
        public List<RelatedTo> RelatedToList { get; set; }

        private string errorMessage;

        // called first time the page is loaded.
        public IActionResult OnGet()
        {
            MemberCategoryList = _context.MemberCategory.ToList();
            MemberCategories = new SelectList(MemberCategoryList, nameof(MemberCategory.Id), nameof(MemberCategory.Name));

            RelatedToList = _context.RelatedTo.ToList();
            RelatedTos = new SelectList(RelatedToList, nameof(RelatedTo.Id), nameof(RelatedTo.Name));

            return Page();
        }

        // called to load and refresh grid
        public IActionResult OnGetList()
        {
            var mclist = _context.CpdmemberCategorySetUp.Include(x => x.MemberCategory).Include(x => x.RelatedTo).ToList();
            List <CpdmemberCategorySetUpVM> CpdmemberCategorySetUpVMList = new List<CpdmemberCategorySetUpVM>();
           
            try
            {
                foreach (var cpdmemberCategorySetUp in mclist)
                {
                    CpdmemberCategorySetUpVM eeVM = new CpdmemberCategorySetUpVM
                    {
                        Id = cpdmemberCategorySetUp.Id,
                        MemberCategoryId = cpdmemberCategorySetUp.MemberCategory.Id,
                        MemberCategoryName = cpdmemberCategorySetUp.MemberCategory.Name,
                        RelatedToId = cpdmemberCategorySetUp.RelatedTo.Id,
                        RelatedToName = cpdmemberCategorySetUp.RelatedTo.Name,
                        RelatedRecordId = cpdmemberCategorySetUp.RelatedRecordId,
                        Cpdcount = cpdmemberCategorySetUp.Cpdcount,
                    };
                    CpdmemberCategorySetUpVMList.Add(eeVM);
                }
                return new JsonResult(CpdmemberCategorySetUpVMList);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return new JsonResult(new { success = false, message = "Error. Please check values entered "+ errorMessage });
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.CpdmemberCategorySetUp.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
        public async Task<IActionResult> OnPostSaveAsync(CpdmemberCategorySetUp CpdmemberCategorySetUp)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }
            if (CpdmemberCategorySetUp.Id > 0)
            {
                _context.Attach(CpdmemberCategorySetUp).State = EntityState.Modified;
            }
            else
            {
                _context.CpdmemberCategorySetUp.Add(CpdmemberCategorySetUp);
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

            CpdmemberCategorySetUp = await _context.CpdmemberCategorySetUp.FindAsync(id);

            if (CpdmemberCategorySetUp != null)
            {
                _context.CpdmemberCategorySetUp.Remove(CpdmemberCategorySetUp);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
