using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hrapi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "companys",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyDescription = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    States = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companys", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "states",
                columns: table => new
                {
                    StatesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_states", x => x.StatesID);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentDepartmentID = table.Column<int>(nullable: true),
                    IsRootDepartment = table.Column<bool>(nullable: false),
                    DepartmentName = table.Column<string>(nullable: true),
                    DepartmentDescription = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    CompanyID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                    table.ForeignKey(
                        name: "FK_Departments_companys_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "companys",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "newsCategories",
                columns: table => new
                {
                    CategoryNewsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusID = table.Column<int>(nullable: false),
                    CategoryNewsTitle = table.Column<string>(nullable: true),
                    CategoryNewsDescription = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    CompanyID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newsCategories", x => x.CategoryNewsID);
                    table.ForeignKey(
                        name: "FK_newsCategories_companys_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "companys",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "positions",
                columns: table => new
                {
                    PositionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(nullable: true),
                    PositionDescription = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    CompanyID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_positions", x => x.PositionID);
                    table.ForeignKey(
                        name: "FK_positions_companys_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "companys",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "staffs",
                columns: table => new
                {
                    StaffID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Avatar = table.Column<string>(nullable: true),
                    StaffCode = table.Column<string>(nullable: true),
                    Passwords = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    StatusID = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    LastLogin = table.Column<DateTime>(nullable: true),
                    Token = table.Column<string>(nullable: true),
                    CompanyID = table.Column<int>(nullable: true),
                    PositionsID = table.Column<int>(nullable: true),
                    DepartmentsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffs", x => x.StaffID);
                    table.ForeignKey(
                        name: "FK_staffs_companys_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "companys",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_staffs_Departments_DepartmentsID",
                        column: x => x.DepartmentsID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_staffs_positions_PositionsID",
                        column: x => x.PositionsID,
                        principalTable: "positions",
                        principalColumn: "PositionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "news",
                columns: table => new
                {
                    NewsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<int>(nullable: false),
                    UserCreatedName = table.Column<string>(nullable: true),
                    IsSeen = table.Column<bool>(nullable: false),
                    StaffID = table.Column<int>(nullable: true),
                    CategoryNewsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_news", x => x.NewsID);
                    table.ForeignKey(
                        name: "FK_news_newsCategories_CategoryNewsID",
                        column: x => x.CategoryNewsID,
                        principalTable: "newsCategories",
                        principalColumn: "CategoryNewsID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_news_staffs_StaffID",
                        column: x => x.StaffID,
                        principalTable: "staffs",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CompanyID",
                table: "Departments",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_news_CategoryNewsID",
                table: "news",
                column: "CategoryNewsID");

            migrationBuilder.CreateIndex(
                name: "IX_news_StaffID",
                table: "news",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_newsCategories_CompanyID",
                table: "newsCategories",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_positions_CompanyID",
                table: "positions",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_CompanyID",
                table: "staffs",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_DepartmentsID",
                table: "staffs",
                column: "DepartmentsID");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_PositionsID",
                table: "staffs",
                column: "PositionsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "news");

            migrationBuilder.DropTable(
                name: "states");

            migrationBuilder.DropTable(
                name: "newsCategories");

            migrationBuilder.DropTable(
                name: "staffs");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "positions");

            migrationBuilder.DropTable(
                name: "companys");
        }
    }
}
