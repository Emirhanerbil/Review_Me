using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class sellernul : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Sellers_SellerID",
                table: "Contents");

            migrationBuilder.AlterColumn<int>(
                name: "SellerID",
                table: "Contents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Sellers_SellerID",
                table: "Contents",
                column: "SellerID",
                principalTable: "Sellers",
                principalColumn: "SellerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Sellers_SellerID",
                table: "Contents");

            migrationBuilder.AlterColumn<int>(
                name: "SellerID",
                table: "Contents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Sellers_SellerID",
                table: "Contents",
                column: "SellerID",
                principalTable: "Sellers",
                principalColumn: "SellerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
