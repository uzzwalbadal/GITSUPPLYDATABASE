using Microsoft.EntityFrameworkCore.Migrations;

namespace supplyc.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Supply_Customers_Supply_CustomerType_CustomerTypeId",
                table: "Supply_Customers");

            migrationBuilder.DropIndex(
                name: "IX_Supply_Customers_CustomerTypeId",
                table: "Supply_Customers");

            migrationBuilder.DropColumn(
                name: "CustomerTypeId",
                table: "Supply_Customers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerTypeId",
                table: "Supply_Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Supply_Customers_CustomerTypeId",
                table: "Supply_Customers",
                column: "CustomerTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Supply_Customers_Supply_CustomerType_CustomerTypeId",
                table: "Supply_Customers",
                column: "CustomerTypeId",
                principalTable: "Supply_CustomerType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
