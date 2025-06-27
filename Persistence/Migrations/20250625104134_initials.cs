using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasicUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountStatus = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubcriptionPackages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubcriptionPackages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_BasicUser_UserId",
                        column: x => x.UserId,
                        principalTable: "BasicUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_BasicUser_UserId",
                        column: x => x.UserId,
                        principalTable: "BasicUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_BasicUser_UserId",
                        column: x => x.UserId,
                        principalTable: "BasicUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoryPurchases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SubcriptionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryPurchases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryPurchases_BasicUser_UserId",
                        column: x => x.UserId,
                        principalTable: "BasicUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ReceiverId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_BasicUser_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "BasicUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notifications_BasicUser_SenderId",
                        column: x => x.SenderId,
                        principalTable: "BasicUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PremiumUsers",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PremiumUsers", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_PremiumUsers_BasicUser_UserId",
                        column: x => x.UserId,
                        principalTable: "BasicUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvatarUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Profiles_BasicUser_UserId",
                        column: x => x.UserId,
                        principalTable: "BasicUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_BasicUser_UserId",
                        column: x => x.UserId,
                        principalTable: "BasicUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PackageOfUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubcriptionPackagesId = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageOfUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackageOfUsers_BasicUser_UserId",
                        column: x => x.UserId,
                        principalTable: "BasicUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackageOfUsers_SubcriptionPackages_SubcriptionPackagesId",
                        column: x => x.SubcriptionPackagesId,
                        principalTable: "SubcriptionPackages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BankQuestions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionTypeId = table.Column<int>(type: "int", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PremiumUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankQuestions", x => x.id);
                    table.ForeignKey(
                        name: "FK_BankQuestions_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankQuestions_PremiumUsers_PremiumUserId",
                        column: x => x.PremiumUserId,
                        principalTable: "PremiumUsers",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_BankQuestions_QuestionTypes_QuestionTypeId",
                        column: x => x.QuestionTypeId,
                        principalTable: "QuestionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Examss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PremiumUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SubjectId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalQuestion = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    TotalTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Examss_PremiumUsers_PremiumUserId",
                        column: x => x.PremiumUserId,
                        principalTable: "PremiumUsers",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Examss_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankQuestionId = table.Column<int>(type: "int", nullable: false),
                    AnswerText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCorrected = table.Column<bool>(type: "bit", nullable: false),
                    MatchingPairKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Answers_BankQuestions_BankQuestionId",
                        column: x => x.BankQuestionId,
                        principalTable: "BankQuestions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamAccessess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    AccessDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamAccessess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamAccessess_BasicUser_userId",
                        column: x => x.userId,
                        principalTable: "BasicUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamAccessess_Examss_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Examss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamssScoreds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubmitedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Score = table.Column<double>(type: "float", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamssScoreds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamssScoreds_BasicUser_UserId",
                        column: x => x.UserId,
                        principalTable: "BasicUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExamssScoreds_Examss_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Examss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favourites",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => new { x.UserId, x.ExamId });
                    table.ForeignKey(
                        name: "FK_Favourites_BasicUser_UserId",
                        column: x => x.UserId,
                        principalTable: "BasicUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Favourites_Examss_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Examss",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "QuestionExams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    BankQuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionTypeId = table.Column<int>(type: "int", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionExams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionExams_BankQuestions_BankQuestionId",
                        column: x => x.BankQuestionId,
                        principalTable: "BankQuestions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionExams_Examss_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Examss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAccessExams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccessExams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAccessExams_BasicUser_BasicUserId",
                        column: x => x.BasicUserId,
                        principalTable: "BasicUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserAccessExams_Examss_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Examss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamAnswereds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamScoredId = table.Column<int>(type: "int", nullable: false),
                    AnswerId = table.Column<int>(type: "int", nullable: false),
                    QuestionExamId = table.Column<int>(type: "int", nullable: false),
                    IsCorrected = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamAnswereds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamAnswereds_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ExamAnswereds_ExamssScoreds_ExamScoredId",
                        column: x => x.ExamScoredId,
                        principalTable: "ExamssScoreds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamAnswereds_QuestionExams_QuestionExamId",
                        column: x => x.QuestionExamId,
                        principalTable: "QuestionExams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ForumPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    IsPinned = table.Column<bool>(type: "bit", nullable: false),
                    ForumStatus = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuestionExamId = table.Column<int>(type: "int", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumPosts_BasicUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "BasicUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumPosts_QuestionExams_QuestionExamId",
                        column: x => x.QuestionExamId,
                        principalTable: "QuestionExams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ForumPosts_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ForumComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommentById = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumComments_BasicUser_UserId",
                        column: x => x.UserId,
                        principalTable: "BasicUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ForumComments_ForumPosts_CommentById",
                        column: x => x.CommentById,
                        principalTable: "ForumPosts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ForumVoteds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    VotedById = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VotedType = table.Column<int>(type: "int", nullable: false),
                    VotedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumVoteds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumVoteds_BasicUser_VotedById",
                        column: x => x.VotedById,
                        principalTable: "BasicUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumVoteds_ForumPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "ForumPosts",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DisplayName", "UpdateBy", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(5922), null, "Easy", null, null },
                    { 2, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(5925), null, "Medium", null, null },
                    { 3, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(5927), null, "Hard", null, null }
                });

            migrationBuilder.InsertData(
                table: "QuestionTypes",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdateBy", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(5968), null, "Multiple Choice", null, null },
                    { 2, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(5971), null, "Fill in the Blank", null, null },
                    { 3, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(5974), null, "Matching", null, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "BASIC_USER", "BASIC_USER" },
                    { "2", null, "PREMIUM_USER", "PREMIUM_USER" },
                    { "3", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "SubcriptionPackages",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Duration", "Name", "Price", "UpdateBy", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6157), null, "Truy cập nội dung cơ bản", 14, "Gói cơ bản", 99000.0, null, null },
                    { 2, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6161), null, "Truy cập toàn bộ nội dung và hỗ trợ ưu tiên", 30, "Gói nâng cao", 199000.0, null, null },
                    { 3, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6163), null, "Truy cập không giới hạn trong 1 năm", 365, "Gói hàng năm", 1990000.0, null, null }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdateBy", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6050), null, "Toán học", null, null },
                    { 2, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6054), null, "Ngữ văn", null, null },
                    { 3, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6057), null, "Tiếng Anh", null, null },
                    { 4, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6059), null, "Vật lý", null, null },
                    { 5, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6062), null, "Hóa học", null, null },
                    { 6, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6067), null, "Sinh học", null, null },
                    { 7, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6069), null, "Lịch sử", null, null },
                    { 8, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6071), null, "Địa lý", null, null },
                    { 9, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6073), null, "Giáo dục công dân", null, null },
                    { 10, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6077), null, "Tin học", null, null },
                    { 11, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6079), null, "Công nghệ", null, null },
                    { 12, new DateTime(2025, 6, 25, 17, 41, 33, 858, DateTimeKind.Local).AddTicks(6082), null, "Thể dục", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_BankQuestionId",
                table: "Answers",
                column: "BankQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_BankQuestions_LevelId",
                table: "BankQuestions",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_BankQuestions_PremiumUserId",
                table: "BankQuestions",
                column: "PremiumUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BankQuestions_QuestionTypeId",
                table: "BankQuestions",
                column: "QuestionTypeId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "BasicUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "BasicUser",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ExamAccessess_ExamId",
                table: "ExamAccessess",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamAccessess_userId",
                table: "ExamAccessess",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamAnswereds_AnswerId",
                table: "ExamAnswereds",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamAnswereds_ExamScoredId",
                table: "ExamAnswereds",
                column: "ExamScoredId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamAnswereds_QuestionExamId",
                table: "ExamAnswereds",
                column: "QuestionExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Examss_PremiumUserId",
                table: "Examss",
                column: "PremiumUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Examss_SubjectId",
                table: "Examss",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamssScoreds_ExamId",
                table: "ExamssScoreds",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamssScoreds_UserId",
                table: "ExamssScoreds",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_ExamId",
                table: "Favourites",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumComments_CommentById",
                table: "ForumComments",
                column: "CommentById");

            migrationBuilder.CreateIndex(
                name: "IX_ForumComments_UserId",
                table: "ForumComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumPosts_CreatedById",
                table: "ForumPosts",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ForumPosts_QuestionExamId",
                table: "ForumPosts",
                column: "QuestionExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumPosts_SubjectId",
                table: "ForumPosts",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumVoteds_PostId",
                table: "ForumVoteds",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumVoteds_VotedById",
                table: "ForumVoteds",
                column: "VotedById");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryPurchases_UserId",
                table: "HistoryPurchases",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_ReceiverId",
                table: "Notifications",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_SenderId",
                table: "Notifications",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageOfUsers_SubcriptionPackagesId",
                table: "PackageOfUsers",
                column: "SubcriptionPackagesId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageOfUsers_UserId",
                table: "PackageOfUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionExams_BankQuestionId",
                table: "QuestionExams",
                column: "BankQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionExams_ExamId",
                table: "QuestionExams",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccessExams_BasicUserId",
                table: "UserAccessExams",
                column: "BasicUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccessExams_ExamId",
                table: "UserAccessExams",
                column: "ExamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ExamAccessess");

            migrationBuilder.DropTable(
                name: "ExamAnswereds");

            migrationBuilder.DropTable(
                name: "Favourites");

            migrationBuilder.DropTable(
                name: "ForumComments");

            migrationBuilder.DropTable(
                name: "ForumVoteds");

            migrationBuilder.DropTable(
                name: "HistoryPurchases");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "PackageOfUsers");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "UserAccessExams");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "ExamssScoreds");

            migrationBuilder.DropTable(
                name: "ForumPosts");

            migrationBuilder.DropTable(
                name: "SubcriptionPackages");

            migrationBuilder.DropTable(
                name: "QuestionExams");

            migrationBuilder.DropTable(
                name: "BankQuestions");

            migrationBuilder.DropTable(
                name: "Examss");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "QuestionTypes");

            migrationBuilder.DropTable(
                name: "PremiumUsers");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "BasicUser");
        }
    }
}
