using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class norelationjobcontent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Jobs_JobID",
                table: "Contents");

            migrationBuilder.DropIndex(
                name: "IX_Contents_JobID",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "JobID",
                table: "Contents");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobID",
                table: "Contents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contents_JobID",
                table: "Contents",
                column: "JobID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Jobs_JobID",
                table: "Contents",
                column: "JobID",
                principalTable: "Jobs",
                principalColumn: "JobID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
