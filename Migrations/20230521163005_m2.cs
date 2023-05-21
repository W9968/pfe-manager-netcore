using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WALASEBAI.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Soutenance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Heure = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PFEID = table.Column<int>(type: "int", nullable: false),
                    PresidentID = table.Column<int>(type: "int", nullable: false),
                    RapporteurID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soutenance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Soutenance_Enseignant_PresidentID",
                        column: x => x.PresidentID,
                        principalTable: "Enseignant",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Soutenance_Enseignant_RapporteurID",
                        column: x => x.RapporteurID,
                        principalTable: "Enseignant",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Soutenance_PFE_PFEID",
                        column: x => x.PFEID,
                        principalTable: "PFE",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Soutenance_PFEID",
                table: "Soutenance",
                column: "PFEID");

            migrationBuilder.CreateIndex(
                name: "IX_Soutenance_PresidentID",
                table: "Soutenance",
                column: "PresidentID");

            migrationBuilder.CreateIndex(
                name: "IX_Soutenance_RapporteurID",
                table: "Soutenance",
                column: "RapporteurID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Soutenance");
        }
    }
}
