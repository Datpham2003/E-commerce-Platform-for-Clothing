using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRN211_HE170436_Project.Data.Migrations
{
    public partial class AddBillingTable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Billing",
                columns: table => new
                {
                    BillingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillingFistName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    BillingLastName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    BillingEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    BillingPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    BillingAddress1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BillingAddress2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BillingCountry = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BillingCity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BillingState = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BillingPostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billing", x => x.BillingId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Billing");
        }
    }
}
