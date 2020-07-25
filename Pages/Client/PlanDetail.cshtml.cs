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
    public class PlanDetailModel : PageModel
    {
        private readonly ClientDbContext _context;

        public PlanDetailModel(ClientDbContext context)
        {
            _context = context;
        }



        [BindProperty]
        public PlanDetail PlanDetail { get; set; }

        [ViewData]
        public SelectList Plans { get; set; }

        [ViewData]
        public SelectList Currencies { get; set; }

        [ViewData]
        public SelectList Frequencies { get; set; }

        [BindProperty]
        public List<PlanMaster> PlanList { get; set; }

        [BindProperty]
        public List<Currency> CurrencyList { get; set; }

        [BindProperty]
        public List<PlanFrequency> FrequencyList { get; set; }

        private string errorMessage;

        // called first time the page is loaded.
        public IActionResult OnGet()
        {
            PlanList = _context.PlanMaster.ToList();
            Plans = new SelectList(PlanList, nameof(PlanMaster.Id), nameof(PlanMaster.Name));

            CurrencyList = _context.Currency.ToList();
            Currencies = new SelectList(CurrencyList, nameof(Currency.Id), nameof(Currency.Name));

            FrequencyList = _context.PlanFrequency.ToList();
            Frequencies = new SelectList(FrequencyList, nameof(PlanFrequency.Id), nameof(PlanFrequency.Name));
            return Page();
        }

        // called to load and refresh grid
        public IActionResult OnGetList()
        {
            var pdlist = _context.PlanDetail.Include(x => x.PlanMaster).Include(x=>x.Currency).Include(x => x.PlanFrequency).ToList();
            List <PlanDetailVM> PlanDetailVMList = new List<PlanDetailVM>();
           
            try
            {
                foreach (var planDetail in pdlist)
                {
                    PlanDetailVM pdVM = new PlanDetailVM
                    {
                        Id = planDetail.Id,
                        PlanMasterId= planDetail.PlanMaster.Id,
                        PlanMasterName = planDetail.PlanMaster.Name,
                        CurrencyId = planDetail.Currency.Id,
                        CurrencyName = planDetail.Currency.Name,
                        PlanFrequencyId = planDetail.PlanFrequency.Id,
                        PlanFrequencyName = planDetail.PlanFrequency.Name,
                        Amount = planDetail.Amount
                        
                    };
                    PlanDetailVMList.Add(pdVM);
                }
                return new JsonResult(PlanDetailVMList);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return new JsonResult(new { success = false, message = "Error. Please check values entered "+ errorMessage });
        }

        public async Task<IActionResult>  OnGetSelectedRecordAsync(int id)
        {
            return new JsonResult(await _context.PlanDetail.Where(x=>x.Id==id).FirstOrDefaultAsync());
        }
    
        public async Task<IActionResult> OnPostSaveAsync(PlanDetail PlanDetail)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult(new { success = false, message = "Error. Please check values entered" });
            }
            if (PlanDetail.Id > 0)
            {
                _context.Attach(PlanDetail).State = EntityState.Modified;
            }
            else
            {
                _context.PlanDetail.Add(PlanDetail);
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

            PlanDetail = await _context.PlanDetail.FindAsync(id);

            if (PlanDetail != null)
            {
                _context.PlanDetail.Remove(PlanDetail);
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true, message = "Deleted successfully" });
            }
            return new JsonResult(new { success = false, message = "No such record found to delete" });

        }
    }
}
