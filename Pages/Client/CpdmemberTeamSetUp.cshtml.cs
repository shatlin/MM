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
    public class CpdmemberTeamSetUpModel : PageModel
    {
        private readonly ClientDbContext _context;

        public CpdmemberTeamSetUpModel(ClientDbContext context)
        {
            _context = context;
        }



        [BindProperty]
        public CpdmemberTeamSetUp CpdmemberTeamSetUp { get; set; }

        [ViewData]
        public SelectList MemberTeams { get; set; }

        [ViewData]
        public SelectList RelatedTos { get; set; }

        [BindProperty]
        public List<MemberTeam> MemberTeamList { get; set; }

        [BindProperty]
        public List<RelatedTo> RelatedToList { get; set; }

        private string errorMessage;

        // called first time the page is loaded.
        public IActionResult OnGet()
        {
            MemberTeamList = _context.MemberTeam.ToList();
            MemberTeams = new SelectList(MemberTeamList, nameof(MemberTeam.Id), nameof(MemberTeam.Name));

            RelatedToList = _context.RelatedTo.ToList();
            RelatedTos = new SelectList(RelatedToList, nameof(RelatedTo.Id), nameof(RelatedTo.Name));

            return Page();
        }

        // called to load and refresh grid
        public IActionResult OnGetList()
        {
            var mtlist = _context.CpdmemberTeamSetUp.Include(x => x.MemberTeam).Include(x => x.RelatedTo).ToList();
            List <CpdmemberTeamSetUpVM> CpdmemberTeamSetUpVMList = new List<CpdmemberTeamSetUpVM>();
           
            try
            {
                foreach (var cpdmemberTeamSetUp in mtlist)
                {
                    CpdmemberTeamSetUpVM mlVM = new CpdmemberTeamSetUpVM
                    {
                        Id = cpdmemberTeamSetUp.Id,
                        MemberTeamlId = cpdmemberTeamSetUp.MemberTeam.Id,
                        MemberTeamName = cpdmemberTeamSetUp.MemberTeam.Name,
                        RelatedToId = cpdmemberTeamSetUp.RelatedTo.Id,
                        RelatedToName = cpdmemberTeamSetUp.RelatedTo.Name,
                        RelatedRecordId = cpdmemberTeamSetUp.RelatedRecordId,
                        Cpdcount = cpdmemberTeamSetUp.Cpdcount,
                    };
                    CpdmemberTeamSetUpVMList.Add(mlVM);
                }
                return new JsonResult(CpdmemberTeamSetUpVMList);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return new JsonResult(new { success = false, message = "Error. Please check values entered "+ errorMessage });
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.CpdmemberTeamSetUp.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
        public async Task<IActionResult> OnPostSaveAsync(CpdmemberTeamSetUp CpdmemberTeamSetUp)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }
            if (CpdmemberTeamSetUp.Id > 0)
            {
                _context.Attach(CpdmemberTeamSetUp).State = EntityState.Modified;
            }
            else
            {
                _context.CpdmemberTeamSetUp.Add(CpdmemberTeamSetUp);
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

            CpdmemberTeamSetUp = await _context.CpdmemberTeamSetUp.FindAsync(id);

            if (CpdmemberTeamSetUp != null)
            {
                _context.CpdmemberTeamSetUp.Remove(CpdmemberTeamSetUp);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
