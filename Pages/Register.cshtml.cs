using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MM.ClientModels;

namespace MM.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly ClientDbContext _context;

        public RegisterModel(ClientDbContext context)
        {
            _context = context;
        }

        private readonly SignInManager<ClientUser> _signInManager;
        private readonly UserManager<ClientUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<ClientUser> userManager,
            SignInManager<ClientUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }


        [BindProperty]
        public ClientUser ClientUser { get; set; }

        [ViewData]
        public SelectList ClientTitles { get; set; }

        [ViewData]
        public SelectList ClientDesignations { get; set; }

        [ViewData]
        public SelectList ClientGenders { get; set; }

        [ViewData]
        public SelectList ClientReferralTypes { get; set; }

        public string ReturnUrl { get; set; }

        public IActionResult OnGet()
        {
            ClientTitles = new SelectList(_context.Title, nameof(Title.Id), nameof(Title.Name));
            ClientDesignations = new SelectList(_context.Designation, nameof(Designation.Id), nameof(Designation.Name));
            ClientGenders = new SelectList(_context.Gender, nameof(Gender.Id), nameof(Gender.Name));
            ClientReferralTypes = new SelectList(_context.ReferralType, nameof(ReferralType.Id), nameof(ReferralType.Name));
            
            return Page();
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }


        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    _context.ClientUser.Add(ClientUser);
        //    await _context.SaveChangesAsync();
        //    return RedirectToPage("./Index");
        //}

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
          
                var result = await _userManager.CreateAsync(ClientUser, ClientUser.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("New user created.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(ClientUser);
                    var callbackUrl = Url.Page(
                        "/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = ClientUser.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(ClientUser.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    await _signInManager.SignInAsync(ClientUser, isPersistent: false);

                    if (string.IsNullOrWhiteSpace(returnUrl))
                    {
                        return LocalRedirect("~/");
                    }
                    else
                    {
                        return Redirect(returnUrl);
                    }

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            // If we got this far, something failed, redisplay form
            return Page();
        }


    }
}
