using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class UpdatedRequestComment : Migration
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
                value: "df198c35-45f8-41e3-ae81-c9c359d3ecec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a825bb0-95db-498e-8369-d10fcfae6e98",
                column: "ConcurrencyStamp",
                value: "4eabaec3-0853-4f42-9439-ce27efa8b2f8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "usl25bb0-95db-498e-8369-d10fcfae6e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "535d855d-f273-4cd4-a643-4c1c696e7a1a", "AQAAAAEAACcQAAAAEImKyGT8ADNoNgepey5gRhyC4r1VJbnaB4SmZl0GJQQSFyVEUp8PDMuCZnNnCRKHnQ==", "a90fd854-c45d-4e22-9987-4afe7c6f8b2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "usr2d930-5ab6-4c02-9eb1-febffde4814c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb70191a-b893-4983-b6b9-66f3e65b5046", "AQAAAAEAACcQAAAAEMH8AXtxwSelD+/RnOcDUIXkIH/5HwCAdB527OtPfeW+wCnDrY9ocgWbmJt3RbpkIQ==", "eed2ad79-9ab8-4f09-b5d2-960c56bf742a" });
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
