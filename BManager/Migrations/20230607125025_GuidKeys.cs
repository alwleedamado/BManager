using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BManager.Migrations
{
    public partial class GuidKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamMember_Freelancers_FreelancerId1",
                table: "TeamMember");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMember_Teams_TeamId1",
                table: "TeamMember");

            migrationBuilder.DropIndex(
                name: "IX_TeamMember_FreelancerId1",
                table: "TeamMember");

            migrationBuilder.DropIndex(
                name: "IX_TeamMember_TeamId1",
                table: "TeamMember");

            migrationBuilder.DropColumn(
                name: "FreelancerId1",
                table: "TeamMember");

            migrationBuilder.DropColumn(
                name: "TeamId1",
                table: "TeamMember");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "TeamMember");

            migrationBuilder.AddColumn<Guid>(
                name: "TeamId",
                table: "TeamMember");

            migrationBuilder.DropColumn(
                name: "FreelancerId",
                table: "TeamMember");

            migrationBuilder.AddColumn<Guid>(
                name: "FreelancerId",
                table: "TeamMember");


            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_FreelancerId",
                table: "TeamMember",
                column: "FreelancerId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_TeamId",
                table: "TeamMember",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMember_Freelancers_FreelancerId",
                table: "TeamMember",
                column: "FreelancerId",
                principalTable: "Freelancers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMember_Teams_TeamId",
                table: "TeamMember",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamMember_Freelancers_FreelancerId",
                table: "TeamMember");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMember_Teams_TeamId",
                table: "TeamMember");

            migrationBuilder.DropIndex(
                name: "IX_TeamMember_FreelancerId",
                table: "TeamMember");

            migrationBuilder.DropIndex(
                name: "IX_TeamMember_TeamId",
                table: "TeamMember");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "TeamMember",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "FreelancerId",
                table: "TeamMember",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "FreelancerId1",
                table: "TeamMember",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TeamId1",
                table: "TeamMember",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_FreelancerId1",
                table: "TeamMember",
                column: "FreelancerId1");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_TeamId1",
                table: "TeamMember",
                column: "TeamId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMember_Freelancers_FreelancerId1",
                table: "TeamMember",
                column: "FreelancerId1",
                principalTable: "Freelancers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMember_Teams_TeamId1",
                table: "TeamMember",
                column: "TeamId1",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
