using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class relationjobseller : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobID",
                table: "Sellers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_JobID",
                table: "Sellers",
                column: "JobID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Jobs_JobID",
                table: "Sellers",
                column: "JobID",
                principalTable: "Jobs",
                principalColumn: "JobID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Jobs_JobID",
                table: "Sellers");

            migrationBuilder.DropIndex(
                name: "IX_Sellers_JobID",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "JobID",
                table: "Sellers");
        }
    }
}
