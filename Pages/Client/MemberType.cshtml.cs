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
    public class MemberTypeModel : PageModel
    {
        private readonly ClientDbContext _context;

        public MemberTypeModel(ClientDbContext context)
        {
            _context = context;
        }



        [BindProperty]
        public MemberType MemberType { get; set; }

        [ViewData]
        public SelectList MemberCategories { get; set; }

        [BindProperty]
        public List<MemberCategory> MemberCategoryList { get; set; }
        
        private string errorMessage;

        // called first time the page is loaded.
        public IActionResult OnGet()
        {
            MemberCategoryList = _context.MemberCategory.ToList();
            MemberCategories = new SelectList(MemberCategoryList, nameof(MemberCategory.Id), nameof(MemberCategory.Name));
            return Page();
        }

        // called to load and refresh grid
        public IActionResult OnGetList()
        {
            var mclist = _context.MemberType.Include(x=>x.MemberCategory).ToList();
            List <MemberTypeVM> MemberTypeVMList = new List<MemberTypeVM>();
           
            try
            {
                foreach (var memberType in mclist)
                {
                    MemberTypeVM mtVM = new MemberTypeVM
                    {
                        Id = memberType.Id,
                        Name = memberType.Name,
                        MemberCategoryId = memberType.MemberCategory.Id,
                        MemberCategoryName = memberType.MemberCategory.Name,
                        Description = memberType.Description
                        
                    };
                    MemberTypeVMList.Add(mtVM);
                }
                return new JsonResult(MemberTypeVMList);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return new JsonResult(new { success = false, message = "Error. Please check values entered "+ errorMessage });
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.MemberType.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
        public async Task<IActionResult> OnPostSaveAsync(MemberType MemberType)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }
            if (MemberType.Id > 0)
            {
                _context.Attach(MemberType).State = EntityState.Modified;
            }
            else
            {
                _context.MemberType.Add(MemberType);
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

            MemberType = await _context.MemberType.FindAsync(id);

            if (MemberType != null)
            {
                _context.MemberType.Remove(MemberType);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
