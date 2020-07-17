using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using MM.ClientModels;

namespace MM.Pages.Client.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ClientDbContext _context;
        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender, ClientDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _context = context;
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

        [BindProperty]
        public ClientOrganization ClientOrganization { get; set; }

        [ViewData]
        public SelectList OrgDateSettings { get; set; }

        [ViewData]
        public SelectList OrgTimeFormat { get; set; }

        [ViewData]
        public SelectList OrgTimeZone { get; set; }

        [ViewData]
        public SelectList OrgCurrency { get; set; }


        public string ReturnUrl { get; set; }


        public IList<AuthenticationScheme> ExternalLogins { get; set; }

      

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            OrgDateSettings = new SelectList(_context.DateSetting, nameof(DateSetting.Id), nameof(DateSetting.Name));
            OrgTimeFormat = new SelectList(_context.TimeFormat, nameof(TimeFormat.Id), nameof(TimeFormat.Name));
            OrgTimeZone = new SelectList(_context.ClientTimeZone, nameof(ClientTimeZone.Id), nameof(ClientTimeZone.Name));
            OrgCurrency = new SelectList(_context.Currency, nameof(Currency.Id), nameof(Currency.Name));
            ClientTitles = new SelectList(_context.Title, nameof(Title.Id), nameof(Title.Name));
            ClientDesignations = new SelectList(_context.Designation, nameof(Designation.Id), nameof(Designation.Name));
            ClientGenders = new SelectList(_context.Gender, nameof(Gender.Id), nameof(Gender.Name));
            ClientReferralTypes = new SelectList(_context.ReferralType, nameof(ReferralType.Id), nameof(ReferralType.Name));
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
          
                var user = new IdentityUser { UserName = ClientUser.Email, Email = ClientUser.Email };
                var result = await _userManager.CreateAsync(user, ClientUser.Password);
                if (result.Succeeded)
                {
                    _context.ClientOrganization.Add(ClientOrganization);
                    _context.ClientUser.Add(ClientUser);
                    await _context.SaveChangesAsync();

                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Client/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(ClientUser.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = ClientUser.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
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

