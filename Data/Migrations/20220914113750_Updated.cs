using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RapeCrisisCounsellorSystem.Data.Migrations
{
    public partial class Updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Counsellor_counsellorId",
                table: "Schedule");

            migrationBuilder.RenameColumn(
                name: "counsellorId",
                table: "Schedule",
                newName: "CounsellorId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_counsellorId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Counsellor_CounsellorId",
                table: "Schedule");

            migrationBuilder.RenameColumn(
                name: "CounsellorId",
                table: "Schedule",
                newName: "counsellorId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_CounsellorId",
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
    }
}
