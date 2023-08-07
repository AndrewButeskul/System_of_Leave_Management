using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class UpgratedFieldsInAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2272d930-5ab6-4c02-9eb1-febffde4814c",
                column: "ConcurrencyStamp",
                value: "765100e4-3dfc-4e7a-893f-1c327ab569ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a825bb0-95db-498e-8369-d10fcfae6e98",
                column: "ConcurrencyStamp",
                value: "09dfb73e-ce79-4aa9-8fa7-885d085c00d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "usl25bb0-95db-498e-8369-d10fcfae6e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "439d8e3d-488a-41d7-9bdd-cd41f3474942", "AQAAAAEAACcQAAAAEKWWMzOtXpyV0Qjuyv0dOKk9zlk+NimAyR4HYKQHEAu3PLD10JuMTxkvHh6ktUPp2A==", "559176ff-8229-4f60-b657-e5f4b05316a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "usr2d930-5ab6-4c02-9eb1-febffde4814c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56565c64-51c9-47ff-b8a9-088e7a1a29c1", "AQAAAAEAACcQAAAAEDZLXsAg22PtvnOXucw33P1AbsN/+mYlXzvBUBevILJnB2/LkmkfyvrWj9HZIVmuzw==", "ba22de9a-64a8-4174-adfb-6ee290bcad81" });
        }
    }
}
