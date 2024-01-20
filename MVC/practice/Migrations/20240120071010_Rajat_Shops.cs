using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace practice.Migrations
{
    /// <inheritdoc />
    public partial class Rajat_Shops : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Pid", "Pname", "Pprice" },
                values: new object[,]
                {
                    { 101, "Rajat Shop-1", 29999.990000000002 },
                    { 102, "Rajat Shop-2", 29999.990000000002 },
                    { 103, "Rajat Shop-3", 29999.990000000002 },
                    { 104, "Rajat Shop-4", 29999.990000000002 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Pid",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Pid",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Pid",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Pid",
                keyValue: 104);
        }
    }
}
