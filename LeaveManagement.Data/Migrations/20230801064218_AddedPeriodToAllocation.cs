using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2272d930-5ab6-4c02-9eb1-febffde4814c",
                column: "ConcurrencyStamp",
                value: "ed4d7215-7c27-48c5-b781-34f17610b203");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a825bb0-95db-498e-8369-d10fcfae6e98",
                column: "ConcurrencyStamp",
                value: "e1dfde31-e9de-4f6e-8bb1-7c625440d580");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "usl25bb0-95db-498e-8369-d10fcfae6e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6620286a-cd3c-489c-9294-b54e4289d86d", "AQAAAAEAACcQAAAAEIYOefkO+kpf6aj3/MvNu/Ak6+NsQE4xGoB1O7UVLpxac9nhn9dq+sC7CEt5PVSDHg==", "ae39e12b-a5f3-4d13-980e-799a350657dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "usr2d930-5ab6-4c02-9eb1-febffde4814c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b9d3599-0319-4a84-aa6c-b971539155bd", "AQAAAAEAACcQAAAAEJKO//z8uCUlFoAfJM1kCD1t5aSVW8sP5dqOsYB/vgZshKUNNiR77E6wtYdLSOYG8A==", "06aa10e3-2167-4219-9d4c-a1f820097916" });
        }
    }
}
