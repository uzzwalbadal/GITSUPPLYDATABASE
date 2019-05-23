using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace supplyc.Migrations
{
    public partial class added_entityof_purchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Supply_Purchases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    RefName = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    BatchId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supply_Purchases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supply_PurchaseDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    Rate = table.Column<int>(nullable: false),
                    ExpiryDate = table.Column<string>(nullable: true),
                    ProductTypeId = table.Column<int>(nullable: false),
                    PurchaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supply_PurchaseDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Supply_PurchaseDetails_Supply_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "Supply_ProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Supply_PurchaseDetails_Supply_Purchases_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "Supply_Purchases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Supply_PurchaseDetails_ProductTypeId",
                table: "Supply_PurchaseDetails",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Supply_PurchaseDetails_PurchaseId",
                table: "Supply_PurchaseDetails",
                column: "PurchaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Supply_PurchaseDetails");

            migrationBuilder.DropTable(
                name: "Supply_Purchases");
        }
    }
}
