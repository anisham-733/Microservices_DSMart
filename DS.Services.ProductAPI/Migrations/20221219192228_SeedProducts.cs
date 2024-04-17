using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DS.Services.ProductAPI.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, "Mobile", "iPhone", "C:\\Work\\Demo\\DSRestaurant\\DSRestaurant\\Images\\iPhone.jfif", 15.0, "iPhone" },
                    { 2, "Laptop", "ie 7", "C:\\Work\\Demo\\DSRestaurant\\DSRestaurant\\Images\\laptop.jfif", 13.99, "Laptop" },
                    { 3, "Mobile", "Mobile", "C:\\Work\\Demo\\DSRestaurant\\DSRestaurant\\Images\\Mobile.jfif", 10.99, "Mobile" },
                    { 4, "Mobile", "Mobile", "C:\\Work\\Demo\\DSRestaurant\\DSRestaurant\\Images\\Mobile.jfif", 15.0, "Mobile" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
