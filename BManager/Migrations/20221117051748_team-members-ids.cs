using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BManager.Migrations
{
    public partial class teammembersids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_SpecialityType_SpecialityTypeId",
                table: "Specialities");

            migrationBuilder.AlterColumn<string>(
                name: "TelephoneNumber",
                table: "Telephone",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SpecialityTypeId",
                table: "Specialities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Persons",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialities_SpecialityType_SpecialityTypeId",
                table: "Specialities",
                column: "SpecialityTypeId",
                principalTable: "SpecialityType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_SpecialityType_SpecialityTypeId",
                table: "Specialities");

            migrationBuilder.AlterColumn<string>(
                name: "TelephoneNumber",
                table: "Telephone",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "SpecialityTypeId",
                table: "Specialities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Persons",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialities_SpecialityType_SpecialityTypeId",
                table: "Specialities",
                column: "SpecialityTypeId",
                principalTable: "SpecialityType",
                principalColumn: "Id");
        }
    }
}
