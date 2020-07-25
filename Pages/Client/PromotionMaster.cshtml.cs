﻿using System;
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
    public class PromotionMasterModel : PageModel
    {
        private readonly ClientDbContext _context;

        public PromotionMasterModel(ClientDbContext context)
        {
            _context = context;
        }



        [BindProperty]
        public PromotionMaster PromotionMaster { get; set; }

        [ViewData]
        public SelectList Relates { get; set; }

        [BindProperty]
        public List<RelatedTo> RelatedList { get; set; }
        
        private string errorMessage;

        // called first time the page is loaded.
        public IActionResult OnGet()
        {
            RelatedList = _context.RelatedTo.ToList();
            Relates = new SelectList(RelatedList, nameof(RelatedTo.Id), nameof(RelatedTo.Name));
            return Page();
        }

        // called to load and refresh grid
        public IActionResult OnGetList()
        {
            var pmlist = _context.PromotionMaster.Include(x=>x.RelatedTo).ToList();
            List <PromotionMasterVM> PromotionMasterVMList = new List<PromotionMasterVM>();
           
            try
            {
                foreach (var promotionMaster in pmlist)
                {
                    PromotionMasterVM pmVM = new PromotionMasterVM
                    {
                        Id = promotionMaster.Id,
                        Name = promotionMaster.Name,
                        Description = promotionMaster.Description,
                        StartDate = promotionMaster.StartDate,
                        EndDate = promotionMaster.EndDate,
                        BenefitStartDate = promotionMaster.BenefitStartDate,
                        BenefitEndDate = promotionMaster.BenefitEndDate,
                        RelatedToId = promotionMaster.RelatedTo.Id,
                        RelatedToName = promotionMaster.RelatedTo.Name,
                        IsActive = promotionMaster.IsActive   
                    };
                    PromotionMasterVMList.Add(pmVM);
                }
                return new JsonResult(PromotionMasterVMList);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return new JsonResult(new { success = false, message = "Error. Please check values entered "+ errorMessage });
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.PromotionMaster.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
        public async Task<IActionResult> OnPostSaveAsync(PromotionMaster PromotionMaster)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }
            if (PromotionMaster.Id > 0)
            {
                _context.Attach(PromotionMaster).State = EntityState.Modified;
            }
            else
            {
                _context.PromotionMaster.Add(PromotionMaster);
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

            PromotionMaster = await _context.PromotionMaster.FindAsync(id);

            if (PromotionMaster != null)
            {
                _context.PromotionMaster.Remove(PromotionMaster);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
