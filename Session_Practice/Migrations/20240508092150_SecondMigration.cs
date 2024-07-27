using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session_Practice.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PriceID",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_PriceID",
                table: "Books",
                column: "PriceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Prices_PriceID",
                table: "Books",
                column: "PriceID",
                principalTable: "Prices",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Prices_PriceID",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropIndex(
                name: "IX_Books_PriceID",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PriceID",
                table: "Books");
        }
    }
}
