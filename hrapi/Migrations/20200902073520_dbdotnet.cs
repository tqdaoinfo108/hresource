using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hrapi.Migrations
{
    public partial class dbdotnet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catagories",
                columns: table => new
                {
                    CatagoriesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Desciption = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catagories", x => x.CatagoriesID);
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
                    DateCreated = table.Column<DateTime>(nullable: true),
                    States = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companys", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "events",
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
                    UserHostID = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_events", x => x.EventID);
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
                name: "departments",
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
                    table.PrimaryKey("PK_departments", x => x.DepartmentID);
                    table.ForeignKey(
                        name: "FK_departments_companys_CompanyID",
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
                name: "eventCatagories",
                columns: table => new
                {
                    EventCatagoriesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventID = table.Column<int>(nullable: true),
                    EventsEventID = table.Column<int>(nullable: true),
                    CatagoriesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eventCatagories", x => x.EventCatagoriesID);
                    table.ForeignKey(
                        name: "FK_eventCatagories_Catagories_CatagoriesID",
                        column: x => x.CatagoriesID,
                        principalTable: "Catagories",
                        principalColumn: "CatagoriesID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_eventCatagories_events_EventsEventID",
                        column: x => x.EventsEventID,
                        principalTable: "events",
                        principalColumn: "EventID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "toDoLists",
                columns: table => new
                {
                    ToDoListID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StatusID = table.Column<int>(nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    TimeStart = table.Column<DateTime>(nullable: true),
                    TimeEnd = table.Column<DateTime>(nullable: true),
                    UserCreatedID = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    StaffAssignedID = table.Column<int>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false),
                    DepartmentsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toDoLists", x => x.ToDoListID);
                    table.ForeignKey(
                        name: "FK_toDoLists_departments_DepartmentsID",
                        column: x => x.DepartmentsID,
                        principalTable: "departments",
                        principalColumn: "DepartmentID",
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
                    DateOut = table.Column<DateTime>(nullable: true),
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
                        name: "FK_staffs_departments_DepartmentsID",
                        column: x => x.DepartmentsID,
                        principalTable: "departments",
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
                name: "comments",
                columns: table => new
                {
                    CommentsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: true),
                    DateTimeCreate = table.Column<DateTime>(nullable: true),
                    UserCreateName = table.Column<string>(nullable: true),
                    ToDoListsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.CommentsID);
                    table.ForeignKey(
                        name: "FK_comments_toDoLists_ToDoListsID",
                        column: x => x.ToDoListsID,
                        principalTable: "toDoLists",
                        principalColumn: "ToDoListID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "enventsStaff",
                columns: table => new
                {
                    StaffEventID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffID = table.Column<int>(nullable: false),
                    EventID = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enventsStaff", x => x.StaffEventID);
                    table.ForeignKey(
                        name: "FK_enventsStaff_events_EventID",
                        column: x => x.EventID,
                        principalTable: "events",
                        principalColumn: "EventID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_enventsStaff_staffs_StaffID",
                        column: x => x.StaffID,
                        principalTable: "staffs",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_comments_ToDoListsID",
                table: "comments",
                column: "ToDoListsID");

            migrationBuilder.CreateIndex(
                name: "IX_departments_CompanyID",
                table: "departments",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_enventsStaff_EventID",
                table: "enventsStaff",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_enventsStaff_StaffID",
                table: "enventsStaff",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_eventCatagories_CatagoriesID",
                table: "eventCatagories",
                column: "CatagoriesID");

            migrationBuilder.CreateIndex(
                name: "IX_eventCatagories_EventsEventID",
                table: "eventCatagories",
                column: "EventsEventID");

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

            migrationBuilder.CreateIndex(
                name: "IX_toDoLists_DepartmentsID",
                table: "toDoLists",
                column: "DepartmentsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "enventsStaff");

            migrationBuilder.DropTable(
                name: "eventCatagories");

            migrationBuilder.DropTable(
                name: "news");

            migrationBuilder.DropTable(
                name: "states");

            migrationBuilder.DropTable(
                name: "toDoLists");

            migrationBuilder.DropTable(
                name: "Catagories");

            migrationBuilder.DropTable(
                name: "events");

            migrationBuilder.DropTable(
                name: "newsCategories");

            migrationBuilder.DropTable(
                name: "staffs");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "positions");

            migrationBuilder.DropTable(
                name: "companys");
        }
    }
}
