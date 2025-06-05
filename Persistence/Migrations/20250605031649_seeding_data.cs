using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class seeding_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DisplayName", "UpdateBy", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3661), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Easy", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3664), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medium", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3665), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "QuestionTypes",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdateBy", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3697), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Multiple Choice", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3699), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fill in the Blank", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3701), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matching", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "SubcriptionPackages",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Duration", "Name", "Price", "UpdateBy", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5420), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Truy cập nội dung cơ bản", 14, "Gói cơ bản", 99000.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5423), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Truy cập toàn bộ nội dung và hỗ trợ ưu tiên", 30, "Gói nâng cao", 199000.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5425), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Truy cập không giới hạn trong 1 năm", 365, "Gói hàng năm", 1990000.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdateBy", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5352), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toán học", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5356), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ngữ văn", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5357), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tiếng Anh", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5359), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vật lý", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5361), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hóa học", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5364), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinh học", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5366), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lịch sử", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5367), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Địa lý", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5369), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giáo dục công dân", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5371), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tin học", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5373), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Công nghệ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5375), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thể dục", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "BankQuestions",
                columns: new[] { "id", "Content", "CreatedAt", "DeletedAt", "IsPublic", "LevelId", "PremiumUserId", "QuestionTypeId", "UpdateBy", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Câu 1: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Câu 2: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Câu 3: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Câu 4: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Câu 5: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Câu 6: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Câu 7: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Câu 8: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Câu 9: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Câu 10: Phép biện chứng - Nội dung trọng tâm số 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Câu 11: Phép biện chứng - Nội dung trọng tâm số 11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Câu 12: Phép biện chứng - Nội dung trọng tâm số 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Câu 13: Phép biện chứng - Nội dung trọng tâm số 13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Câu 14: Phép biện chứng - Nội dung trọng tâm số 14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Câu 15: Phép biện chứng - Nội dung trọng tâm số 15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Câu 16: Phép biện chứng - Nội dung trọng tâm số 16", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "Câu 17: Phép biện chứng - Nội dung trọng tâm số 17", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "Câu 18: Phép biện chứng - Nội dung trọng tâm số 18", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "Câu 19: Vật chất và ý thức - Nội dung trọng tâm số 19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "Câu 20: Vật chất và ý thức - Nội dung trọng tâm số 20", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "Câu 21: Vật chất và ý thức - Nội dung trọng tâm số 21", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "Câu 22: Vật chất và ý thức - Nội dung trọng tâm số 22", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, "Câu 23: Vật chất và ý thức - Nội dung trọng tâm số 23", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, "Câu 24: Vật chất và ý thức - Nội dung trọng tâm số 24", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, "Câu 25: Vật chất và ý thức - Nội dung trọng tâm số 25", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, "Câu 26: Vật chất và ý thức - Nội dung trọng tâm số 26", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, "Câu 27: Vật chất và ý thức - Nội dung trọng tâm số 27", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, "Câu 28: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 28", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, "Câu 29: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 29", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, "Câu 30: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 30", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, "Câu 31: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 31", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, "Câu 32: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 32", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, "Câu 33: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 33", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, "Câu 34: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 34", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, "Câu 35: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 35", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, "Câu 36: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 36", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, "Câu 37: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 37", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, "Câu 38: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 38", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, "Câu 39: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 39", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, "Câu 40: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 40", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, "Câu 41: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 41", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, "Câu 42: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 42", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, "Câu 43: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 43", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, "Câu 44: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 44", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, "Câu 45: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 45", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, "Câu 46: Nhận thức và thực tiễn - Nội dung trọng tâm số 46", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, "Câu 47: Nhận thức và thực tiễn - Nội dung trọng tâm số 47", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, "Câu 48: Nhận thức và thực tiễn - Nội dung trọng tâm số 48", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, "Câu 49: Nhận thức và thực tiễn - Nội dung trọng tâm số 49", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, "Câu 50: Nhận thức và thực tiễn - Nội dung trọng tâm số 50", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, "Câu 51: Nhận thức và thực tiễn - Nội dung trọng tâm số 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, "Câu 52: Nhận thức và thực tiễn - Nội dung trọng tâm số 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, "Câu 53: Nhận thức và thực tiễn - Nội dung trọng tâm số 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, "Câu 54: Nhận thức và thực tiễn - Nội dung trọng tâm số 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, "Câu 55: Vai trò của con người - Nội dung trọng tâm số 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, "Câu 56: Vai trò của con người - Nội dung trọng tâm số 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, "Câu 57: Vai trò của con người - Nội dung trọng tâm số 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, "Câu 58: Vai trò của con người - Nội dung trọng tâm số 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, "Câu 59: Vai trò của con người - Nội dung trọng tâm số 9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, "Câu 60: Vai trò của con người - Nội dung trọng tâm số 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, "Câu 61: Vai trò của con người - Nội dung trọng tâm số 11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, "Câu 62: Vai trò của con người - Nội dung trọng tâm số 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, "Câu 63: Vai trò của con người - Nội dung trọng tâm số 13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, "Câu 64: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, "Câu 65: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, "Câu 66: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 16", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, "Câu 67: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 17", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, "Câu 68: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 18", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, "Câu 69: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, "Câu 70: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 20", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, "Câu 71: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 21", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, "Câu 72: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 22", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, "Câu 73: Hình thái kinh tế xã hội - Nội dung trọng tâm số 23", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, "Câu 74: Hình thái kinh tế xã hội - Nội dung trọng tâm số 24", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, "Câu 75: Hình thái kinh tế xã hội - Nội dung trọng tâm số 25", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, "Câu 76: Hình thái kinh tế xã hội - Nội dung trọng tâm số 26", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, "Câu 77: Hình thái kinh tế xã hội - Nội dung trọng tâm số 27", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, "Câu 78: Hình thái kinh tế xã hội - Nội dung trọng tâm số 28", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, "Câu 79: Hình thái kinh tế xã hội - Nội dung trọng tâm số 29", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, "Câu 80: Hình thái kinh tế xã hội - Nội dung trọng tâm số 30", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, "Câu 81: Hình thái kinh tế xã hội - Nội dung trọng tâm số 31", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, "Câu 82: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 32", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, "Câu 83: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 33", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, "Câu 84: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 34", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, "Câu 85: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 35", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, "Câu 86: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 36", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, "Câu 87: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 37", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, "Câu 88: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 38", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, "Câu 89: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 39", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, "Câu 90: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 40", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, "Câu 91: Nhà nước và cách mạng - Nội dung trọng tâm số 41", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, "Câu 92: Nhà nước và cách mạng - Nội dung trọng tâm số 42", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, "Câu 93: Nhà nước và cách mạng - Nội dung trọng tâm số 43", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, "Câu 94: Nhà nước và cách mạng - Nội dung trọng tâm số 44", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, "Câu 95: Nhà nước và cách mạng - Nội dung trọng tâm số 45", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, "Câu 96: Nhà nước và cách mạng - Nội dung trọng tâm số 46", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, "Câu 97: Nhà nước và cách mạng - Nội dung trọng tâm số 47", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, "Câu 98: Nhà nước và cách mạng - Nội dung trọng tâm số 48", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, "Câu 99: Nhà nước và cách mạng - Nội dung trọng tâm số 49", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, "Câu 100: Chủ nghĩa xã hội khoa học - Nội dung trọng tâm số 50", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Examss",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsPublic", "PremiumUserId", "SourceText", "SubjectId", "Title", "TotalQuestion", "UpdateBy", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Các câu hỏi thuộc nội dung: Vật chất & Ý thức, Lượng – Chất, Phép biện chứng", true, null, "Tổng hợp 12 nội dung môn Triết học", 1, "Đề thi Triết học - Phần 1", 50, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(5080), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Các câu hỏi thuộc nội dung: Con người, Nhận thức, Thực tiễn, Chủ nghĩa xã hội", true, null, "Tổng hợp 12 nội dung môn Triết học", 1, "Đề thi Triết học - Phần 2", 50, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "id", "AnswerText", "BankQuestionId", "CreatedAt", "DeletedAt", "IsCorrected", "MatchingPairKey", "UpdateBy", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Đáp án 1 cho câu 1", 1, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3995), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Đáp án 2 cho câu 1", 1, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3997), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Đáp án 3 cho câu 1", 1, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3998), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Đáp án 4 cho câu 1", 1, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(3999), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Đáp án 1 cho câu 2", 2, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Đáp án 2 cho câu 2", 2, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4001), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Đáp án 3 cho câu 2", 2, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4002), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Đáp án 4 cho câu 2", 2, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4059), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Đáp án 1 cho câu 3", 3, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4060), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Đáp án 2 cho câu 3", 3, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4061), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Đáp án 3 cho câu 3", 3, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4062), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Đáp án 4 cho câu 3", 3, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4063), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Đáp án 1 cho câu 4", 4, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4064), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Đáp án 2 cho câu 4", 4, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4065), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Đáp án 3 cho câu 4", 4, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4066), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Đáp án 4 cho câu 4", 4, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4067), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "Đáp án 1 cho câu 5", 5, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4068), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "Đáp án 2 cho câu 5", 5, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4069), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "Đáp án 3 cho câu 5", 5, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4070), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "Đáp án 4 cho câu 5", 5, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4071), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "Đáp án 1 cho câu 6", 6, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4072), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "Đáp án 2 cho câu 6", 6, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4073), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, "Đáp án 3 cho câu 6", 6, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4074), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, "Đáp án 4 cho câu 6", 6, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4075), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, "Đáp án 1 cho câu 7", 7, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4076), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, "Đáp án 2 cho câu 7", 7, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4077), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, "Đáp án 3 cho câu 7", 7, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4077), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, "Đáp án 4 cho câu 7", 7, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4078), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, "Đáp án 1 cho câu 8", 8, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4079), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, "Đáp án 2 cho câu 8", 8, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4080), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, "Đáp án 3 cho câu 8", 8, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4082), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, "Đáp án 4 cho câu 8", 8, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4083), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, "Đáp án 1 cho câu 9", 9, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4084), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, "Đáp án 2 cho câu 9", 9, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4085), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, "Đáp án 3 cho câu 9", 9, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4086), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, "Đáp án 4 cho câu 9", 9, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4087), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, "Đáp án 1 cho câu 10", 10, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4088), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, "Đáp án 2 cho câu 10", 10, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4089), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, "Đáp án 3 cho câu 10", 10, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4090), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, "Đáp án 4 cho câu 10", 10, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4091), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, "Đáp án 1 cho câu 11", 11, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4092), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, "Đáp án 2 cho câu 11", 11, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4093), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, "Đáp án 3 cho câu 11", 11, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4093), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, "Đáp án 4 cho câu 11", 11, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4094), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, "Đáp án 1 cho câu 12", 12, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4095), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, "Đáp án 2 cho câu 12", 12, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4096), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, "Đáp án 3 cho câu 12", 12, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4097), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, "Đáp án 4 cho câu 12", 12, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4098), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, "Đáp án 1 cho câu 13", 13, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4099), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, "Đáp án 2 cho câu 13", 13, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4100), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, "Đáp án 3 cho câu 13", 13, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4101), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, "Đáp án 4 cho câu 13", 13, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4102), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, "Đáp án 1 cho câu 14", 14, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4102), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, "Đáp án 2 cho câu 14", 14, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4103), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, "Đáp án 3 cho câu 14", 14, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4104), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, "Đáp án 4 cho câu 14", 14, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4109), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, "Đáp án 1 cho câu 15", 15, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4110), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, "Đáp án 2 cho câu 15", 15, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4111), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, "Đáp án 3 cho câu 15", 15, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4112), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, "Đáp án 4 cho câu 15", 15, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4113), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, "Đáp án 1 cho câu 16", 16, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4114), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, "Đáp án 2 cho câu 16", 16, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4115), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, "Đáp án 3 cho câu 16", 16, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4116), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, "Đáp án 4 cho câu 16", 16, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4116), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, "Đáp án 1 cho câu 17", 17, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4117), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, "Đáp án 2 cho câu 17", 17, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4118), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, "Đáp án 3 cho câu 17", 17, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4119), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, "Đáp án 4 cho câu 17", 17, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4120), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, "Đáp án 1 cho câu 18", 18, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4121), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, "Đáp án 2 cho câu 18", 18, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4122), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, "Đáp án 3 cho câu 18", 18, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4123), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, "Đáp án 4 cho câu 18", 18, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4124), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, "Đáp án 1 cho câu 19", 19, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4125), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, "Đáp án 2 cho câu 19", 19, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4126), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, "Đáp án 3 cho câu 19", 19, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4127), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, "Đáp án 4 cho câu 19", 19, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4128), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, "Đáp án 1 cho câu 20", 20, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4128), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, "Đáp án 2 cho câu 20", 20, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4129), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, "Đáp án 3 cho câu 20", 20, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4130), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, "Đáp án 4 cho câu 20", 20, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4131), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, "Đáp án 1 cho câu 21", 21, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4132), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, "Đáp án 2 cho câu 21", 21, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4134), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, "Đáp án 3 cho câu 21", 21, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4134), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, "Đáp án 4 cho câu 21", 21, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4135), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, "Đáp án 1 cho câu 22", 22, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4136), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, "Đáp án 2 cho câu 22", 22, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4137), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, "Đáp án 3 cho câu 22", 22, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4138), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, "Đáp án 4 cho câu 22", 22, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4139), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, "Đáp án 1 cho câu 23", 23, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4140), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, "Đáp án 2 cho câu 23", 23, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4141), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, "Đáp án 3 cho câu 23", 23, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4141), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, "Đáp án 4 cho câu 23", 23, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4142), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, "Đáp án 1 cho câu 24", 24, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4143), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, "Đáp án 2 cho câu 24", 24, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4144), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, "Đáp án 3 cho câu 24", 24, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4145), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, "Đáp án 4 cho câu 24", 24, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4146), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, "Đáp án 1 cho câu 25", 25, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4147), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, "Đáp án 2 cho câu 25", 25, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4147), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, "Đáp án 3 cho câu 25", 25, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4148), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, "Đáp án 4 cho câu 25", 25, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4149), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 101, "Đáp án 1 cho câu 26", 26, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4156), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 102, "Đáp án 2 cho câu 26", 26, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4157), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 103, "Đáp án 3 cho câu 26", 26, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4158), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 104, "Đáp án 4 cho câu 26", 26, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4159), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 105, "Đáp án 1 cho câu 27", 27, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4160), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 106, "Đáp án 2 cho câu 27", 27, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4161), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 107, "Đáp án 3 cho câu 27", 27, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4162), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 108, "Đáp án 4 cho câu 27", 27, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4163), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 109, "Đáp án 1 cho câu 28", 28, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4164), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 110, "Đáp án 2 cho câu 28", 28, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4165), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 111, "Đáp án 3 cho câu 28", 28, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4166), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 112, "Đáp án 4 cho câu 28", 28, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4167), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 113, "Đáp án 1 cho câu 29", 29, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4168), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 114, "Đáp án 2 cho câu 29", 29, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4169), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 115, "Đáp án 3 cho câu 29", 29, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4170), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 116, "Đáp án 4 cho câu 29", 29, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4171), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 117, "Đáp án 1 cho câu 30", 30, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4172), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 118, "Đáp án 2 cho câu 30", 30, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4172), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 119, "Đáp án 3 cho câu 30", 30, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4173), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 120, "Đáp án 4 cho câu 30", 30, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4174), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 121, "Đáp án 1 cho câu 31", 31, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4175), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 122, "Đáp án 2 cho câu 31", 31, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4176), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 123, "Đáp án 3 cho câu 31", 31, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4177), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 124, "Đáp án 4 cho câu 31", 31, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4178), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 125, "Đáp án 1 cho câu 32", 32, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4179), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 126, "Đáp án 2 cho câu 32", 32, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4180), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 127, "Đáp án 3 cho câu 32", 32, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4180), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 128, "Đáp án 4 cho câu 32", 32, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4181), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 129, "Đáp án 1 cho câu 33", 33, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4182), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 130, "Đáp án 2 cho câu 33", 33, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4183), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 131, "Đáp án 3 cho câu 33", 33, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4184), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 132, "Đáp án 4 cho câu 33", 33, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4187), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 133, "Đáp án 1 cho câu 34", 34, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4187), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 134, "Đáp án 2 cho câu 34", 34, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4188), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 135, "Đáp án 3 cho câu 34", 34, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4189), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 136, "Đáp án 4 cho câu 34", 34, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4190), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 137, "Đáp án 1 cho câu 35", 35, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4191), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 138, "Đáp án 2 cho câu 35", 35, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4192), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 139, "Đáp án 3 cho câu 35", 35, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4192), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 140, "Đáp án 4 cho câu 35", 35, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4193), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 141, "Đáp án 1 cho câu 36", 36, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4194), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 142, "Đáp án 2 cho câu 36", 36, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4195), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 143, "Đáp án 3 cho câu 36", 36, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4196), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 144, "Đáp án 4 cho câu 36", 36, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4197), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 145, "Đáp án 1 cho câu 37", 37, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4198), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 146, "Đáp án 2 cho câu 37", 37, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4199), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 147, "Đáp án 3 cho câu 37", 37, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4200), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 148, "Đáp án 4 cho câu 37", 37, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4201), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 149, "Đáp án 1 cho câu 38", 38, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4202), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 150, "Đáp án 2 cho câu 38", 38, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4203), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 151, "Đáp án 3 cho câu 38", 38, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4203), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 152, "Đáp án 4 cho câu 38", 38, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4204), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 153, "Đáp án 1 cho câu 39", 39, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4205), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 154, "Đáp án 2 cho câu 39", 39, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4206), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 155, "Đáp án 3 cho câu 39", 39, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4207), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 156, "Đáp án 4 cho câu 39", 39, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4208), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 157, "Đáp án 1 cho câu 40", 40, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4209), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 158, "Đáp án 2 cho câu 40", 40, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4210), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 159, "Đáp án 3 cho câu 40", 40, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4212), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 160, "Đáp án 4 cho câu 40", 40, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4213), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 161, "Đáp án 1 cho câu 41", 41, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4214), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 162, "Đáp án 2 cho câu 41", 41, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4215), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 163, "Đáp án 3 cho câu 41", 41, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4215), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 164, "Đáp án 4 cho câu 41", 41, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4216), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 165, "Đáp án 1 cho câu 42", 42, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4217), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 166, "Đáp án 2 cho câu 42", 42, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4218), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 167, "Đáp án 3 cho câu 42", 42, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4219), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 168, "Đáp án 4 cho câu 42", 42, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4220), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 169, "Đáp án 1 cho câu 43", 43, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4220), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 170, "Đáp án 2 cho câu 43", 43, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4221), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 171, "Đáp án 3 cho câu 43", 43, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4222), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 172, "Đáp án 4 cho câu 43", 43, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4223), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 173, "Đáp án 1 cho câu 44", 44, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4224), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 174, "Đáp án 2 cho câu 44", 44, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4225), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 175, "Đáp án 3 cho câu 44", 44, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4226), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 176, "Đáp án 4 cho câu 44", 44, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4227), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 177, "Đáp án 1 cho câu 45", 45, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4228), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 178, "Đáp án 2 cho câu 45", 45, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4229), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 179, "Đáp án 3 cho câu 45", 45, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4230), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 180, "Đáp án 4 cho câu 45", 45, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4230), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 181, "Đáp án 1 cho câu 46", 46, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4231), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 182, "Đáp án 2 cho câu 46", 46, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4232), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 183, "Đáp án 3 cho câu 46", 46, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4233), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 184, "Đáp án 4 cho câu 46", 46, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4235), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 185, "Đáp án 1 cho câu 47", 47, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4236), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 186, "Đáp án 2 cho câu 47", 47, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4237), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 187, "Đáp án 3 cho câu 47", 47, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4238), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 188, "Đáp án 4 cho câu 47", 47, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4239), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 189, "Đáp án 1 cho câu 48", 48, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4240), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 190, "Đáp án 2 cho câu 48", 48, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4241), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 191, "Đáp án 3 cho câu 48", 48, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4242), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 192, "Đáp án 4 cho câu 48", 48, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4243), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 193, "Đáp án 1 cho câu 49", 49, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4244), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 194, "Đáp án 2 cho câu 49", 49, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4251), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 195, "Đáp án 3 cho câu 49", 49, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 196, "Đáp án 4 cho câu 49", 49, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4253), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 197, "Đáp án 1 cho câu 50", 50, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4254), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 198, "Đáp án 2 cho câu 50", 50, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4255), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 199, "Đáp án 3 cho câu 50", 50, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4256), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 200, "Đáp án 4 cho câu 50", 50, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4257), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 201, "Đáp án 1 cho câu 51", 51, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4258), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 202, "Đáp án 2 cho câu 51", 51, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4259), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 203, "Đáp án 3 cho câu 51", 51, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4260), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 204, "Đáp án 4 cho câu 51", 51, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4260), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 205, "Đáp án 1 cho câu 52", 52, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4261), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 206, "Đáp án 2 cho câu 52", 52, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4262), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 207, "Đáp án 3 cho câu 52", 52, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4263), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 208, "Đáp án 4 cho câu 52", 52, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4264), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 209, "Đáp án 1 cho câu 53", 53, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4265), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 210, "Đáp án 2 cho câu 53", 53, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4267), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 211, "Đáp án 3 cho câu 53", 53, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4268), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 212, "Đáp án 4 cho câu 53", 53, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4269), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 213, "Đáp án 1 cho câu 54", 54, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4270), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 214, "Đáp án 2 cho câu 54", 54, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4270), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 215, "Đáp án 3 cho câu 54", 54, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4272), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 216, "Đáp án 4 cho câu 54", 54, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4272), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 217, "Đáp án 1 cho câu 55", 55, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4273), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 218, "Đáp án 2 cho câu 55", 55, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4274), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 219, "Đáp án 3 cho câu 55", 55, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4275), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 220, "Đáp án 4 cho câu 55", 55, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4276), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 221, "Đáp án 1 cho câu 56", 56, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4277), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 222, "Đáp án 2 cho câu 56", 56, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4278), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 223, "Đáp án 3 cho câu 56", 56, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4279), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 224, "Đáp án 4 cho câu 56", 56, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4280), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 225, "Đáp án 1 cho câu 57", 57, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4281), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 226, "Đáp án 2 cho câu 57", 57, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4282), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 227, "Đáp án 3 cho câu 57", 57, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4282), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 228, "Đáp án 4 cho câu 57", 57, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4283), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 229, "Đáp án 1 cho câu 58", 58, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4284), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 230, "Đáp án 2 cho câu 58", 58, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4285), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 231, "Đáp án 3 cho câu 58", 58, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4286), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 232, "Đáp án 4 cho câu 58", 58, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4287), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 233, "Đáp án 1 cho câu 59", 59, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4288), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 234, "Đáp án 2 cho câu 59", 59, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4289), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 235, "Đáp án 3 cho câu 59", 59, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4290), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 236, "Đáp án 4 cho câu 59", 59, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4472), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 237, "Đáp án 1 cho câu 60", 60, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4474), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 238, "Đáp án 2 cho câu 60", 60, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4476), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 239, "Đáp án 3 cho câu 60", 60, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4477), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 240, "Đáp án 4 cho câu 60", 60, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4478), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 241, "Đáp án 1 cho câu 61", 61, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4478), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 242, "Đáp án 2 cho câu 61", 61, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4479), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 243, "Đáp án 3 cho câu 61", 61, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4480), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 244, "Đáp án 4 cho câu 61", 61, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4481), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 245, "Đáp án 1 cho câu 62", 62, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4482), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 246, "Đáp án 2 cho câu 62", 62, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4483), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 247, "Đáp án 3 cho câu 62", 62, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4484), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 248, "Đáp án 4 cho câu 62", 62, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4485), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 249, "Đáp án 1 cho câu 63", 63, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4486), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 250, "Đáp án 2 cho câu 63", 63, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4487), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 251, "Đáp án 3 cho câu 63", 63, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4488), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 252, "Đáp án 4 cho câu 63", 63, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4490), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 253, "Đáp án 1 cho câu 64", 64, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4491), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 254, "Đáp án 2 cho câu 64", 64, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4492), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 255, "Đáp án 3 cho câu 64", 64, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4493), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 256, "Đáp án 4 cho câu 64", 64, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4494), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 257, "Đáp án 1 cho câu 65", 65, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4495), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 258, "Đáp án 2 cho câu 65", 65, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4496), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 259, "Đáp án 3 cho câu 65", 65, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4497), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 260, "Đáp án 4 cho câu 65", 65, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4498), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 261, "Đáp án 1 cho câu 66", 66, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4500), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 262, "Đáp án 2 cho câu 66", 66, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4501), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 263, "Đáp án 3 cho câu 66", 66, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4501), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 264, "Đáp án 4 cho câu 66", 66, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4502), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 265, "Đáp án 1 cho câu 67", 67, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4503), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 266, "Đáp án 2 cho câu 67", 67, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4504), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 267, "Đáp án 3 cho câu 67", 67, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4505), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 268, "Đáp án 4 cho câu 67", 67, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4506), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 269, "Đáp án 1 cho câu 68", 68, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4507), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 270, "Đáp án 2 cho câu 68", 68, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4508), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 271, "Đáp án 3 cho câu 68", 68, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4509), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 272, "Đáp án 4 cho câu 68", 68, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4510), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 273, "Đáp án 1 cho câu 69", 69, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4511), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 274, "Đáp án 2 cho câu 69", 69, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4512), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 275, "Đáp án 3 cho câu 69", 69, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4513), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 276, "Đáp án 4 cho câu 69", 69, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4514), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 277, "Đáp án 1 cho câu 70", 70, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4515), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 278, "Đáp án 2 cho câu 70", 70, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4516), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 279, "Đáp án 3 cho câu 70", 70, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4517), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 280, "Đáp án 4 cho câu 70", 70, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4517), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 281, "Đáp án 1 cho câu 71", 71, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4518), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 282, "Đáp án 2 cho câu 71", 71, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4519), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 283, "Đáp án 3 cho câu 71", 71, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4520), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 284, "Đáp án 4 cho câu 71", 71, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4521), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 285, "Đáp án 1 cho câu 72", 72, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4522), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 286, "Đáp án 2 cho câu 72", 72, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4523), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 287, "Đáp án 3 cho câu 72", 72, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4532), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 288, "Đáp án 4 cho câu 72", 72, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4533), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 289, "Đáp án 1 cho câu 73", 73, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4534), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 290, "Đáp án 2 cho câu 73", 73, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4535), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 291, "Đáp án 3 cho câu 73", 73, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4536), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 292, "Đáp án 4 cho câu 73", 73, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4537), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 293, "Đáp án 1 cho câu 74", 74, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4537), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 294, "Đáp án 2 cho câu 74", 74, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4538), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 295, "Đáp án 3 cho câu 74", 74, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4539), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 296, "Đáp án 4 cho câu 74", 74, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4540), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 297, "Đáp án 1 cho câu 75", 75, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4541), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 298, "Đáp án 2 cho câu 75", 75, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4542), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 299, "Đáp án 3 cho câu 75", 75, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4543), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 300, "Đáp án 4 cho câu 75", 75, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4544), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 301, "Đáp án 1 cho câu 76", 76, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4545), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 302, "Đáp án 2 cho câu 76", 76, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4546), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 303, "Đáp án 3 cho câu 76", 76, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4547), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 304, "Đáp án 4 cho câu 76", 76, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4548), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 305, "Đáp án 1 cho câu 77", 77, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4549), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 306, "Đáp án 2 cho câu 77", 77, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4550), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 307, "Đáp án 3 cho câu 77", 77, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4550), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 308, "Đáp án 4 cho câu 77", 77, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4551), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 309, "Đáp án 1 cho câu 78", 78, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4552), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 310, "Đáp án 2 cho câu 78", 78, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4553), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 311, "Đáp án 3 cho câu 78", 78, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4554), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 312, "Đáp án 4 cho câu 78", 78, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4555), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 313, "Đáp án 1 cho câu 79", 79, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4557), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 314, "Đáp án 2 cho câu 79", 79, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4558), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 315, "Đáp án 3 cho câu 79", 79, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4559), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 316, "Đáp án 4 cho câu 79", 79, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4559), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 317, "Đáp án 1 cho câu 80", 80, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4560), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 318, "Đáp án 2 cho câu 80", 80, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4561), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 319, "Đáp án 3 cho câu 80", 80, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4562), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 320, "Đáp án 4 cho câu 80", 80, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4563), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 321, "Đáp án 1 cho câu 81", 81, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4564), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 322, "Đáp án 2 cho câu 81", 81, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4565), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 323, "Đáp án 3 cho câu 81", 81, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4566), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 324, "Đáp án 4 cho câu 81", 81, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4567), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 325, "Đáp án 1 cho câu 82", 82, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4568), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 326, "Đáp án 2 cho câu 82", 82, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4568), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 327, "Đáp án 3 cho câu 82", 82, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4569), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 328, "Đáp án 4 cho câu 82", 82, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4570), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 329, "Đáp án 1 cho câu 83", 83, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4571), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 330, "Đáp án 2 cho câu 83", 83, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4572), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 331, "Đáp án 3 cho câu 83", 83, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4573), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 332, "Đáp án 4 cho câu 83", 83, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4574), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 333, "Đáp án 1 cho câu 84", 84, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4576), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 334, "Đáp án 2 cho câu 84", 84, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4577), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 335, "Đáp án 3 cho câu 84", 84, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4578), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 336, "Đáp án 4 cho câu 84", 84, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4579), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 337, "Đáp án 1 cho câu 85", 85, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4580), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 338, "Đáp án 2 cho câu 85", 85, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4581), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 339, "Đáp án 3 cho câu 85", 85, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4582), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 340, "Đáp án 4 cho câu 85", 85, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4583), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 341, "Đáp án 1 cho câu 86", 86, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4584), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 342, "Đáp án 2 cho câu 86", 86, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4585), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 343, "Đáp án 3 cho câu 86", 86, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4586), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 344, "Đáp án 4 cho câu 86", 86, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4587), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 345, "Đáp án 1 cho câu 87", 87, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4587), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 346, "Đáp án 2 cho câu 87", 87, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4588), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 347, "Đáp án 3 cho câu 87", 87, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4589), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 348, "Đáp án 4 cho câu 87", 87, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4590), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 349, "Đáp án 1 cho câu 88", 88, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4591), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 350, "Đáp án 2 cho câu 88", 88, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4592), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 351, "Đáp án 3 cho câu 88", 88, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4593), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 352, "Đáp án 4 cho câu 88", 88, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4594), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 353, "Đáp án 1 cho câu 89", 89, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4595), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 354, "Đáp án 2 cho câu 89", 89, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4595), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 355, "Đáp án 3 cho câu 89", 89, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4597), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 356, "Đáp án 4 cho câu 89", 89, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4598), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 357, "Đáp án 1 cho câu 90", 90, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4599), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 358, "Đáp án 2 cho câu 90", 90, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4600), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 359, "Đáp án 3 cho câu 90", 90, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4601), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 360, "Đáp án 4 cho câu 90", 90, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4602), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 361, "Đáp án 1 cho câu 91", 91, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4603), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 362, "Đáp án 2 cho câu 91", 91, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4604), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 363, "Đáp án 3 cho câu 91", 91, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4604), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 364, "Đáp án 4 cho câu 91", 91, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4606), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 365, "Đáp án 1 cho câu 92", 92, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4607), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 366, "Đáp án 2 cho câu 92", 92, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4608), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 367, "Đáp án 3 cho câu 92", 92, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4609), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 368, "Đáp án 4 cho câu 92", 92, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4610), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 369, "Đáp án 1 cho câu 93", 93, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4611), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 370, "Đáp án 2 cho câu 93", 93, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4612), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 371, "Đáp án 3 cho câu 93", 93, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4613), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 372, "Đáp án 4 cho câu 93", 93, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4614), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 373, "Đáp án 1 cho câu 94", 94, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4615), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 374, "Đáp án 2 cho câu 94", 94, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4616), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 375, "Đáp án 3 cho câu 94", 94, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4616), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 376, "Đáp án 4 cho câu 94", 94, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4617), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 377, "Đáp án 1 cho câu 95", 95, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4618), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 378, "Đáp án 2 cho câu 95", 95, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4619), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 379, "Đáp án 3 cho câu 95", 95, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4620), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 380, "Đáp án 4 cho câu 95", 95, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4628), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 381, "Đáp án 1 cho câu 96", 96, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4629), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 382, "Đáp án 2 cho câu 96", 96, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4630), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 383, "Đáp án 3 cho câu 96", 96, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4631), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 384, "Đáp án 4 cho câu 96", 96, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4632), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 385, "Đáp án 1 cho câu 97", 97, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4632), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 386, "Đáp án 2 cho câu 97", 97, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4633), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 387, "Đáp án 3 cho câu 97", 97, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4634), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 388, "Đáp án 4 cho câu 97", 97, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4635), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 389, "Đáp án 1 cho câu 98", 98, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4636), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 390, "Đáp án 2 cho câu 98", 98, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4638), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 391, "Đáp án 3 cho câu 98", 98, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4639), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 392, "Đáp án 4 cho câu 98", 98, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4640), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 393, "Đáp án 1 cho câu 99", 99, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4641), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 394, "Đáp án 2 cho câu 99", 99, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 395, "Đáp án 3 cho câu 99", 99, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 396, "Đáp án 4 cho câu 99", 99, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4643), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 397, "Đáp án 1 cho câu 100", 100, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4644), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 398, "Đáp án 2 cho câu 100", 100, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4645), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 399, "Đáp án 3 cho câu 100", 100, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4646), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 400, "Đáp án 4 cho câu 100", 100, new DateTime(2025, 6, 5, 10, 16, 48, 929, DateTimeKind.Local).AddTicks(4647), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "QuestionExams",
                columns: new[] { "Id", "BankQuestionId", "Content", "CreatedAt", "DeletedAt", "ExamId", "IsPublic", "LevelId", "QuestionTypeId", "UpdateBy", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, "Câu 1: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, "Câu 2: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, "Câu 3: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, "Câu 4: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, "Câu 5: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, "Câu 6: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 7, "Câu 7: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 8, "Câu 8: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 9, "Câu 9: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 10, "Câu 10: Phép biện chứng - Nội dung trọng tâm số 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 11, "Câu 11: Phép biện chứng - Nội dung trọng tâm số 11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 12, "Câu 12: Phép biện chứng - Nội dung trọng tâm số 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 13, "Câu 13: Phép biện chứng - Nội dung trọng tâm số 13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 14, "Câu 14: Phép biện chứng - Nội dung trọng tâm số 14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 15, "Câu 15: Phép biện chứng - Nội dung trọng tâm số 15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 16, "Câu 16: Phép biện chứng - Nội dung trọng tâm số 16", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 17, "Câu 17: Phép biện chứng - Nội dung trọng tâm số 17", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 18, "Câu 18: Phép biện chứng - Nội dung trọng tâm số 18", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 19, "Câu 19: Vật chất và ý thức - Nội dung trọng tâm số 19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 20, "Câu 20: Vật chất và ý thức - Nội dung trọng tâm số 20", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 21, "Câu 21: Vật chất và ý thức - Nội dung trọng tâm số 21", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 22, "Câu 22: Vật chất và ý thức - Nội dung trọng tâm số 22", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 23, "Câu 23: Vật chất và ý thức - Nội dung trọng tâm số 23", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 24, "Câu 24: Vật chất và ý thức - Nội dung trọng tâm số 24", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 25, "Câu 25: Vật chất và ý thức - Nội dung trọng tâm số 25", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 26, "Câu 26: Vật chất và ý thức - Nội dung trọng tâm số 26", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 27, "Câu 27: Vật chất và ý thức - Nội dung trọng tâm số 27", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 28, "Câu 28: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 28", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 29, "Câu 29: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 29", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 30, "Câu 30: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 30", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 31, "Câu 31: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 31", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 32, "Câu 32: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 32", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 33, "Câu 33: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 33", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 34, "Câu 34: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 34", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 35, "Câu 35: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 35", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 36, "Câu 36: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 36", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 37, "Câu 37: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 37", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 38, "Câu 38: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 38", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 39, "Câu 39: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 39", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 40, "Câu 40: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 40", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 41, "Câu 41: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 41", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 42, "Câu 42: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 42", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 43, "Câu 43: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 43", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 44, "Câu 44: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 44", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 45, "Câu 45: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 45", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 46, "Câu 46: Nhận thức và thực tiễn - Nội dung trọng tâm số 46", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 47, "Câu 47: Nhận thức và thực tiễn - Nội dung trọng tâm số 47", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 48, "Câu 48: Nhận thức và thực tiễn - Nội dung trọng tâm số 48", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 49, "Câu 49: Nhận thức và thực tiễn - Nội dung trọng tâm số 49", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 50, "Câu 50: Nhận thức và thực tiễn - Nội dung trọng tâm số 50", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, 51, "Câu 51: Nhận thức và thực tiễn - Nội dung trọng tâm số 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, 52, "Câu 52: Nhận thức và thực tiễn - Nội dung trọng tâm số 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, 53, "Câu 53: Nhận thức và thực tiễn - Nội dung trọng tâm số 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, 54, "Câu 54: Nhận thức và thực tiễn - Nội dung trọng tâm số 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, 55, "Câu 55: Vai trò của con người - Nội dung trọng tâm số 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, 56, "Câu 56: Vai trò của con người - Nội dung trọng tâm số 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, 57, "Câu 57: Vai trò của con người - Nội dung trọng tâm số 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, 58, "Câu 58: Vai trò của con người - Nội dung trọng tâm số 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, 59, "Câu 59: Vai trò của con người - Nội dung trọng tâm số 9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, 60, "Câu 60: Vai trò của con người - Nội dung trọng tâm số 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, 61, "Câu 61: Vai trò của con người - Nội dung trọng tâm số 11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, 62, "Câu 62: Vai trò của con người - Nội dung trọng tâm số 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, 63, "Câu 63: Vai trò của con người - Nội dung trọng tâm số 13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, 64, "Câu 64: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, 65, "Câu 65: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, 66, "Câu 66: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 16", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, 67, "Câu 67: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 17", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, 68, "Câu 68: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 18", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, 69, "Câu 69: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, 70, "Câu 70: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 20", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, 71, "Câu 71: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 21", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, 72, "Câu 72: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 22", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, 73, "Câu 73: Hình thái kinh tế xã hội - Nội dung trọng tâm số 23", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, 74, "Câu 74: Hình thái kinh tế xã hội - Nội dung trọng tâm số 24", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, 75, "Câu 75: Hình thái kinh tế xã hội - Nội dung trọng tâm số 25", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, 76, "Câu 76: Hình thái kinh tế xã hội - Nội dung trọng tâm số 26", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, 77, "Câu 77: Hình thái kinh tế xã hội - Nội dung trọng tâm số 27", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, 78, "Câu 78: Hình thái kinh tế xã hội - Nội dung trọng tâm số 28", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, 79, "Câu 79: Hình thái kinh tế xã hội - Nội dung trọng tâm số 29", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, 80, "Câu 80: Hình thái kinh tế xã hội - Nội dung trọng tâm số 30", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, 81, "Câu 81: Hình thái kinh tế xã hội - Nội dung trọng tâm số 31", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, 82, "Câu 82: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 32", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, 83, "Câu 83: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 33", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, 84, "Câu 84: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 34", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, 85, "Câu 85: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 35", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, 86, "Câu 86: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 36", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, 87, "Câu 87: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 37", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, 88, "Câu 88: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 38", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, 89, "Câu 89: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 39", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, 90, "Câu 90: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 40", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, 91, "Câu 91: Nhà nước và cách mạng - Nội dung trọng tâm số 41", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, 92, "Câu 92: Nhà nước và cách mạng - Nội dung trọng tâm số 42", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, 93, "Câu 93: Nhà nước và cách mạng - Nội dung trọng tâm số 43", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, 94, "Câu 94: Nhà nước và cách mạng - Nội dung trọng tâm số 44", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 3, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, 95, "Câu 95: Nhà nước và cách mạng - Nội dung trọng tâm số 45", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, 96, "Câu 96: Nhà nước và cách mạng - Nội dung trọng tâm số 46", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, 97, "Câu 97: Nhà nước và cách mạng - Nội dung trọng tâm số 47", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, 98, "Câu 98: Nhà nước và cách mạng - Nội dung trọng tâm số 48", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, 99, "Câu 99: Nhà nước và cách mạng - Nội dung trọng tâm số 49", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, 100, "Câu 100: Chủ nghĩa xã hội khoa học - Nội dung trọng tâm số 50", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "QuestionExams",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "BankQuestions",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Examss",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Examss",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
