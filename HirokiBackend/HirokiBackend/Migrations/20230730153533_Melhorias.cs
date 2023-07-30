using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HirokiBackend.Migrations
{
    public partial class Melhorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "otherAccount",
                table: "Transactions",
                newName: "otherAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_otherAccountId",
                table: "Transactions",
                column: "otherAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Accounts_otherAccountId",
                table: "Transactions",
                column: "otherAccountId",
                principalTable: "Accounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Accounts_otherAccountId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_otherAccountId",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "otherAccountId",
                table: "Transactions",
                newName: "otherAccount");
        }
    }
}
