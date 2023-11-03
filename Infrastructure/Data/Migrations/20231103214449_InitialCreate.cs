using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.AlterDatabase()
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "driver",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         age = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "team",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "userRol",
            //     columns: table => new
            //     {
            //         IdTeam = table.Column<int>(type: "int", nullable: false),
            //         IdDriver = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_userRol", x => new { x.IdDriver, x.IdTeam });
            //         table.ForeignKey(
            //             name: "FK_userRol_driver_IdDriver",
            //             column: x => x.IdDriver,
            //             principalTable: "driver",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //         table.ForeignKey(
            //             name: "FK_userRol_team_IdTeam",
            //             column: x => x.IdTeam,
            //             principalTable: "team",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateIndex(
            //     name: "name_UNIQUE",
            //     table: "team",
            //     column: "name",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "IX_userRol_IdTeam",
            //     table: "userRol",
            //     column: "IdTeam");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //     name: "userRol");

            // migrationBuilder.DropTable(
            //     name: "driver");

            // migrationBuilder.DropTable(
            //     name: "team");
        }
    }
}
