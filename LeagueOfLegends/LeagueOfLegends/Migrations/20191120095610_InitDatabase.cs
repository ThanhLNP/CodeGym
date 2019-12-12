using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueOfLegends.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Health = table.Column<int>(nullable: false),
                    HealthRegen = table.Column<int>(nullable: false),
                    AttackDamage = table.Column<int>(nullable: false),
                    Armor = table.Column<int>(nullable: false),
                    MagicResist = table.Column<int>(nullable: false),
                    MovementSpeed = table.Column<int>(nullable: false),
                    isDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    isDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeroesTypes",
                columns: table => new
                {
                    TypesId = table.Column<int>(nullable: false),
                    HeroesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroesTypes", x => new { x.TypesId, x.HeroesId });
                    table.ForeignKey(
                        name: "FK_HeroesTypes_Heroes_HeroesId",
                        column: x => x.HeroesId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroesTypes_Types_TypesId",
                        column: x => x.TypesId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Armor", "AttackDamage", "Health", "HealthRegen", "isDelete", "MagicResist", "MovementSpeed", "Name" },
                values: new object[] { 1, 30, 57, 575, 6, false, 31, 330, "Lux" });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "isDelete", "Name" },
                values: new object[,]
                {
                    { 1, false, "Sát thủ" },
                    { 2, false, "Xạ thủ" },
                    { 3, false, "Pháp sư" },
                    { 4, false, "Hỗ trợ" },
                    { 5, false, "Đỡ đòn" },
                    { 6, false, "Đấu sĩ" },
                    { 7, false, "Đánh xa" },
                    { 8, false, "Cận chiến" }
                });

            migrationBuilder.InsertData(
                table: "HeroesTypes",
                columns: new[] { "TypesId", "HeroesId" },
                values: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "HeroesTypes",
                columns: new[] { "TypesId", "HeroesId" },
                values: new object[] { 4, 1 });

            migrationBuilder.InsertData(
                table: "HeroesTypes",
                columns: new[] { "TypesId", "HeroesId" },
                values: new object[] { 7, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_HeroesTypes_HeroesId",
                table: "HeroesTypes",
                column: "HeroesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroesTypes");

            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
