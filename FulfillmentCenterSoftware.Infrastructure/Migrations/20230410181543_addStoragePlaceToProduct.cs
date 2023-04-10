using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FulfillmentCenterSoftware.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addStoragePlaceToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "storage_place_id",
                table: "products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ix_products_storage_place_id",
                table: "products",
                column: "storage_place_id");

            migrationBuilder.AddForeignKey(
                name: "fk_products_storage_places_storage_place_id",
                table: "products",
                column: "storage_place_id",
                principalTable: "storage_places",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_products_storage_places_storage_place_id",
                table: "products");

            migrationBuilder.DropIndex(
                name: "ix_products_storage_place_id",
                table: "products");

            migrationBuilder.DropColumn(
                name: "storage_place_id",
                table: "products");
        }
    }
}
