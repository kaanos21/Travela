using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Travela.DataAccesLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Destinations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_CategoryId",
                table: "Destinations",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Categories_CategoryId",
                table: "Destinations",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Categories_CategoryId",
                table: "Destinations");

            migrationBuilder.DropIndex(
                name: "IX_Destinations_CategoryId",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Destinations");
        }
    }
}
