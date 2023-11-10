using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRN211_HE170436_Project.Data.Migrations
{
    public partial class UpdateBillingTable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Billing_Products_ProductId",
                table: "Billing");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Billing",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Billing_Products_ProductId",
                table: "Billing",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Billing_Products_ProductId",
                table: "Billing");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Billing",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Billing_Products_ProductId",
                table: "Billing",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId");
        }
    }
}
