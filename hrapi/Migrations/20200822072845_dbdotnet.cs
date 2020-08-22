using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hrapi.Migrations
{
    public partial class dbdotnet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bookingEvents",
                columns: table => new
                {
                    EventID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StatusID = table.Column<int>(nullable: false),
                    TimeStart = table.Column<DateTime>(nullable: false),
                    TimeEnd = table.Column<DateTime>(nullable: false),
                    ActionUrl = table.Column<string>(nullable: true),
                    ColorCode = table.Column<string>(nullable: true),
                    UserHostID = table.Column<int>(nullable: false),
                    UserCreatedID = table.Column<int>(nullable: false),
                    UserUpdatedID = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    IsReminded = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookingEvents", x => x.EventID);
                });

            migrationBuilder.CreateTable(
                name: "groups",
                columns: table => new
                {
                    GroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(nullable: false),
                    GroupName = table.Column<string>(nullable: true),
                    GroupDescription = table.Column<string>(nullable: true),
                    StatusID = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    UserCreated = table.Column<string>(nullable: true),
                    UserUpdated = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groups", x => x.GroupID);
                });

            migrationBuilder.CreateTable(
                name: "positions",
                columns: table => new
                {
                    PositionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(nullable: false),
                    PositionName = table.Column<string>(nullable: true),
                    PositionDescription = table.Column<string>(nullable: true),
                    StatusID = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    UserCreated = table.Column<string>(nullable: true),
                    UserUpdated = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_positions", x => x.PositionID);
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
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserUpdated = table.Column<string>(nullable: true),
                    StatusIDStatesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companys", x => x.CompanyID);
                    table.ForeignKey(
                        name: "FK_companys_states_StatusIDStatesID",
                        column: x => x.StatusIDStatesID,
                        principalTable: "states",
                        principalColumn: "StatesID",
                        onDelete: ReferentialAction.Restrict);
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
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserCreated = table.Column<string>(nullable: true),
                    UserUpdated = table.Column<string>(nullable: true),
                    StatusIDStatesID = table.Column<int>(nullable: true),
                    CompanyID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                    table.ForeignKey(
                        name: "FK_Departments_companys_CompanyID1",
                        column: x => x.CompanyID1,
                        principalTable: "companys",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Departments_states_StatusIDStatesID",
                        column: x => x.StatusIDStatesID,
                        principalTable: "states",
                        principalColumn: "StatesID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "newsCategories",
                columns: table => new
                {
                    CategoryNewsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusID = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    CategoryNewsTitle = table.Column<string>(nullable: true),
                    CategoryNewsDescription = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    UserCreated = table.Column<string>(nullable: true),
                    UserUpdated = table.Column<string>(nullable: true),
                    CompanyID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newsCategories", x => x.CategoryNewsID);
                    table.ForeignKey(
                        name: "FK_newsCategories_companys_CompanyID1",
                        column: x => x.CompanyID1,
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
                    StaffCode = table.Column<string>(nullable: true),
                    Passwords = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    StatusID = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    UserCreated = table.Column<string>(nullable: true),
                    UserUpdated = table.Column<string>(nullable: true),
                    LastLogin = table.Column<DateTime>(nullable: true),
                    Token = table.Column<string>(nullable: true),
                    CompanysIDCompanyID = table.Column<int>(nullable: true),
                    PositionsIDPositionID = table.Column<int>(nullable: true),
                    DepartmentsIDDepartmentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffs", x => x.StaffID);
                    table.ForeignKey(
                        name: "FK_staffs_companys_CompanysIDCompanyID",
                        column: x => x.CompanysIDCompanyID,
                        principalTable: "companys",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_staffs_Departments_DepartmentsIDDepartmentID",
                        column: x => x.DepartmentsIDDepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_staffs_positions_PositionsIDPositionID",
                        column: x => x.PositionsIDPositionID,
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
                    StatusID = table.Column<int>(nullable: false),
                    ShortDescription = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    UserCreated = table.Column<string>(nullable: true),
                    UserUpdated = table.Column<string>(nullable: true),
                    CategoryNewsID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_news", x => x.NewsID);
                    table.ForeignKey(
                        name: "FK_news_newsCategories_CategoryNewsID1",
                        column: x => x.CategoryNewsID1,
                        principalTable: "newsCategories",
                        principalColumn: "CategoryNewsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_companys_StatusIDStatesID",
                table: "companys",
                column: "StatusIDStatesID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CompanyID1",
                table: "Departments",
                column: "CompanyID1");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_StatusIDStatesID",
                table: "Departments",
                column: "StatusIDStatesID");

            migrationBuilder.CreateIndex(
                name: "IX_news_CategoryNewsID1",
                table: "news",
                column: "CategoryNewsID1");

            migrationBuilder.CreateIndex(
                name: "IX_newsCategories_CompanyID1",
                table: "newsCategories",
                column: "CompanyID1");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_CompanysIDCompanyID",
                table: "staffs",
                column: "CompanysIDCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_DepartmentsIDDepartmentID",
                table: "staffs",
                column: "DepartmentsIDDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_PositionsIDPositionID",
                table: "staffs",
                column: "PositionsIDPositionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookingEvents");

            migrationBuilder.DropTable(
                name: "groups");

            migrationBuilder.DropTable(
                name: "news");

            migrationBuilder.DropTable(
                name: "staffs");

            migrationBuilder.DropTable(
                name: "newsCategories");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "positions");

            migrationBuilder.DropTable(
                name: "companys");

            migrationBuilder.DropTable(
                name: "states");
        }
    }
}
