using LeaveManagementWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Xml.Linq;

namespace LeaveManagementWeb.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "usr2d930-5ab6-4c02-9eb1-febffde4814c",
                    UserName = "buteskul5.6@gmail.com",
                    NormalizedUserName = "BUTESKUL5.6@GMAIL.COM",
                    FirstName = "Admin",                    
                    LastName = "System",
                    Email = "buteskul5.6@gmail.com",
                    NormalizedEmail = "BUTESKUL5.6@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "@Dmin12"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "usl25bb0-95db-498e-8369-d10fcfae6e98",
                    UserName = "user@localhost.com",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    FirstName = "USER",
                    LastName = "System",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "@Dmin12"),
                    EmailConfirmed = true
                }
            );
        }
    }
}