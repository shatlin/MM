using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MM.CoreModels;
using SaasKit.Multitenancy;

namespace MM.Pages.Member
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Tenant _tenant;
      
        public IndexModel(ILogger<IndexModel> logger,Tenant tenant)
        {
            _logger = logger;
            _tenant = tenant;
        }

        public IActionResult OnGet()
        {
            return Page();  
        }
    }
}
