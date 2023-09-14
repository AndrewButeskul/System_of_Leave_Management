using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class FixedPropertyDateRequested : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateRequasted",
                table: "LeaveRequests",
                newName: "DateRequested");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2272d930-5ab6-4c02-9eb1-febffde4814c",
                column: "ConcurrencyStamp",
                value: "8d0ae4a1-a6e5-4a55-be2a-54ebc3882dba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a825bb0-95db-498e-8369-d10fcfae6e98",
                column: "ConcurrencyStamp",
                value: "610d9717-2461-46ea-bb89-e0fecda4622f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "usl25bb0-95db-498e-8369-d10fcfae6e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "686a1bb5-d3c9-4460-8393-6bfe4dee0fae", "AQAAAAEAACcQAAAAEAWS1KAzwx2uk5CiKxYRhDLk+n2thmiTw9lr+DmktO+CHhvckB/4gzXMHR72kQXh3Q==", "53cca558-3850-471c-9ba8-763c89217fc2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "usr2d930-5ab6-4c02-9eb1-febffde4814c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2233227-64f5-453c-bd9b-b8bcad410d1f", "AQAAAAEAACcQAAAAEM6+Q/iMEH156PUMtrBPRyK6uk5hyPnjLR+nj87+myjzyOyMkA2bPQMvxMzBA6pb7A==", "b181aa91-f2cf-47dd-9f6b-b680485f7d8a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateRequested",
                table: "LeaveRequests",
                newName: "DateRequasted");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2272d930-5ab6-4c02-9eb1-febffde4814c",
                column: "ConcurrencyStamp",
                value: "dfb28657-603d-4450-87a8-fcfa3a7c8f71");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a825bb0-95db-498e-8369-d10fcfae6e98",
                column: "ConcurrencyStamp",
                value: "9ca82a57-37a5-49a8-9625-1cc02dc8570e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "usl25bb0-95db-498e-8369-d10fcfae6e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "189666f3-5a19-4b54-a4a3-e02b4c25e653", "AQAAAAEAACcQAAAAEMkCrjXENbG04uaPPlZI7xAKa8EClyKE02vIFYHITISSzt3As7li/3LKLMZS3HgrBQ==", "9a9453c4-0067-44c5-a5e7-4c2d75a20734" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "usr2d930-5ab6-4c02-9eb1-febffde4814c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "360c4884-39c7-4e2b-a735-5f71e8d3c8a9", "AQAAAAEAACcQAAAAEEHkOERQQNoNGTwHiy5egzNPEHfzN1FD9nzNfVQwghyYpffpNKD8/7MEVIKNJzuLLg==", "5ac6af91-87f6-40e8-8710-025c240a7d6c" });
        }
    }
}
