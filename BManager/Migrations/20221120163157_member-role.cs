using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BManager.Migrations
{
    public partial class memberrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "memberRoleId",
                table: "TeamMember",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MemberRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialityTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberRole_SpecialityType_SpecialityTypeId",
                        column: x => x.SpecialityTypeId,
                        principalTable: "SpecialityType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_memberRoleId",
                table: "TeamMember",
                column: "memberRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberRole_SpecialityTypeId",
                table: "MemberRole",
                column: "SpecialityTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMember_MemberRole_memberRoleId",
                table: "TeamMember",
                column: "memberRoleId",
                principalTable: "MemberRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamMember_MemberRole_memberRoleId",
                table: "TeamMember");

            migrationBuilder.DropTable(
                name: "MemberRole");

            migrationBuilder.DropIndex(
                name: "IX_TeamMember_memberRoleId",
                table: "TeamMember");

            migrationBuilder.DropColumn(
                name: "memberRoleId",
                table: "TeamMember");
        }
    }
}
