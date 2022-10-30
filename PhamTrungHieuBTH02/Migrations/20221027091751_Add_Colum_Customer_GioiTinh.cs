using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhamTrungHieuBTH02.Migrations
{
    public partial class Add_Colum_Customer_GioiTinh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Student");

            migrationBuilder.AddColumn<string>(
                name: "GioiTinh",
                table: "Customer",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GioiTinh",
                table: "Customer");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Student",
                type: "TEXT",
                nullable: true);
        }
    }
}
