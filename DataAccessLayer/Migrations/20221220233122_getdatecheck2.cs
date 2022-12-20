using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class getdatecheck2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ContentDate",
                table: "Contents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 21, 2, 31, 22, 488, DateTimeKind.Local).AddTicks(4277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ContentDate",
                table: "Contents",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 21, 2, 31, 22, 488, DateTimeKind.Local).AddTicks(4277));
        }
    }
}
