using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LeaveManagement.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2272d930-5ab6-4c02-9eb1-febffde4814c",
                    UserId = "usr2d930-5ab6-4c02-9eb1-febffde4814c"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "9a825bb0-95db-498e-8369-d10fcfae6e98",
                    UserId = "usl25bb0-95db-498e-8369-d10fcfae6e98"
                }
             );
        }
    }
}
