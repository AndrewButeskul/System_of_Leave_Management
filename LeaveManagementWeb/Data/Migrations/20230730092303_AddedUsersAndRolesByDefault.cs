using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedUsersAndRolesByDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2272d930-5ab6-4c02-9eb1-febffde4814c", "0d0ce428-d8b5-4fda-98a0-4b715ffbd68d", "Admin", "ADMIN" },
                    { "9a825bb0-95db-498e-8369-d10fcfae6e98", "1e514db6-7916-42dc-8dbd-a3a82a70916e", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2272d930-5ab6-4c02-9eb1-febffde4814c", 0, "9223be51-2502-4472-bed3-bd5767b625af", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "buteskul5.6@gmail.com", true, "Admin", "System", false, null, "BUTESKUL5.6@GMAIL.COM", "SUPERVISOR", "AQAAAAEAACcQAAAAELHKzWmNCQ8yJCHgmy0dt25mGHw3ne+jU7kpuQbERa0ud18cVpciJm3RBx3G55ZdjQ==", null, false, "38aeca11-2b3b-4c03-811e-1ad8a9144351", null, false, "Supervisor" },
                    { "9a825bb0-95db-498e-8369-d10fcfae6e98", 0, "3e2383c1-7bb2-46a1-a85e-b1aa82013f73", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "USER", "System", false, null, "USER@LOCALHOST.COM", "ANONYMOUS", "AQAAAAEAACcQAAAAEGvr08PUNSZsgPNjykY52DXdwyFBmFrd3t2e0gWAwW7teKPmrM7yvFhWT7rVqCDqiA==", null, false, "61ecf233-1d6d-4f93-b257-01e50fb02886", null, false, "Anonymous" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2272d930-5ab6-4c02-9eb1-febffde4814c", "9a825bb0-95db-498e-8369-d10fcfae6e98" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a825bb0-95db-498e-8369-d10fcfae6e98");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2272d930-5ab6-4c02-9eb1-febffde4814c", "9a825bb0-95db-498e-8369-d10fcfae6e98" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2272d930-5ab6-4c02-9eb1-febffde4814c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2272d930-5ab6-4c02-9eb1-febffde4814c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a825bb0-95db-498e-8369-d10fcfae6e98");
        }
    }
}
