using Microsoft.EntityFrameworkCore.Migrations;


//<some nuget thing did all of this, o god, what have i done /> 


namespace Bangazon.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "269e0649-739c-4170-8402-f804cab316fe");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[] { "51f59306-21a1-4555-bcf7-b04fcafae457", 0, "c15a6958-e34f-4b91-a40b-340ad8cf9038", "admin@admin.com", true, "Admina", "Straytor", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELe/u8ZIgUYGIDo1Fd9PK+iXtbs0vCjZ5lwUc316uUd4MTZzOzyz6WhHWe+cZX8xyA==", null, false, "259bed13-6e96-41cd-8407-a66b667fc2a4", "123 Infinity Way", false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "UserId",
                value: "51f59306-21a1-4555-bcf7-b04fcafae457");

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "PaymentTypeId",
                keyValue: 1,
                column: "UserId",
                value: "51f59306-21a1-4555-bcf7-b04fcafae457");

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "PaymentTypeId",
                keyValue: 2,
                column: "UserId",
                value: "51f59306-21a1-4555-bcf7-b04fcafae457");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "UserId",
                value: "51f59306-21a1-4555-bcf7-b04fcafae457");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "UserId",
                value: "51f59306-21a1-4555-bcf7-b04fcafae457");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51f59306-21a1-4555-bcf7-b04fcafae457");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[] { "269e0649-739c-4170-8402-f804cab316fe", 0, "e55469e0-838d-4351-b1a5-429c9212453b", "admin@admin.com", true, "Admina", "Straytor", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJwm8dRhv5uDOIewL5NvRf4RZ8+btYczKSWKqv5yixdrA8U4yRRSqfTG2ySFGEQZgQ==", null, false, "0ff0c1f2-333e-4b99-9aa8-913505788cc1", "123 Infinity Way", false, "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "UserId",
                value: "269e0649-739c-4170-8402-f804cab316fe");

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "PaymentTypeId",
                keyValue: 1,
                column: "UserId",
                value: "269e0649-739c-4170-8402-f804cab316fe");

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "PaymentTypeId",
                keyValue: 2,
                column: "UserId",
                value: "269e0649-739c-4170-8402-f804cab316fe");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "UserId",
                value: "269e0649-739c-4170-8402-f804cab316fe");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "UserId",
                value: "269e0649-739c-4170-8402-f804cab316fe");
        }
    }
}
