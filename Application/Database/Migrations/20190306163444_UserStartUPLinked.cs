using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class UserStartUPLinked : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserId",
                schema: "MoinPersonal",
                table: "StartUps",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StartUps_UserId",
                schema: "MoinPersonal",
                table: "StartUps",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_StartUps_Users_UserId",
                schema: "MoinPersonal",
                table: "StartUps",
                column: "UserId",
                principalSchema: "MoinPersonal",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StartUps_Users_UserId",
                schema: "MoinPersonal",
                table: "StartUps");

            migrationBuilder.DropIndex(
                name: "IX_StartUps_UserId",
                schema: "MoinPersonal",
                table: "StartUps");

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "MoinPersonal",
                table: "StartUps");
        }
    }
}
