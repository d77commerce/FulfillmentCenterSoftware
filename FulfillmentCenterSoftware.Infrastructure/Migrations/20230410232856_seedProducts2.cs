using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FulfillmentCenterSoftware.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedProducts2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "boxes_per_pallet", "client_id", "description", "height_cm", "kg", "length_cm", "name", "pic_url", "pieces_per_box", "price", "price10", "producer_id", "product_barcode", "product_code", "product_storage_barcode", "quantity", "short_description", "storage_place_id", "width_cm" },
                values: new object[,]
                {
                    { 1, 65, 1, "long description ! ! !", 21, 3.3580000000000001, 35, "Test Product1", "http://clickandgrab.trakia.co.uk/wp-content/uploads/2020/05/clickandgrab.co_.uk-poster-2-2048x1006.jpg", 12, 2.10m, 2.015m, 1, "1234567891", "c&g001", "c&g100001", 0, "short description ! ! !", 1, 10 },
                    { 2, 65, 2, "long description ! ! !", 11, 4.3579999999999997, 45, "Test Product2", "http://clickandgrab.trakia.co.uk/wp-content/uploads/2020/05/clickandgrab.co_.uk-poster-2-2048x1006.jpg", 18, 3.10m, 3.015m, 2, "9234567891", "c&g002", "c&g100002", 0, "short description ! ! !", 2, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
