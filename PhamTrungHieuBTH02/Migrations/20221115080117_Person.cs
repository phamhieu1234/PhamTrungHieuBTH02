using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhamTrungHieuBTH02.Migrations
{
    /// <inheritdoc />
    public partial class Person : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    PersonID = table.Column<string>(type: "TEXT", nullable: false),
                    Personname = table.Column<string>(type: "TEXT", nullable: false),
                    namsinh = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
