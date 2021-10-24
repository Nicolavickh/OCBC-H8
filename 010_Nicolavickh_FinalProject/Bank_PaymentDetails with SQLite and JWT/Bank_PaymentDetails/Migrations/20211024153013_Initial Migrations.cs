using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bank_PaymentDetails.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    paymentDetailId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cardOwnerName = table.Column<string>(type: "TEXT", nullable: true),
                    cardNumber = table.Column<string>(type: "TEXT", nullable: true),
                    expirationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    securityCode = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.paymentDetailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
