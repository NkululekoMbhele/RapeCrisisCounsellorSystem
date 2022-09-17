using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RapeCrisisCounsellorSystem.Data.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Counsellor_NameCounsellorId",
                table: "Schedule");

            migrationBuilder.RenameColumn(
                name: "NameCounsellorId",
                table: "Schedule",
                newName: "counsellorId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_NameCounsellorId",
                table: "Schedule",
                newName: "IX_Schedule_counsellorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Counsellor_counsellorId",
                table: "Schedule",
                column: "counsellorId",
                principalTable: "Counsellor",
                principalColumn: "CounsellorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Counsellor_counsellorId",
                table: "Schedule");

            migrationBuilder.RenameColumn(
                name: "counsellorId",
                table: "Schedule",
                newName: "NameCounsellorId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_counsellorId",
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
    }
}
