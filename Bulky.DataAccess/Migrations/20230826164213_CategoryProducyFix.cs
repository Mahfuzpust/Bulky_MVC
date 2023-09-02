using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CategoryProducyFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers");

            //migrationBuilder.InsertData(
            //    table: "Categories",
            //    columns: new[] { "Id", "DisplayOrder", "Name" },
            //    values: new object[,]
            //    {
            //        { 1, 1, "History" },
            //        { 2, 1, "Novel" },
            //        { 3, 2, "Story" }
            //    });

            //migrationBuilder.InsertData(
            //    table: "Products",
            //    columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title" },
            //    values: new object[,]
            //    {
            //        { 1, "Eichirio Oda", 1, "Can be summed up in one line. The boy with strawhat wanna become the king of the pirates", "XDE23234", " ", 99.0, 90.0, 80.0, 85.0, "One Piece" },
            //        { 2, "Humayun Ahmed", 3, "An unseen look at the event that is unfolding in the year 1975 in Bangladeshi politics", "ZXDH24XC", " ", 200.0, 180.0, 150.0, 170.0, "Deyal" }
            //    });

            //migrationBuilder.AddForeignKey(
            //    name: "FK_AspNetUsers_Companies_CompanyId",
            //    table: "AspNetUsers",
            //    column: "CompanyId",
            //    principalTable: "Companies",
            //    principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
