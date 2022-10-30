using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhamTrungHieuBTH02.Migrations
{
    public partial class Add_Colum_Student_SĐT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SĐT",
                table: "Student",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SĐT",
                table: "Student");
        }
    }
}
