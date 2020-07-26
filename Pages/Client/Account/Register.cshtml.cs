using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
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
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly CoreDBContext coreDbConext;
        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger, RoleManager<ApplicationRole> roleManager,
            IEmailSender emailSender, CoreDBContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            coreDbConext = context;
            _roleManager = roleManager;
        }

        [BindProperty]
        public ClientUser ClientUser { get; set; }

        [BindProperty]
        public ApplicationUser AppUser { get; set; }

        public class AppUserInputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

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

                var tenantexists = coreDbConext.Tenant.Any(x => x.ClientName == ClientOrganization.Name);
                if (!tenantexists)
                {
                    Tenant tenant = new Tenant();
                    tenant.ClientName = ClientOrganization.Name;
                    tenant.DbName = "mm_" + ClientOrganization.Name;
                    tenant.ConnectionString = ConnectionString;
                    coreDbConext.Tenant.Add(tenant);
                    await coreDbConext.SaveChangesAsync();

                    var tenantuserexists = coreDbConext.TenantUserTenant.Any(x => x.Email == AppUser.Email);

                    if (!tenantuserexists)
                    {
                        TenantUserTenant tenantUserTenant = new TenantUserTenant();
                        tenantUserTenant.Email = AppUser.Email;
                        tenantUserTenant.TenantId = tenant.Id;
                        coreDbConext.TenantUserTenant.Add(tenantUserTenant);
                        await coreDbConext.SaveChangesAsync();
                    }
                }

                ClientDbContext clientDbContext = new ClientDbContext(ConnectionString);
                clientDbContext.Database.EnsureCreated();

                AppUser.UserName = AppUser.Email;
                AppUser.UserTypeId = 1;

                var result = await _userManager.CreateAsync(AppUser, AppUser.Pwd);

                if (result.Succeeded)
                {
                    clientDbContext.ClientOrganization.Add(ClientOrganization);

                    ClientUser.ApplicaitonUserId = AppUser.Id;
                    clientDbContext.ClientUser.Add(ClientUser);
                    await clientDbContext.SaveChangesAsync();
                    var adminfullAccessRole= new ApplicationRole("Admin-Full Access");
                    await _roleManager.CreateAsync(adminfullAccessRole);

                    var adminreadAccessRole = new ApplicationRole("Admin-Read Access");

                    await _roleManager.CreateAsync(adminreadAccessRole);

                    var noadminAccessRole = new ApplicationRole("No Admin Access");
                    await _roleManager.CreateAsync(noadminAccessRole);

                    var limitedadminAccessRole = new ApplicationRole("Limited Admin");
                    await _roleManager.CreateAsync(limitedadminAccessRole);

                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("Members","Create"));
                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("Members", "Edit"));
                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("Members", "Delete"));
                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("Members", "View"));

                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("Event", "Create"));
                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("Event", "Edit"));
                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("Event", "Delete"));
                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("Event", "View"));

                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("Donations", "Create"));
                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("Donations", "Edit"));
                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("Donations", "Delete"));
                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("Donations", "View"));

                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("NewLetter", "Create"));
                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("NewLetter", "Edit"));
                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("NewLetter", "Delete"));
                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("NewLetter", "View"));

                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("Setup", "Create"));
                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("Setup", "Edit"));
                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("Setup", "Delete"));
                    await _roleManager.AddClaimAsync(adminfullAccessRole, new Claim("Setup", "View"));

                    await _roleManager.AddClaimAsync(adminreadAccessRole, new Claim("Members", "View"));
                    await _roleManager.AddClaimAsync(adminreadAccessRole, new Claim("Event", "View"));
                    await _roleManager.AddClaimAsync(adminreadAccessRole, new Claim("Donations", "View"));
                    await _roleManager.AddClaimAsync(adminreadAccessRole, new Claim("NewLetter", "View"));
                    await _roleManager.AddClaimAsync(adminreadAccessRole, new Claim("Setup", "View"));


                    await _userManager.AddToRoleAsync(AppUser, "Admin-Full Access");

                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(AppUser);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Client/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = AppUser.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(AppUser.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = AppUser.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(AppUser, isPersistent: false);
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

