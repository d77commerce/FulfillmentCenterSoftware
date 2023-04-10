using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FulfillmentCenterSoftware.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    company_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    company_no = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    vat_no = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    country = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    town = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    street = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    address_line1 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    address_line2 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    postcode = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    phone_no = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    web_site = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_clients", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    owner_id = table.Column<int>(type: "integer", nullable: false),
                    product_id = table.Column<int>(type: "integer", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    packaging = table.Column<int>(type: "integer", nullable: false),
                    add_type = table.Column<bool>(type: "boolean", nullable: false),
                    add_paper = table.Column<bool>(type: "boolean", nullable: false),
                    add_bubble_wraps = table.Column<bool>(type: "boolean", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    courier = table.Column<int>(type: "integer", nullable: false),
                    trays_no = table.Column<int>(type: "integer", nullable: false),
                    instruction = table.Column<string>(type: "text", nullable: false),
                    receiver_first_name = table.Column<string>(type: "text", nullable: false),
                    receiver_last_name = table.Column<string>(type: "text", nullable: false),
                    receiver_phone = table.Column<string>(type: "text", nullable: false),
                    receiver_country = table.Column<string>(type: "text", nullable: false),
                    receiver_city = table.Column<string>(type: "text", nullable: false),
                    receiver_street = table.Column<string>(type: "text", nullable: false),
                    receiver_address_line1 = table.Column<string>(type: "text", nullable: true),
                    receiver_address_line2 = table.Column<string>(type: "text", nullable: true),
                    receiver_postcode = table.Column<string>(type: "text", nullable: false),
                    customer_message = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_orders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "producers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_producers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "storage_places",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rack_id = table.Column<int>(type: "integer", nullable: false),
                    color = table.Column<int>(type: "integer", nullable: false),
                    zone = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_storage_places", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    kg = table.Column<decimal>(type: "numeric", nullable: false),
                    length = table.Column<decimal>(type: "numeric", nullable: false),
                    height = table.Column<decimal>(type: "numeric", nullable: false),
                    width = table.Column<decimal>(type: "numeric", nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false),
                    price10 = table.Column<decimal>(type: "numeric", nullable: true),
                    pieces_per_box = table.Column<int>(type: "integer", nullable: true),
                    boxes_per_pallet = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    short_description = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    product_barcode = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    product_storage_barcode = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    product_code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    producer_id = table.Column<int>(type: "integer", nullable: false),
                    pic_url = table.Column<string>(type: "text", nullable: true),
                    owner_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_products", x => x.id);
                    table.ForeignKey(
                        name: "fk_products_clients_owner_id",
                        column: x => x.owner_id,
                        principalTable: "clients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_products_producers_producer_id",
                        column: x => x.producer_id,
                        principalTable: "producers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_products_owner_id",
                table: "products",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "ix_products_producer_id",
                table: "products",
                column: "producer_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "storage_places");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "producers");
        }
    }
}
