using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRN211_HE170436_Project.Data.Migrations
{
    public partial class UpdateBillingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Billing_ProductId",
                table: "Billing",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Billing_Products_ProductId",
                table: "Billing",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Billing_Products_ProductId",
                table: "Billing");

            migrationBuilder.DropIndex(
                name: "IX_Billing_ProductId",
                table: "Billing");
        }
    }
}
