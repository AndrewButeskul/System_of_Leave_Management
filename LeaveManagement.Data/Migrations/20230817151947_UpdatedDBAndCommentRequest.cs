using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class UpdatedDBAndCommentRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2272d930-5ab6-4c02-9eb1-febffde4814c",
                column: "ConcurrencyStamp",
                value: "425defe1-0214-4b8e-a3e6-efa616b00c33");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a825bb0-95db-498e-8369-d10fcfae6e98",
                column: "ConcurrencyStamp",
                value: "650017d8-4217-46a4-a9f9-d14be43b79e2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "usl25bb0-95db-498e-8369-d10fcfae6e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d7f1c6b-9830-4e73-bfce-60e6bc98d1c4", "AQAAAAEAACcQAAAAEOWM1faCElhGzDT84eLymA3ISNiM6OkjiYSrUz7wG1026Ja7n0jY/Qi0MlQZA46NjA==", "7ca68e73-33dc-48ed-9bf0-7e67e54abe6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "usr2d930-5ab6-4c02-9eb1-febffde4814c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f06dc62f-f656-44e3-ba88-cb4461bd22c5", "AQAAAAEAACcQAAAAECU3SP2W3RfBtPGZUog69xZ70j2kAcab0k2YbOVlPguOQs8Oj157QzoimLV64B/rpg==", "52de6778-94a3-4046-98f9-9bda9265ef0b" });
        }
    }
}
