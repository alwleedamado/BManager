using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BManager.Migrations
{
    public partial class fixschema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Speciality_Persons_PersonId",
                table: "Speciality");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Speciality",
                table: "Speciality");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Speciality");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Speciality");

            migrationBuilder.RenameTable(
                name: "Speciality",
                newName: "Specialities");

            migrationBuilder.RenameIndex(
                name: "IX_Speciality_PersonId",
                table: "Specialities",
                newName: "IX_Specialities_PersonId");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Specialities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpecialityTypeId",
                table: "Specialities",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specialities",
                table: "Specialities",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SpecialityType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialityType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Specialities_SpecialityTypeId",
                table: "Specialities",
                column: "SpecialityTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Specialities_Persons_PersonId",
                table: "Specialities",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialities_SpecialityType_SpecialityTypeId",
                table: "Specialities",
                column: "SpecialityTypeId",
                principalTable: "SpecialityType",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_Persons_PersonId",
                table: "Specialities");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_SpecialityType_SpecialityTypeId",
                table: "Specialities");

            migrationBuilder.DropTable(
                name: "SpecialityType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specialities",
                table: "Specialities");

            migrationBuilder.DropIndex(
                name: "IX_Specialities_SpecialityTypeId",
                table: "Specialities");

            migrationBuilder.DropColumn(
                name: "SpecialityTypeId",
                table: "Specialities");

            migrationBuilder.RenameTable(
                name: "Specialities",
                newName: "Speciality");

            migrationBuilder.RenameIndex(
                name: "IX_Specialities_PersonId",
                table: "Speciality",
                newName: "IX_Speciality_PersonId");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Speciality",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Speciality",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Speciality",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Speciality",
                table: "Speciality",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Speciality_Persons_PersonId",
                table: "Speciality",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }
    }
}
