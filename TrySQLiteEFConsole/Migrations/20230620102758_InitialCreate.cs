using Microsoft.EntityFrameworkCore.Migrations;

namespace TrySQLiteEFConsole.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prefectures",
                columns: table => new
                {
                    PrefectureId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    PrefectureId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prefectures", x => x.PrefectureId);
                    table.ForeignKey(
                        name: "FK_Prefectures_Prefectures_PrefectureId1",
                        column: x => x.PrefectureId1,
                        principalTable: "Prefectures",
                        principalColumn: "PrefectureId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prefectures_PrefectureId1",
                table: "Prefectures",
                column: "PrefectureId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prefectures");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
