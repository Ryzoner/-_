using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SKIV.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Measures_IdMeasure1",
                table: "Participations");

            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Volunteers_IdVolunteer1",
                table: "Participations");

            migrationBuilder.RenameColumn(
                name: "IdVolunteer1",
                table: "Participations",
                newName: "VolunteerIdVolunteerIdVolunteer");

            migrationBuilder.RenameColumn(
                name: "IdMeasure1",
                table: "Participations",
                newName: "MeasureIdMeasureIdMeasure");

            migrationBuilder.RenameIndex(
                name: "IX_Participations_IdVolunteer1",
                table: "Participations",
                newName: "IX_Participations_VolunteerIdVolunteerIdVolunteer");

            migrationBuilder.RenameIndex(
                name: "IX_Participations_IdMeasure1",
                table: "Participations",
                newName: "IX_Participations_MeasureIdMeasureIdMeasure");

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Measures_MeasureIdMeasureIdMeasure",
                table: "Participations",
                column: "MeasureIdMeasureIdMeasure",
                principalTable: "Measures",
                principalColumn: "IdMeasure",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Volunteers_VolunteerIdVolunteerIdVolunteer",
                table: "Participations",
                column: "VolunteerIdVolunteerIdVolunteer",
                principalTable: "Volunteers",
                principalColumn: "IdVolunteer",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Measures_MeasureIdMeasureIdMeasure",
                table: "Participations");

            migrationBuilder.DropForeignKey(
                name: "FK_Participations_Volunteers_VolunteerIdVolunteerIdVolunteer",
                table: "Participations");

            migrationBuilder.RenameColumn(
                name: "VolunteerIdVolunteerIdVolunteer",
                table: "Participations",
                newName: "IdVolunteer1");

            migrationBuilder.RenameColumn(
                name: "MeasureIdMeasureIdMeasure",
                table: "Participations",
                newName: "IdMeasure1");

            migrationBuilder.RenameIndex(
                name: "IX_Participations_VolunteerIdVolunteerIdVolunteer",
                table: "Participations",
                newName: "IX_Participations_IdVolunteer1");

            migrationBuilder.RenameIndex(
                name: "IX_Participations_MeasureIdMeasureIdMeasure",
                table: "Participations",
                newName: "IX_Participations_IdMeasure1");

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Measures_IdMeasure1",
                table: "Participations",
                column: "IdMeasure1",
                principalTable: "Measures",
                principalColumn: "IdMeasure",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_Volunteers_IdVolunteer1",
                table: "Participations",
                column: "IdVolunteer1",
                principalTable: "Volunteers",
                principalColumn: "IdVolunteer",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
