using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SKIV.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Measures",
                columns: table => new
                {
                    IdMeasure = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MeasureName = table.Column<string>(type: "TEXT", nullable: false),
                    Organizer = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Time = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Place = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    TotalParticipants = table.Column<int>(type: "INTEGER", nullable: false),
                    ContactFullName = table.Column<string>(type: "TEXT", nullable: true),
                    ContactPhoneNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    ContactEmail = table.Column<string>(type: "TEXT", nullable: true),
                    TotalVolunteers = table.Column<int>(type: "INTEGER", nullable: false),
                    VolunteersWithDisabilities = table.Column<int>(type: "INTEGER", nullable: false),
                    LP = table.Column<bool>(type: "INTEGER", nullable: false),
                    LR = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measures", x => x.IdMeasure);
                });

            migrationBuilder.CreateTable(
                name: "Volunteers",
                columns: table => new
                {
                    IdVolunteer = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    MiddleName = table.Column<string>(type: "TEXT", nullable: false),
                    Patronymic = table.Column<string>(type: "TEXT", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VK = table.Column<string>(type: "TEXT", nullable: true),
                    Disability = table.Column<bool>(type: "INTEGER", nullable: false),
                    ClothingSize = table.Column<int>(type: "INTEGER", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteers", x => x.IdVolunteer);
                });

            migrationBuilder.CreateTable(
                name: "Participations",
                columns: table => new
                {
                    IdParticipation = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Volunteer = table.Column<int>(type: "INTEGER", nullable: false),
                    Measure = table.Column<int>(type: "INTEGER", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participations", x => x.IdParticipation);
                    table.ForeignKey(
                        name: "FK_Participations_Measures_Measure",
                        column: x => x.Measure,
                        principalTable: "Measures",
                        principalColumn: "IdMeasure",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Participations_Volunteers_Volunteer",
                        column: x => x.Volunteer,
                        principalTable: "Volunteers",
                        principalColumn: "IdVolunteer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Participations_Measure",
                table: "Participations",
                column: "Measure");

            migrationBuilder.CreateIndex(
                name: "IX_Participations_Volunteer",
                table: "Participations",
                column: "Volunteer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participations");

            migrationBuilder.DropTable(
                name: "Measures");

            migrationBuilder.DropTable(
                name: "Volunteers");
        }
    }
}
