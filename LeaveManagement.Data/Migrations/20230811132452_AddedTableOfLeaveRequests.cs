using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedTableOfLeaveRequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfExpiry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequasted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2272d930-5ab6-4c02-9eb1-febffde4814c",
                column: "ConcurrencyStamp",
                value: "6b9fca0f-47f7-4568-a3f4-89a269769972");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a825bb0-95db-498e-8369-d10fcfae6e98",
                column: "ConcurrencyStamp",
                value: "85773f75-0b93-427f-b989-2892d7da550a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "usl25bb0-95db-498e-8369-d10fcfae6e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2aa3a908-e06c-43bb-8ff2-53f2ba075897", "AQAAAAEAACcQAAAAEI1a2j4CzGJeb9eBjfaxQTMzG1zJumCD78JJ7GwzhaRNEuFkc/o4fp8GqXbwRZAKcQ==", "1dd7d240-2679-413d-828d-9706bb5f3185" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "usr2d930-5ab6-4c02-9eb1-febffde4814c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fcd351d-4acd-4eb4-94a6-8f716a76ffea", "AQAAAAEAACcQAAAAEHpZTShvClfQAarfHkvXNdoVbTCDwzfrfnnG/pKLChy5C7JwKab1NuiEav9qtbaeEw==", "5873a567-88f0-47c0-807a-0f655400ca61" });
        }
    }
}
