using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MM.ClientModels;

namespace MM.Pages
{
    public class LogoutModel : PageModel
    {
        private readonly ClientDbContext _context;
        private readonly SignInManager<ClientUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;

        public LogoutModel(ClientDbContext context)
        {
            _context = context;
        }

        public LogoutModel(SignInManager<ClientUser> signInManager, ILogger<LoginModel> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]
        public ClientUser ClientUser { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            if (returnUrl != null)
            {
                return Redirect(returnUrl);
            }
            else
            {
                return Page();
            }
        }
    }
}
