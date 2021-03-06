using IdentityAdminPanel.Domain.Configuration;
using IdentityAdminPanel.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityAdminPanel.Domain
{
    public class EFContext : IdentityDbContext<AppUser, AppRole, long, 
        IdentityUserClaim<long>, AppUserRole, IdentityUserLogin<long>, 
        IdentityRoleClaim<long>, IdentityUserToken<long>>
    {
        public EFContext(DbContextOptions opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Identity
                builder.ApplyConfiguration(new IdentityConfiguration());
            #endregion
        }
    }
}
