using Microsoft.EntityFrameworkCore.Migrations;

namespace Muzik.Migrations
{
    public partial class YENİ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Muzik",
                columns: table => new
                {
                    SarkiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SarkiAd = table.Column<string>(maxLength: 50, nullable: false),
                    AlbumAd = table.Column<string>(maxLength: 50, nullable: true),
                    CikisYili = table.Column<int>(nullable: false),
                    Artist = table.Column<string>(maxLength: 50, nullable: false),
                    Tur = table.Column<string>(nullable: true),
                    SarkiSuresi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muzik", x => x.SarkiId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Muzik");
        }
    }
}
