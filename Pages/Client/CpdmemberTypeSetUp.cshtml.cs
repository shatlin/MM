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
    public class CpdmemberTypeSetUpModel : PageModel
    {
        private readonly ClientDbContext _context;

        public CpdmemberTypeSetUpModel(ClientDbContext context)
        {
            _context = context;
        }



        [BindProperty]
        public CpdmemberTypeSetUp CpdmemberTypeSetUp { get; set; }

        [ViewData]
        public SelectList MemberTypes { get; set; }

        [ViewData]
        public SelectList RelatedTos { get; set; }

        [BindProperty]
        public List<MemberType> MemberTypeList { get; set; }

        [BindProperty]
        public List<RelatedTo> RelatedToList { get; set; }

        private string errorMessage;

        // called first time the page is loaded.
        public IActionResult OnGet()
        {
            MemberTypeList = _context.MemberType.ToList();
            MemberTypes = new SelectList(MemberTypeList, nameof(MemberType.Id), nameof(MemberType.Name));

            RelatedToList = _context.RelatedTo.ToList();
            RelatedTos = new SelectList(RelatedToList, nameof(RelatedTo.Id), nameof(RelatedTo.Name));

            return Page();
        }

        // called to load and refresh grid
        public IActionResult OnGetList()
        {
            var mtlist = _context.CpdmemberTypeSetUp.Include(x => x.MemberType).Include(x => x.RelatedTo).ToList();
            List <CpdmemberTypeSetUpVM> CpdmemberTypeSetUpVMList = new List<CpdmemberTypeSetUpVM>();
           
            try
            {
                foreach (var cpdmemberTypeSetUp in mtlist)
                {
                    CpdmemberTypeSetUpVM mtVM = new CpdmemberTypeSetUpVM
                    {
                        Id = cpdmemberTypeSetUp.Id,
                        MemberTypelId = cpdmemberTypeSetUp.MemberType.Id,
                        MemberTypeName = cpdmemberTypeSetUp.MemberType.Name,
                        RelatedToId = cpdmemberTypeSetUp.RelatedTo.Id,
                        RelatedToName = cpdmemberTypeSetUp.RelatedTo.Name,
                        RelatedRecordId = cpdmemberTypeSetUp.RelatedRecordId,
                        Cpdcount = cpdmemberTypeSetUp.Cpdcount,
                    };
                    CpdmemberTypeSetUpVMList.Add(mtVM);
                }
                return new JsonResult(CpdmemberTypeSetUpVMList);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return new JsonResult(new { success = false, message = "Error. Please check values entered "+ errorMessage });
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.CpdmemberTypeSetUp.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
        public async Task<IActionResult> OnPostSaveAsync(CpdmemberTypeSetUp CpdmemberTypeSetUp)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }
            if (CpdmemberTypeSetUp.Id > 0)
            {
                _context.Attach(CpdmemberTypeSetUp).State = EntityState.Modified;
            }
            else
            {
                _context.CpdmemberTypeSetUp.Add(CpdmemberTypeSetUp);
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

            CpdmemberTypeSetUp = await _context.CpdmemberTypeSetUp.FindAsync(id);

            if (CpdmemberTypeSetUp != null)
            {
                _context.CpdmemberTypeSetUp.Remove(CpdmemberTypeSetUp);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
