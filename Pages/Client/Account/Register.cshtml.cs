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
using MM.CoreModels;

namespace MM.Pages.Client.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly CoreDBContext coreDbConext;
        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender, CoreDBContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            coreDbConext = context;
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
            OrgDateSettings = new SelectList(coreDbConext.CoreDateSetting, nameof(CoreDateSetting.Id), nameof(CoreDateSetting.Name));
            OrgTimeFormat = new SelectList(coreDbConext.CoreTimeFormat, nameof(CoreTimeFormat.Id), nameof(CoreTimeFormat.Name));
            OrgTimeZone = new SelectList(coreDbConext.CoreTimeZone, nameof(CoreTimeZone.Id), nameof(CoreTimeZone.Description));
            OrgCurrency = new SelectList(coreDbConext.CoreCurrency, nameof(CoreCurrency.Id), nameof(CoreCurrency.Name));
            ClientTitles = new SelectList(coreDbConext.CoreTitle, nameof(CoreTitle.Id), nameof(CoreTitle.Name));
            ClientDesignations = new SelectList(coreDbConext.CoreDesignation, nameof(CoreDesignation.Id), nameof(CoreDesignation.Name));
            ClientGenders = new SelectList(coreDbConext.CoreGender, nameof(CoreGender.Id), nameof(CoreGender.Name));
            ClientReferralTypes = new SelectList(coreDbConext.CoreReferralType, nameof(CoreReferralType.Id), nameof(CoreReferralType.Name));
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {


                string ConnectionString = coreDbConext.TenantConfig.FirstOrDefault().ConnectionString + ClientOrganization.Name;

                Tenant tenant = new Tenant();
                tenant.ClientName =ClientOrganization.Name;
                tenant.DbName = "mm_" + ClientOrganization.Name;
                tenant.ConnectionString = ConnectionString;
                coreDbConext.Tenant.Add(tenant);
                await coreDbConext.SaveChangesAsync();

                TenantUserTenant tenantUserTenant = new TenantUserTenant();
                tenantUserTenant.Email = ClientUser.Email;
                tenantUserTenant.TenantId = tenant.Id;
                coreDbConext.TenantUserTenant.Add(tenantUserTenant);
                await coreDbConext.SaveChangesAsync();

                ClientDbContext clientDbContext = new ClientDbContext(ConnectionString);
                clientDbContext.Database.EnsureCreated();

                var user = new IdentityUser { UserName = ClientUser.Email, Email = ClientUser.Email };
                var result = await _userManager.CreateAsync(user, ClientUser.Password);

                if (result.Succeeded)
                {
                    clientDbContext.ClientOrganization.Add(ClientOrganization);
                    clientDbContext.ClientUser.Add(ClientUser);
                    await clientDbContext.SaveChangesAsync();

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
            
            return Page();
        }
    }
}

