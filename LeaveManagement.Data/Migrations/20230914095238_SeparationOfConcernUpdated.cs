using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class SeparationOfConcernUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2272d930-5ab6-4c02-9eb1-febffde4814c",
                column: "ConcurrencyStamp",
                value: "57bf6ce5-11db-4802-b276-9a87c6b770b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a825bb0-95db-498e-8369-d10fcfae6e98",
                column: "ConcurrencyStamp",
                value: "ecebe1b4-815d-4f8d-b2ca-0191c02a0a72");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "usl25bb0-95db-498e-8369-d10fcfae6e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7a83fb9-32a2-4508-bcf8-d1f6df967b02", "AQAAAAEAACcQAAAAECpxvSUfml+T9TlBHuiHoG5MPmUyVkmTmLyaXVuEkd8UmQfm1WpG35D/OZzivLV5Ag==", "8895751e-b0b0-490c-9e4a-bd2bb72388d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "usr2d930-5ab6-4c02-9eb1-febffde4814c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bf5c9ac-26c0-41d2-8922-e5a288ce8dfc", "AQAAAAEAACcQAAAAEI6Nz3ih3d8+94mG8wZOQ9gVY7PRBwSwdPEOe0o56NsgP1NKoTmSFNbwje5gdMcEpw==", "6b8915c0-523d-432b-9bc6-f06972bfc4b2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
