using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_Portal.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeeHeads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeHeads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Semesters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semesters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentBasics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MotherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PresentAdd = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PermanentAdd = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentBasics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCommon = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Technologys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technologys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StdAmounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StdId = table.Column<int>(type: "int", nullable: false),
                    FeeHeadId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    PayAmount = table.Column<float>(type: "real", nullable: false),
                    DiscountAmount = table.Column<float>(type: "real", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StdAmounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StdAmounts_FeeHeads_FeeHeadId",
                        column: x => x.FeeHeadId,
                        principalTable: "FeeHeads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StdAmounts_StudentBasics_StdId",
                        column: x => x.StdId,
                        principalTable: "StudentBasics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StdSemesters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StdId = table.Column<int>(type: "int", nullable: false),
                    SemesterId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StdSemesters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StdSemesters_Semesters_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semesters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StdSemesters_StudentBasics_StdId",
                        column: x => x.StdId,
                        principalTable: "StudentBasics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentAcademics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoardRoll = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Registration = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Session = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShiftInfo = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Semester = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Year = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAcademics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentAcademics_StudentBasics_StudentId",
                        column: x => x.StudentId,
                        principalTable: "StudentBasics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechwithSubjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechId = table.Column<int>(type: "int", nullable: false),
                    SubId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechwithSubjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechwithSubjects_Subjects_SubId",
                        column: x => x.SubId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TechwithSubjects_Technologys_TechId",
                        column: x => x.TechId,
                        principalTable: "Technologys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StdAmounts_FeeHeadId",
                table: "StdAmounts",
                column: "FeeHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_StdAmounts_StdId",
                table: "StdAmounts",
                column: "StdId");

            migrationBuilder.CreateIndex(
                name: "IX_StdSemesters_SemesterId",
                table: "StdSemesters",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_StdSemesters_StdId",
                table: "StdSemesters",
                column: "StdId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAcademics_StudentId",
                table: "StudentAcademics",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_TechwithSubjects_SubId",
                table: "TechwithSubjects",
                column: "SubId");

            migrationBuilder.CreateIndex(
                name: "IX_TechwithSubjects_TechId",
                table: "TechwithSubjects",
                column: "TechId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StdAmounts");

            migrationBuilder.DropTable(
                name: "StdSemesters");

            migrationBuilder.DropTable(
                name: "StudentAcademics");

            migrationBuilder.DropTable(
                name: "TechwithSubjects");

            migrationBuilder.DropTable(
                name: "FeeHeads");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.DropTable(
                name: "StudentBasics");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Technologys");
        }
    }
}
