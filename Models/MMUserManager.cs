using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace MM.ClientModels
{
    public class MMUserManager : UserManager<ApplicationUser>
    {
        public string TenantId { get; set; }
        public MMUserManager(IUserStore<ApplicationUser> store, IOptions<IdentityOptions> optionsAccessor,
        IPasswordHasher<ApplicationUser> passwordHasher, IEnumerable<IUserValidator<ApplicationUser>> userValidators,
        IEnumerable<IPasswordValidator<ApplicationUser>> passwordValidators, ILookupNormalizer keyNormalizer,
        IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<ApplicationUser>> logger) : 
            base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
        }

        //public override Task CreateAsync(ApplicationUser user)
        //{
        //    if (user == null)
        //    {
        //        throw new ArgumentNullException("user");
        //    }

        //    return base.CreateAsync(user);
        //}

        public override async Task<IdentityResult> CreateAsync(ApplicationUser user, string Password)
        {
            ThrowIfDisposed();
        
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }
            //var result = dbContext.Users.Any(u => u.UserName == user.UserName && u.TenantId == user.TenantId);
            //if (result == true)
            //{
            //    return IdentityResult.Failed();
            //}
            return await base.CreateAsync(user, Password);
        }
    }






}
