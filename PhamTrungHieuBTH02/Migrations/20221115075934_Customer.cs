﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhamTrungHieuBTH02.Migrations
{
    /// <inheritdoc />
    public partial class Customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    MaKH = table.Column<string>(type: "TEXT", nullable: false),
                    SĐT = table.Column<int>(type: "INTEGER", nullable: false),
                    GioiTinh = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
