using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finance.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionInIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Transaction_Amount_Type_CategoryId_RegisterDate",
                table: "Transaction");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_Description_Amount_Type_CategoryId_RegisterDate",
                table: "Transaction",
                columns: new[] { "Description", "Amount", "Type", "CategoryId", "RegisterDate" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Transaction_Description_Amount_Type_CategoryId_RegisterDate",
                table: "Transaction");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_Amount_Type_CategoryId_RegisterDate",
                table: "Transaction",
                columns: new[] { "Amount", "Type", "CategoryId", "RegisterDate" },
                unique: true);
        }
    }
}
