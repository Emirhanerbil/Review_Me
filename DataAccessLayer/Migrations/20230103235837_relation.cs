﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Sellers_SellerID",
                table: "Contents");

            migrationBuilder.DropIndex(
                name: "IX_Contents_SellerID",
                table: "Contents");

            migrationBuilder.CreateTable(
                name: "ContentSeller",
                columns: table => new
                {
                    ContentID = table.Column<int>(type: "int", nullable: false),
                    SellerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentSeller", x => new { x.ContentID, x.SellerID });
                    table.ForeignKey(
                        name: "FK_ContentSeller_Contents_ContentID",
                        column: x => x.ContentID,
                        principalTable: "Contents",
                        principalColumn: "ContentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentSeller_Sellers_SellerID",
                        column: x => x.SellerID,
                        principalTable: "Sellers",
                        principalColumn: "SellerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContentSeller_SellerID",
                table: "ContentSeller",
                column: "SellerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContentSeller");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_SellerID",
                table: "Contents",
                column: "SellerID");

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
