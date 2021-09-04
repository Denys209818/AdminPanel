using IdentityAdminPanel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityAdminPanel.Domain.Configuration
{
    public class IdentityConfiguration : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(keys => new { keys.RoleId, keys.UserId });

            builder.HasOne(virtualElementForEntityUser => virtualElementForEntityUser.User)
                .WithMany(virtualCollectionForEntityUser => virtualCollectionForEntityUser.UserRoles)
                .HasForeignKey(intElementWithForeignParam => intElementWithForeignParam.UserId)
                .IsRequired();

            builder.HasOne(virtualElementForEntityRole => virtualElementForEntityRole.Role)
                .WithMany(virtualCollectionForEntityRole => virtualCollectionForEntityRole.UserRoles)
                .HasForeignKey(intElementForEntityRole => intElementForEntityRole.RoleId)
                .IsRequired();
        }
    }
}
