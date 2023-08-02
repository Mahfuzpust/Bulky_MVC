using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class pro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Billy Spark", "A model may be static or dynamic. In a static model, a single variable is taken as a key element for calculating cost and time.", "SWB012345698", 99.0, 90.0, 80.0, 80.0, "Fortune of Time" },
                    { 2, "Billy ", "A model may be static or dynamic. In a static model, a single variable is taken as a key element for calculating cost and time.", "SWB012345698", 90.0, 85.0, 80.0, 80.0, "Fortune " },
                    { 3, "Billy Spark", "A model may be static or dynamic. In a static model, a single variable is taken as a key element for calculating cost and time.", "SWB012345698", 89.0, 50.0, 80.0, 40.0, " of Time" },
                    { 4, "Billy Spark", "A model may be static or dynamic. In a static model, a single variable is taken as a key element for calculating cost and time.", "SWB012345698", 99.0, 90.0, 80.0, 80.0, "Fortune in Time" }
                });
        }
    }
}
