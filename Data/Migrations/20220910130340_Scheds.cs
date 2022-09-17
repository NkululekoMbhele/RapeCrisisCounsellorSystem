using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RapeCrisisCounsellorSystem.Data.Migrations
{
    public partial class Scheds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Counsellor_CounsellorId",
                table: "Schedule");

            migrationBuilder.RenameColumn(
                name: "CounsellorId",
                table: "Schedule",
                newName: "NameCounsellorId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_CounsellorId",
                table: "Schedule",
                newName: "IX_Schedule_NameCounsellorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Counsellor_NameCounsellorId",
                table: "Schedule",
                column: "NameCounsellorId",
                principalTable: "Counsellor",
                principalColumn: "CounsellorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Counsellor_NameCounsellorId",
                table: "Schedule");

            migrationBuilder.RenameColumn(
                name: "NameCounsellorId",
                table: "Schedule",
                newName: "CounsellorId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_NameCounsellorId",
                table: "Schedule",
                newName: "IX_Schedule_CounsellorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Counsellor_CounsellorId",
                table: "Schedule",
                column: "CounsellorId",
                principalTable: "Counsellor",
                principalColumn: "CounsellorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
