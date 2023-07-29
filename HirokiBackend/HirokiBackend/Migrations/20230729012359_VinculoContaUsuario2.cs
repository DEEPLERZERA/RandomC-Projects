using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HirokiBackend.Migrations
{
    public partial class VinculoContaUsuario2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Transactions_accountId",
                table: "Transactions",
                column: "accountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Accounts_accountId",
                table: "Transactions",
                column: "accountId",
                principalTable: "Accounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Accounts_accountId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_accountId",
                table: "Transactions");
        }
    }
}
 