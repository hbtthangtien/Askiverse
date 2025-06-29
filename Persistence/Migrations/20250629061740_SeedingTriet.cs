using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedingTriet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BankQuestions",
                columns: new[] { "id", "Content", "CreatedAt", "DeletedAt", "IsPublic", "LevelId", "PremiumUserId", "QuestionTypeId", "UpdateBy", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Câu 1: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 2, "Câu 2: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 3, "Câu 3: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 4, "Câu 4: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 5, "Câu 5: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 6, "Câu 6: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 7, "Câu 7: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 8, "Câu 8: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 9, "Câu 9: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 10, "Câu 10: Phép biện chứng - Nội dung trọng tâm số 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 11, "Câu 11: Phép biện chứng - Nội dung trọng tâm số 11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 12, "Câu 12: Phép biện chứng - Nội dung trọng tâm số 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 13, "Câu 13: Phép biện chứng - Nội dung trọng tâm số 13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 14, "Câu 14: Phép biện chứng - Nội dung trọng tâm số 14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 15, "Câu 15: Phép biện chứng - Nội dung trọng tâm số 15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 16, "Câu 16: Phép biện chứng - Nội dung trọng tâm số 16", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 17, "Câu 17: Phép biện chứng - Nội dung trọng tâm số 17", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 18, "Câu 18: Phép biện chứng - Nội dung trọng tâm số 18", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 19, "Câu 19: Vật chất và ý thức - Nội dung trọng tâm số 19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 20, "Câu 20: Vật chất và ý thức - Nội dung trọng tâm số 20", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 21, "Câu 21: Vật chất và ý thức - Nội dung trọng tâm số 21", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 22, "Câu 22: Vật chất và ý thức - Nội dung trọng tâm số 22", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 23, "Câu 23: Vật chất và ý thức - Nội dung trọng tâm số 23", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 24, "Câu 24: Vật chất và ý thức - Nội dung trọng tâm số 24", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 25, "Câu 25: Vật chất và ý thức - Nội dung trọng tâm số 25", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 26, "Câu 26: Vật chất và ý thức - Nội dung trọng tâm số 26", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 27, "Câu 27: Vật chất và ý thức - Nội dung trọng tâm số 27", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 28, "Câu 28: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 28", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 29, "Câu 29: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 29", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 30, "Câu 30: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 30", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 31, "Câu 31: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 31", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 32, "Câu 32: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 32", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 33, "Câu 33: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 33", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 34, "Câu 34: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 34", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 35, "Câu 35: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 35", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 36, "Câu 36: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 36", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 37, "Câu 37: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 37", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 38, "Câu 38: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 38", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 39, "Câu 39: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 39", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 40, "Câu 40: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 40", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 41, "Câu 41: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 41", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 42, "Câu 42: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 42", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 43, "Câu 43: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 43", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 44, "Câu 44: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 44", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 45, "Câu 45: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 45", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 46, "Câu 46: Nhận thức và thực tiễn - Nội dung trọng tâm số 46", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 47, "Câu 47: Nhận thức và thực tiễn - Nội dung trọng tâm số 47", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 48, "Câu 48: Nhận thức và thực tiễn - Nội dung trọng tâm số 48", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 49, "Câu 49: Nhận thức và thực tiễn - Nội dung trọng tâm số 49", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 50, "Câu 50: Nhận thức và thực tiễn - Nội dung trọng tâm số 50", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 51, "Câu 51: Nhận thức và thực tiễn - Nội dung trọng tâm số 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 52, "Câu 52: Nhận thức và thực tiễn - Nội dung trọng tâm số 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 53, "Câu 53: Nhận thức và thực tiễn - Nội dung trọng tâm số 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 54, "Câu 54: Nhận thức và thực tiễn - Nội dung trọng tâm số 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 55, "Câu 55: Vai trò của con người - Nội dung trọng tâm số 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 56, "Câu 56: Vai trò của con người - Nội dung trọng tâm số 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 57, "Câu 57: Vai trò của con người - Nội dung trọng tâm số 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 58, "Câu 58: Vai trò của con người - Nội dung trọng tâm số 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 59, "Câu 59: Vai trò của con người - Nội dung trọng tâm số 9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 60, "Câu 60: Vai trò của con người - Nội dung trọng tâm số 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 61, "Câu 61: Vai trò của con người - Nội dung trọng tâm số 11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 62, "Câu 62: Vai trò của con người - Nội dung trọng tâm số 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 63, "Câu 63: Vai trò của con người - Nội dung trọng tâm số 13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 64, "Câu 64: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 65, "Câu 65: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 66, "Câu 66: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 16", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 67, "Câu 67: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 17", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 68, "Câu 68: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 18", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 69, "Câu 69: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 70, "Câu 70: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 20", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 71, "Câu 71: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 21", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 72, "Câu 72: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 22", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 73, "Câu 73: Hình thái kinh tế xã hội - Nội dung trọng tâm số 23", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 74, "Câu 74: Hình thái kinh tế xã hội - Nội dung trọng tâm số 24", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 75, "Câu 75: Hình thái kinh tế xã hội - Nội dung trọng tâm số 25", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 76, "Câu 76: Hình thái kinh tế xã hội - Nội dung trọng tâm số 26", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 77, "Câu 77: Hình thái kinh tế xã hội - Nội dung trọng tâm số 27", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 78, "Câu 78: Hình thái kinh tế xã hội - Nội dung trọng tâm số 28", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 79, "Câu 79: Hình thái kinh tế xã hội - Nội dung trọng tâm số 29", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 80, "Câu 80: Hình thái kinh tế xã hội - Nội dung trọng tâm số 30", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 81, "Câu 81: Hình thái kinh tế xã hội - Nội dung trọng tâm số 31", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 82, "Câu 82: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 32", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 83, "Câu 83: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 33", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 84, "Câu 84: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 34", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 85, "Câu 85: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 35", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 86, "Câu 86: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 36", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 87, "Câu 87: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 37", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 88, "Câu 88: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 38", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 89, "Câu 89: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 39", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 90, "Câu 90: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 40", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 91, "Câu 91: Nhà nước và cách mạng - Nội dung trọng tâm số 41", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 92, "Câu 92: Nhà nước và cách mạng - Nội dung trọng tâm số 42", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 93, "Câu 93: Nhà nước và cách mạng - Nội dung trọng tâm số 43", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 94, "Câu 94: Nhà nước và cách mạng - Nội dung trọng tâm số 44", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, null, 1, null, null },
                    { 95, "Câu 95: Nhà nước và cách mạng - Nội dung trọng tâm số 45", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 96, "Câu 96: Nhà nước và cách mạng - Nội dung trọng tâm số 46", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 97, "Câu 97: Nhà nước và cách mạng - Nội dung trọng tâm số 47", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 98, "Câu 98: Nhà nước và cách mạng - Nội dung trọng tâm số 48", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, null, 1, null, null },
                    { 99, "Câu 99: Nhà nước và cách mạng - Nội dung trọng tâm số 49", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null },
                    { 100, "Câu 100: Chủ nghĩa xã hội khoa học - Nội dung trọng tâm số 50", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, null, 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "Examss",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsPublic", "PremiumUserId", "SourceText", "SubjectId", "Title", "TotalQuestion", "TotalTime", "UpdateBy", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1558), null, "Các câu hỏi thuộc nội dung: Vật chất & Ý thức, Lượng – Chất, Phép biện chứng", true, null, "Tổng hợp 12 nội dung môn Triết học", 1, "Đề thi Triết học - Phần 1", 50, new TimeSpan(0, 0, 0, 10, 0), null, null },
                    { 2, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1573), null, "Các câu hỏi thuộc nội dung: Con người, Nhận thức, Thực tiễn, Chủ nghĩa xã hội", true, null, "Tổng hợp 12 nội dung môn Triết học", 1, "Đề thi Triết học - Phần 2", 50, new TimeSpan(0, 0, 0, 10, 0), null, null }
                });

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 251, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 251, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 251, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 251, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 251, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 251, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "id", "AnswerText", "BankQuestionId", "CreatedAt", "DeletedAt", "IsCorrected", "MatchingPairKey", "UpdateBy", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Đáp án 1 cho câu 1", 1, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(156), null, true, null, null, null },
                    { 2, "Đáp án 2 cho câu 1", 1, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(159), null, false, null, null, null },
                    { 3, "Đáp án 3 cho câu 1", 1, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(160), null, false, null, null, null },
                    { 4, "Đáp án 4 cho câu 1", 1, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(161), null, false, null, null, null },
                    { 5, "Đáp án 1 cho câu 2", 2, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(162), null, true, null, null, null },
                    { 6, "Đáp án 2 cho câu 2", 2, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(164), null, false, null, null, null },
                    { 7, "Đáp án 3 cho câu 2", 2, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(165), null, false, null, null, null },
                    { 8, "Đáp án 4 cho câu 2", 2, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(166), null, false, null, null, null },
                    { 9, "Đáp án 1 cho câu 3", 3, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(167), null, true, null, null, null },
                    { 10, "Đáp án 2 cho câu 3", 3, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(168), null, false, null, null, null },
                    { 11, "Đáp án 3 cho câu 3", 3, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(170), null, false, null, null, null },
                    { 12, "Đáp án 4 cho câu 3", 3, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(171), null, false, null, null, null },
                    { 13, "Đáp án 1 cho câu 4", 4, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(172), null, true, null, null, null },
                    { 14, "Đáp án 2 cho câu 4", 4, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(173), null, false, null, null, null },
                    { 15, "Đáp án 3 cho câu 4", 4, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(174), null, false, null, null, null },
                    { 16, "Đáp án 4 cho câu 4", 4, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(175), null, false, null, null, null },
                    { 17, "Đáp án 1 cho câu 5", 5, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(177), null, true, null, null, null },
                    { 18, "Đáp án 2 cho câu 5", 5, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(178), null, false, null, null, null },
                    { 19, "Đáp án 3 cho câu 5", 5, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(179), null, false, null, null, null },
                    { 20, "Đáp án 4 cho câu 5", 5, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(180), null, false, null, null, null },
                    { 21, "Đáp án 1 cho câu 6", 6, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(181), null, true, null, null, null },
                    { 22, "Đáp án 2 cho câu 6", 6, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(182), null, false, null, null, null },
                    { 23, "Đáp án 3 cho câu 6", 6, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(184), null, false, null, null, null },
                    { 24, "Đáp án 4 cho câu 6", 6, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(185), null, false, null, null, null },
                    { 25, "Đáp án 1 cho câu 7", 7, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(186), null, true, null, null, null },
                    { 26, "Đáp án 2 cho câu 7", 7, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(187), null, false, null, null, null },
                    { 27, "Đáp án 3 cho câu 7", 7, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(188), null, false, null, null, null },
                    { 28, "Đáp án 4 cho câu 7", 7, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(189), null, false, null, null, null },
                    { 29, "Đáp án 1 cho câu 8", 8, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(190), null, true, null, null, null },
                    { 30, "Đáp án 2 cho câu 8", 8, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(192), null, false, null, null, null },
                    { 31, "Đáp án 3 cho câu 8", 8, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(202), null, false, null, null, null },
                    { 32, "Đáp án 4 cho câu 8", 8, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(203), null, false, null, null, null },
                    { 33, "Đáp án 1 cho câu 9", 9, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(204), null, true, null, null, null },
                    { 34, "Đáp án 2 cho câu 9", 9, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(206), null, false, null, null, null },
                    { 35, "Đáp án 3 cho câu 9", 9, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(207), null, false, null, null, null },
                    { 36, "Đáp án 4 cho câu 9", 9, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(208), null, false, null, null, null },
                    { 37, "Đáp án 1 cho câu 10", 10, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(209), null, true, null, null, null },
                    { 38, "Đáp án 2 cho câu 10", 10, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(210), null, false, null, null, null },
                    { 39, "Đáp án 3 cho câu 10", 10, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(400), null, false, null, null, null },
                    { 40, "Đáp án 4 cho câu 10", 10, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(403), null, false, null, null, null },
                    { 41, "Đáp án 1 cho câu 11", 11, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(404), null, true, null, null, null },
                    { 42, "Đáp án 2 cho câu 11", 11, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(405), null, false, null, null, null },
                    { 43, "Đáp án 3 cho câu 11", 11, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(406), null, false, null, null, null },
                    { 44, "Đáp án 4 cho câu 11", 11, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(408), null, false, null, null, null },
                    { 45, "Đáp án 1 cho câu 12", 12, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(409), null, true, null, null, null },
                    { 46, "Đáp án 2 cho câu 12", 12, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(410), null, false, null, null, null },
                    { 47, "Đáp án 3 cho câu 12", 12, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(411), null, false, null, null, null },
                    { 48, "Đáp án 4 cho câu 12", 12, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(412), null, false, null, null, null },
                    { 49, "Đáp án 1 cho câu 13", 13, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(414), null, true, null, null, null },
                    { 50, "Đáp án 2 cho câu 13", 13, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(415), null, false, null, null, null },
                    { 51, "Đáp án 3 cho câu 13", 13, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(416), null, false, null, null, null },
                    { 52, "Đáp án 4 cho câu 13", 13, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(417), null, false, null, null, null },
                    { 53, "Đáp án 1 cho câu 14", 14, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(419), null, true, null, null, null },
                    { 54, "Đáp án 2 cho câu 14", 14, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(420), null, false, null, null, null },
                    { 55, "Đáp án 3 cho câu 14", 14, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(421), null, false, null, null, null },
                    { 56, "Đáp án 4 cho câu 14", 14, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(423), null, false, null, null, null },
                    { 57, "Đáp án 1 cho câu 15", 15, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(424), null, true, null, null, null },
                    { 58, "Đáp án 2 cho câu 15", 15, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(425), null, false, null, null, null },
                    { 59, "Đáp án 3 cho câu 15", 15, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(426), null, false, null, null, null },
                    { 60, "Đáp án 4 cho câu 15", 15, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(427), null, false, null, null, null },
                    { 61, "Đáp án 1 cho câu 16", 16, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(429), null, true, null, null, null },
                    { 62, "Đáp án 2 cho câu 16", 16, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(430), null, false, null, null, null },
                    { 63, "Đáp án 3 cho câu 16", 16, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(431), null, false, null, null, null },
                    { 64, "Đáp án 4 cho câu 16", 16, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(432), null, false, null, null, null },
                    { 65, "Đáp án 1 cho câu 17", 17, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(433), null, true, null, null, null },
                    { 66, "Đáp án 2 cho câu 17", 17, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(435), null, false, null, null, null },
                    { 67, "Đáp án 3 cho câu 17", 17, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(436), null, false, null, null, null },
                    { 68, "Đáp án 4 cho câu 17", 17, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(437), null, false, null, null, null },
                    { 69, "Đáp án 1 cho câu 18", 18, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(438), null, true, null, null, null },
                    { 70, "Đáp án 2 cho câu 18", 18, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(439), null, false, null, null, null },
                    { 71, "Đáp án 3 cho câu 18", 18, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(440), null, false, null, null, null },
                    { 72, "Đáp án 4 cho câu 18", 18, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(441), null, false, null, null, null },
                    { 73, "Đáp án 1 cho câu 19", 19, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(443), null, true, null, null, null },
                    { 74, "Đáp án 2 cho câu 19", 19, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(444), null, false, null, null, null },
                    { 75, "Đáp án 3 cho câu 19", 19, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(445), null, false, null, null, null },
                    { 76, "Đáp án 4 cho câu 19", 19, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(446), null, false, null, null, null },
                    { 77, "Đáp án 1 cho câu 20", 20, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(447), null, true, null, null, null },
                    { 78, "Đáp án 2 cho câu 20", 20, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(448), null, false, null, null, null },
                    { 79, "Đáp án 3 cho câu 20", 20, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(450), null, false, null, null, null },
                    { 80, "Đáp án 4 cho câu 20", 20, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(451), null, false, null, null, null },
                    { 81, "Đáp án 1 cho câu 21", 21, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(452), null, true, null, null, null },
                    { 82, "Đáp án 2 cho câu 21", 21, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(454), null, false, null, null, null },
                    { 83, "Đáp án 3 cho câu 21", 21, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(455), null, false, null, null, null },
                    { 84, "Đáp án 4 cho câu 21", 21, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(456), null, false, null, null, null },
                    { 85, "Đáp án 1 cho câu 22", 22, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(457), null, true, null, null, null },
                    { 86, "Đáp án 2 cho câu 22", 22, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(458), null, false, null, null, null },
                    { 87, "Đáp án 3 cho câu 22", 22, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(460), null, false, null, null, null },
                    { 88, "Đáp án 4 cho câu 22", 22, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(468), null, false, null, null, null },
                    { 89, "Đáp án 1 cho câu 23", 23, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(469), null, true, null, null, null },
                    { 90, "Đáp án 2 cho câu 23", 23, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(471), null, false, null, null, null },
                    { 91, "Đáp án 3 cho câu 23", 23, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(472), null, false, null, null, null },
                    { 92, "Đáp án 4 cho câu 23", 23, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(473), null, false, null, null, null },
                    { 93, "Đáp án 1 cho câu 24", 24, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(474), null, true, null, null, null },
                    { 94, "Đáp án 2 cho câu 24", 24, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(475), null, false, null, null, null },
                    { 95, "Đáp án 3 cho câu 24", 24, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(476), null, false, null, null, null },
                    { 96, "Đáp án 4 cho câu 24", 24, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(477), null, false, null, null, null },
                    { 97, "Đáp án 1 cho câu 25", 25, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(478), null, true, null, null, null },
                    { 98, "Đáp án 2 cho câu 25", 25, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(480), null, false, null, null, null },
                    { 99, "Đáp án 3 cho câu 25", 25, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(481), null, false, null, null, null },
                    { 100, "Đáp án 4 cho câu 25", 25, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(482), null, false, null, null, null },
                    { 101, "Đáp án 1 cho câu 26", 26, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(483), null, true, null, null, null },
                    { 102, "Đáp án 2 cho câu 26", 26, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(484), null, false, null, null, null },
                    { 103, "Đáp án 3 cho câu 26", 26, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(485), null, false, null, null, null },
                    { 104, "Đáp án 4 cho câu 26", 26, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(486), null, false, null, null, null },
                    { 105, "Đáp án 1 cho câu 27", 27, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(488), null, true, null, null, null },
                    { 106, "Đáp án 2 cho câu 27", 27, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(489), null, false, null, null, null },
                    { 107, "Đáp án 3 cho câu 27", 27, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(491), null, false, null, null, null },
                    { 108, "Đáp án 4 cho câu 27", 27, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(492), null, false, null, null, null },
                    { 109, "Đáp án 1 cho câu 28", 28, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(493), null, true, null, null, null },
                    { 110, "Đáp án 2 cho câu 28", 28, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(494), null, false, null, null, null },
                    { 111, "Đáp án 3 cho câu 28", 28, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(495), null, false, null, null, null },
                    { 112, "Đáp án 4 cho câu 28", 28, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(496), null, false, null, null, null },
                    { 113, "Đáp án 1 cho câu 29", 29, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(497), null, true, null, null, null },
                    { 114, "Đáp án 2 cho câu 29", 29, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(499), null, false, null, null, null },
                    { 115, "Đáp án 3 cho câu 29", 29, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(500), null, false, null, null, null },
                    { 116, "Đáp án 4 cho câu 29", 29, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(501), null, false, null, null, null },
                    { 117, "Đáp án 1 cho câu 30", 30, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(502), null, true, null, null, null },
                    { 118, "Đáp án 2 cho câu 30", 30, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(503), null, false, null, null, null },
                    { 119, "Đáp án 3 cho câu 30", 30, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(504), null, false, null, null, null },
                    { 120, "Đáp án 4 cho câu 30", 30, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(505), null, false, null, null, null },
                    { 121, "Đáp án 1 cho câu 31", 31, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(506), null, true, null, null, null },
                    { 122, "Đáp án 2 cho câu 31", 31, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(508), null, false, null, null, null },
                    { 123, "Đáp án 3 cho câu 31", 31, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(509), null, false, null, null, null },
                    { 124, "Đáp án 4 cho câu 31", 31, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(510), null, false, null, null, null },
                    { 125, "Đáp án 1 cho câu 32", 32, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(511), null, true, null, null, null },
                    { 126, "Đáp án 2 cho câu 32", 32, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(512), null, false, null, null, null },
                    { 127, "Đáp án 3 cho câu 32", 32, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(513), null, false, null, null, null },
                    { 128, "Đáp án 4 cho câu 32", 32, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(514), null, false, null, null, null },
                    { 129, "Đáp án 1 cho câu 33", 33, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(515), null, true, null, null, null },
                    { 130, "Đáp án 2 cho câu 33", 33, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(517), null, false, null, null, null },
                    { 131, "Đáp án 3 cho câu 33", 33, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(518), null, false, null, null, null },
                    { 132, "Đáp án 4 cho câu 33", 33, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(519), null, false, null, null, null },
                    { 133, "Đáp án 1 cho câu 34", 34, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(521), null, true, null, null, null },
                    { 134, "Đáp án 2 cho câu 34", 34, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(522), null, false, null, null, null },
                    { 135, "Đáp án 3 cho câu 34", 34, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(523), null, false, null, null, null },
                    { 136, "Đáp án 4 cho câu 34", 34, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(524), null, false, null, null, null },
                    { 137, "Đáp án 1 cho câu 35", 35, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(526), null, true, null, null, null },
                    { 138, "Đáp án 2 cho câu 35", 35, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(527), null, false, null, null, null },
                    { 139, "Đáp án 3 cho câu 35", 35, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(528), null, false, null, null, null },
                    { 140, "Đáp án 4 cho câu 35", 35, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(529), null, false, null, null, null },
                    { 141, "Đáp án 1 cho câu 36", 36, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(530), null, true, null, null, null },
                    { 142, "Đáp án 2 cho câu 36", 36, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(532), null, false, null, null, null },
                    { 143, "Đáp án 3 cho câu 36", 36, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(533), null, false, null, null, null },
                    { 144, "Đáp án 4 cho câu 36", 36, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(534), null, false, null, null, null },
                    { 145, "Đáp án 1 cho câu 37", 37, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(547), null, true, null, null, null },
                    { 146, "Đáp án 2 cho câu 37", 37, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(548), null, false, null, null, null },
                    { 147, "Đáp án 3 cho câu 37", 37, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(549), null, false, null, null, null },
                    { 148, "Đáp án 4 cho câu 37", 37, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(550), null, false, null, null, null },
                    { 149, "Đáp án 1 cho câu 38", 38, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(552), null, true, null, null, null },
                    { 150, "Đáp án 2 cho câu 38", 38, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(713), null, false, null, null, null },
                    { 151, "Đáp án 3 cho câu 38", 38, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(714), null, false, null, null, null },
                    { 152, "Đáp án 4 cho câu 38", 38, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(718), null, false, null, null, null },
                    { 153, "Đáp án 1 cho câu 39", 39, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(719), null, true, null, null, null },
                    { 154, "Đáp án 2 cho câu 39", 39, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(720), null, false, null, null, null },
                    { 155, "Đáp án 3 cho câu 39", 39, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(721), null, false, null, null, null },
                    { 156, "Đáp án 4 cho câu 39", 39, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(722), null, false, null, null, null },
                    { 157, "Đáp án 1 cho câu 40", 40, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(723), null, true, null, null, null },
                    { 158, "Đáp án 2 cho câu 40", 40, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(725), null, false, null, null, null },
                    { 159, "Đáp án 3 cho câu 40", 40, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(728), null, false, null, null, null },
                    { 160, "Đáp án 4 cho câu 40", 40, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(729), null, false, null, null, null },
                    { 161, "Đáp án 1 cho câu 41", 41, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(730), null, true, null, null, null },
                    { 162, "Đáp án 2 cho câu 41", 41, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(732), null, false, null, null, null },
                    { 163, "Đáp án 3 cho câu 41", 41, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(733), null, false, null, null, null },
                    { 164, "Đáp án 4 cho câu 41", 41, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(734), null, false, null, null, null },
                    { 165, "Đáp án 1 cho câu 42", 42, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(735), null, true, null, null, null },
                    { 166, "Đáp án 2 cho câu 42", 42, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(736), null, false, null, null, null },
                    { 167, "Đáp án 3 cho câu 42", 42, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(737), null, false, null, null, null },
                    { 168, "Đáp án 4 cho câu 42", 42, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(738), null, false, null, null, null },
                    { 169, "Đáp án 1 cho câu 43", 43, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(739), null, true, null, null, null },
                    { 170, "Đáp án 2 cho câu 43", 43, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(741), null, false, null, null, null },
                    { 171, "Đáp án 3 cho câu 43", 43, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(742), null, false, null, null, null },
                    { 172, "Đáp án 4 cho câu 43", 43, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(743), null, false, null, null, null },
                    { 173, "Đáp án 1 cho câu 44", 44, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(744), null, true, null, null, null },
                    { 174, "Đáp án 2 cho câu 44", 44, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(745), null, false, null, null, null },
                    { 175, "Đáp án 3 cho câu 44", 44, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(746), null, false, null, null, null },
                    { 176, "Đáp án 4 cho câu 44", 44, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(748), null, false, null, null, null },
                    { 177, "Đáp án 1 cho câu 45", 45, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(749), null, true, null, null, null },
                    { 178, "Đáp án 2 cho câu 45", 45, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(750), null, false, null, null, null },
                    { 179, "Đáp án 3 cho câu 45", 45, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(751), null, false, null, null, null },
                    { 180, "Đáp án 4 cho câu 45", 45, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(752), null, false, null, null, null },
                    { 181, "Đáp án 1 cho câu 46", 46, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(753), null, true, null, null, null },
                    { 182, "Đáp án 2 cho câu 46", 46, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(755), null, false, null, null, null },
                    { 183, "Đáp án 3 cho câu 46", 46, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(756), null, false, null, null, null },
                    { 184, "Đáp án 4 cho câu 46", 46, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(758), null, false, null, null, null },
                    { 185, "Đáp án 1 cho câu 47", 47, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(759), null, true, null, null, null },
                    { 186, "Đáp án 2 cho câu 47", 47, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(760), null, false, null, null, null },
                    { 187, "Đáp án 3 cho câu 47", 47, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(761), null, false, null, null, null },
                    { 188, "Đáp án 4 cho câu 47", 47, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(762), null, false, null, null, null },
                    { 189, "Đáp án 1 cho câu 48", 48, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(763), null, true, null, null, null },
                    { 190, "Đáp án 2 cho câu 48", 48, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(764), null, false, null, null, null },
                    { 191, "Đáp án 3 cho câu 48", 48, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(766), null, false, null, null, null },
                    { 192, "Đáp án 4 cho câu 48", 48, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(767), null, false, null, null, null },
                    { 193, "Đáp án 1 cho câu 49", 49, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(768), null, true, null, null, null },
                    { 194, "Đáp án 2 cho câu 49", 49, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(769), null, false, null, null, null },
                    { 195, "Đáp án 3 cho câu 49", 49, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(770), null, false, null, null, null },
                    { 196, "Đáp án 4 cho câu 49", 49, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(771), null, false, null, null, null },
                    { 197, "Đáp án 1 cho câu 50", 50, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(773), null, true, null, null, null },
                    { 198, "Đáp án 2 cho câu 50", 50, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(774), null, false, null, null, null },
                    { 199, "Đáp án 3 cho câu 50", 50, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(775), null, false, null, null, null },
                    { 200, "Đáp án 4 cho câu 50", 50, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(776), null, false, null, null, null },
                    { 201, "Đáp án 1 cho câu 51", 51, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(777), null, true, null, null, null },
                    { 202, "Đáp án 2 cho câu 51", 51, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(786), null, false, null, null, null },
                    { 203, "Đáp án 3 cho câu 51", 51, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(788), null, false, null, null, null },
                    { 204, "Đáp án 4 cho câu 51", 51, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(789), null, false, null, null, null },
                    { 205, "Đáp án 1 cho câu 52", 52, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(790), null, true, null, null, null },
                    { 206, "Đáp án 2 cho câu 52", 52, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(791), null, false, null, null, null },
                    { 207, "Đáp án 3 cho câu 52", 52, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(792), null, false, null, null, null },
                    { 208, "Đáp án 4 cho câu 52", 52, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(793), null, false, null, null, null },
                    { 209, "Đáp án 1 cho câu 53", 53, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(794), null, true, null, null, null },
                    { 210, "Đáp án 2 cho câu 53", 53, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(797), null, false, null, null, null },
                    { 211, "Đáp án 3 cho câu 53", 53, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(798), null, false, null, null, null },
                    { 212, "Đáp án 4 cho câu 53", 53, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(799), null, false, null, null, null },
                    { 213, "Đáp án 1 cho câu 54", 54, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(800), null, true, null, null, null },
                    { 214, "Đáp án 2 cho câu 54", 54, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(801), null, false, null, null, null },
                    { 215, "Đáp án 3 cho câu 54", 54, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(802), null, false, null, null, null },
                    { 216, "Đáp án 4 cho câu 54", 54, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(803), null, false, null, null, null },
                    { 217, "Đáp án 1 cho câu 55", 55, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(805), null, true, null, null, null },
                    { 218, "Đáp án 2 cho câu 55", 55, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(806), null, false, null, null, null },
                    { 219, "Đáp án 3 cho câu 55", 55, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(807), null, false, null, null, null },
                    { 220, "Đáp án 4 cho câu 55", 55, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(808), null, false, null, null, null },
                    { 221, "Đáp án 1 cho câu 56", 56, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(809), null, true, null, null, null },
                    { 222, "Đáp án 2 cho câu 56", 56, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(810), null, false, null, null, null },
                    { 223, "Đáp án 3 cho câu 56", 56, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(811), null, false, null, null, null },
                    { 224, "Đáp án 4 cho câu 56", 56, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(813), null, false, null, null, null },
                    { 225, "Đáp án 1 cho câu 57", 57, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(814), null, true, null, null, null },
                    { 226, "Đáp án 2 cho câu 57", 57, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(815), null, false, null, null, null },
                    { 227, "Đáp án 3 cho câu 57", 57, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(816), null, false, null, null, null },
                    { 228, "Đáp án 4 cho câu 57", 57, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(817), null, false, null, null, null },
                    { 229, "Đáp án 1 cho câu 58", 58, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(818), null, true, null, null, null },
                    { 230, "Đáp án 2 cho câu 58", 58, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(819), null, false, null, null, null },
                    { 231, "Đáp án 3 cho câu 58", 58, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(820), null, false, null, null, null },
                    { 232, "Đáp án 4 cho câu 58", 58, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(822), null, false, null, null, null },
                    { 233, "Đáp án 1 cho câu 59", 59, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(823), null, true, null, null, null },
                    { 234, "Đáp án 2 cho câu 59", 59, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(824), null, false, null, null, null },
                    { 235, "Đáp án 3 cho câu 59", 59, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(825), null, false, null, null, null },
                    { 236, "Đáp án 4 cho câu 59", 59, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(827), null, false, null, null, null },
                    { 237, "Đáp án 1 cho câu 60", 60, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(828), null, true, null, null, null },
                    { 238, "Đáp án 2 cho câu 60", 60, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(829), null, false, null, null, null },
                    { 239, "Đáp án 3 cho câu 60", 60, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(831), null, false, null, null, null },
                    { 240, "Đáp án 4 cho câu 60", 60, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(832), null, false, null, null, null },
                    { 241, "Đáp án 1 cho câu 61", 61, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(833), null, true, null, null, null },
                    { 242, "Đáp án 2 cho câu 61", 61, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(834), null, false, null, null, null },
                    { 243, "Đáp án 3 cho câu 61", 61, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(835), null, false, null, null, null },
                    { 244, "Đáp án 4 cho câu 61", 61, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(836), null, false, null, null, null },
                    { 245, "Đáp án 1 cho câu 62", 62, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(837), null, true, null, null, null },
                    { 246, "Đáp án 2 cho câu 62", 62, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(839), null, false, null, null, null },
                    { 247, "Đáp án 3 cho câu 62", 62, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(840), null, false, null, null, null },
                    { 248, "Đáp án 4 cho câu 62", 62, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(841), null, false, null, null, null },
                    { 249, "Đáp án 1 cho câu 63", 63, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(842), null, true, null, null, null },
                    { 250, "Đáp án 2 cho câu 63", 63, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(843), null, false, null, null, null },
                    { 251, "Đáp án 3 cho câu 63", 63, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(844), null, false, null, null, null },
                    { 252, "Đáp án 4 cho câu 63", 63, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(845), null, false, null, null, null },
                    { 253, "Đáp án 1 cho câu 64", 64, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(846), null, true, null, null, null },
                    { 254, "Đáp án 2 cho câu 64", 64, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(848), null, false, null, null, null },
                    { 255, "Đáp án 3 cho câu 64", 64, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(849), null, false, null, null, null },
                    { 256, "Đáp án 4 cho câu 64", 64, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(850), null, false, null, null, null },
                    { 257, "Đáp án 1 cho câu 65", 65, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(852), null, true, null, null, null },
                    { 258, "Đáp án 2 cho câu 65", 65, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(853), null, false, null, null, null },
                    { 259, "Đáp án 3 cho câu 65", 65, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(865), null, false, null, null, null },
                    { 260, "Đáp án 4 cho câu 65", 65, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(866), null, false, null, null, null },
                    { 261, "Đáp án 1 cho câu 66", 66, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(867), null, true, null, null, null },
                    { 262, "Đáp án 2 cho câu 66", 66, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(868), null, false, null, null, null },
                    { 263, "Đáp án 3 cho câu 66", 66, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(869), null, false, null, null, null },
                    { 264, "Đáp án 4 cho câu 66", 66, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(870), null, false, null, null, null },
                    { 265, "Đáp án 1 cho câu 67", 67, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(871), null, true, null, null, null },
                    { 266, "Đáp án 2 cho câu 67", 67, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(872), null, false, null, null, null },
                    { 267, "Đáp án 3 cho câu 67", 67, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(874), null, false, null, null, null },
                    { 268, "Đáp án 4 cho câu 67", 67, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(875), null, false, null, null, null },
                    { 269, "Đáp án 1 cho câu 68", 68, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(876), null, true, null, null, null },
                    { 270, "Đáp án 2 cho câu 68", 68, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(877), null, false, null, null, null },
                    { 271, "Đáp án 3 cho câu 68", 68, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(878), null, false, null, null, null },
                    { 272, "Đáp án 4 cho câu 68", 68, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(879), null, false, null, null, null },
                    { 273, "Đáp án 1 cho câu 69", 69, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(880), null, true, null, null, null },
                    { 274, "Đáp án 2 cho câu 69", 69, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(882), null, false, null, null, null },
                    { 275, "Đáp án 3 cho câu 69", 69, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(883), null, false, null, null, null },
                    { 276, "Đáp án 4 cho câu 69", 69, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(884), null, false, null, null, null },
                    { 277, "Đáp án 1 cho câu 70", 70, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(885), null, true, null, null, null },
                    { 278, "Đáp án 2 cho câu 70", 70, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(886), null, false, null, null, null },
                    { 279, "Đáp án 3 cho câu 70", 70, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(887), null, false, null, null, null },
                    { 280, "Đáp án 4 cho câu 70", 70, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(888), null, false, null, null, null },
                    { 281, "Đáp án 1 cho câu 71", 71, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(890), null, true, null, null, null },
                    { 282, "Đáp án 2 cho câu 71", 71, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(891), null, false, null, null, null },
                    { 283, "Đáp án 3 cho câu 71", 71, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(892), null, false, null, null, null },
                    { 284, "Đáp án 4 cho câu 71", 71, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(893), null, false, null, null, null },
                    { 285, "Đáp án 1 cho câu 72", 72, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(894), null, true, null, null, null },
                    { 286, "Đáp án 2 cho câu 72", 72, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(895), null, false, null, null, null },
                    { 287, "Đáp án 3 cho câu 72", 72, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(897), null, false, null, null, null },
                    { 288, "Đáp án 4 cho câu 72", 72, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(898), null, false, null, null, null },
                    { 289, "Đáp án 1 cho câu 73", 73, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(899), null, true, null, null, null },
                    { 290, "Đáp án 2 cho câu 73", 73, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(900), null, false, null, null, null },
                    { 291, "Đáp án 3 cho câu 73", 73, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(901), null, false, null, null, null },
                    { 292, "Đáp án 4 cho câu 73", 73, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(903), null, false, null, null, null },
                    { 293, "Đáp án 1 cho câu 74", 74, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(904), null, true, null, null, null },
                    { 294, "Đáp án 2 cho câu 74", 74, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(905), null, false, null, null, null },
                    { 295, "Đáp án 3 cho câu 74", 74, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(906), null, false, null, null, null },
                    { 296, "Đáp án 4 cho câu 74", 74, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(907), null, false, null, null, null },
                    { 297, "Đáp án 1 cho câu 75", 75, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(908), null, true, null, null, null },
                    { 298, "Đáp án 2 cho câu 75", 75, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(909), null, false, null, null, null },
                    { 299, "Đáp án 3 cho câu 75", 75, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(911), null, false, null, null, null },
                    { 300, "Đáp án 4 cho câu 75", 75, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(912), null, false, null, null, null },
                    { 301, "Đáp án 1 cho câu 76", 76, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1102), null, true, null, null, null },
                    { 302, "Đáp án 2 cho câu 76", 76, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1105), null, false, null, null, null },
                    { 303, "Đáp án 3 cho câu 76", 76, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1107), null, false, null, null, null },
                    { 304, "Đáp án 4 cho câu 76", 76, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1108), null, false, null, null, null },
                    { 305, "Đáp án 1 cho câu 77", 77, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1110), null, true, null, null, null },
                    { 306, "Đáp án 2 cho câu 77", 77, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1111), null, false, null, null, null },
                    { 307, "Đáp án 3 cho câu 77", 77, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1112), null, false, null, null, null },
                    { 308, "Đáp án 4 cho câu 77", 77, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1113), null, false, null, null, null },
                    { 309, "Đáp án 1 cho câu 78", 78, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1115), null, true, null, null, null },
                    { 310, "Đáp án 2 cho câu 78", 78, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1116), null, false, null, null, null },
                    { 311, "Đáp án 3 cho câu 78", 78, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1117), null, false, null, null, null },
                    { 312, "Đáp án 4 cho câu 78", 78, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1118), null, false, null, null, null },
                    { 313, "Đáp án 1 cho câu 79", 79, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1120), null, true, null, null, null },
                    { 314, "Đáp án 2 cho câu 79", 79, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1121), null, false, null, null, null },
                    { 315, "Đáp án 3 cho câu 79", 79, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1123), null, false, null, null, null },
                    { 316, "Đáp án 4 cho câu 79", 79, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1131), null, false, null, null, null },
                    { 317, "Đáp án 1 cho câu 80", 80, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1132), null, true, null, null, null },
                    { 318, "Đáp án 2 cho câu 80", 80, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1133), null, false, null, null, null },
                    { 319, "Đáp án 3 cho câu 80", 80, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1135), null, false, null, null, null },
                    { 320, "Đáp án 4 cho câu 80", 80, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1136), null, false, null, null, null },
                    { 321, "Đáp án 1 cho câu 81", 81, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1137), null, true, null, null, null },
                    { 322, "Đáp án 2 cho câu 81", 81, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1138), null, false, null, null, null },
                    { 323, "Đáp án 3 cho câu 81", 81, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1139), null, false, null, null, null },
                    { 324, "Đáp án 4 cho câu 81", 81, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1140), null, false, null, null, null },
                    { 325, "Đáp án 1 cho câu 82", 82, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1141), null, true, null, null, null },
                    { 326, "Đáp án 2 cho câu 82", 82, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1143), null, false, null, null, null },
                    { 327, "Đáp án 3 cho câu 82", 82, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1144), null, false, null, null, null },
                    { 328, "Đáp án 4 cho câu 82", 82, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1145), null, false, null, null, null },
                    { 329, "Đáp án 1 cho câu 83", 83, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1146), null, true, null, null, null },
                    { 330, "Đáp án 2 cho câu 83", 83, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1147), null, false, null, null, null },
                    { 331, "Đáp án 3 cho câu 83", 83, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1148), null, false, null, null, null },
                    { 332, "Đáp án 4 cho câu 83", 83, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1150), null, false, null, null, null },
                    { 333, "Đáp án 1 cho câu 84", 84, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1151), null, true, null, null, null },
                    { 334, "Đáp án 2 cho câu 84", 84, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1152), null, false, null, null, null },
                    { 335, "Đáp án 3 cho câu 84", 84, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1153), null, false, null, null, null },
                    { 336, "Đáp án 4 cho câu 84", 84, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1154), null, false, null, null, null },
                    { 337, "Đáp án 1 cho câu 85", 85, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1156), null, true, null, null, null },
                    { 338, "Đáp án 2 cho câu 85", 85, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1160), null, false, null, null, null },
                    { 339, "Đáp án 3 cho câu 85", 85, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1161), null, false, null, null, null },
                    { 340, "Đáp án 4 cho câu 85", 85, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1163), null, false, null, null, null },
                    { 341, "Đáp án 1 cho câu 86", 86, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1164), null, true, null, null, null },
                    { 342, "Đáp án 2 cho câu 86", 86, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1165), null, false, null, null, null },
                    { 343, "Đáp án 3 cho câu 86", 86, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1166), null, false, null, null, null },
                    { 344, "Đáp án 4 cho câu 86", 86, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1167), null, false, null, null, null },
                    { 345, "Đáp án 1 cho câu 87", 87, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1168), null, true, null, null, null },
                    { 346, "Đáp án 2 cho câu 87", 87, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1170), null, false, null, null, null },
                    { 347, "Đáp án 3 cho câu 87", 87, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1171), null, false, null, null, null },
                    { 348, "Đáp án 4 cho câu 87", 87, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1172), null, false, null, null, null },
                    { 349, "Đáp án 1 cho câu 88", 88, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1173), null, true, null, null, null },
                    { 350, "Đáp án 2 cho câu 88", 88, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1174), null, false, null, null, null },
                    { 351, "Đáp án 3 cho câu 88", 88, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1175), null, false, null, null, null },
                    { 352, "Đáp án 4 cho câu 88", 88, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1177), null, false, null, null, null },
                    { 353, "Đáp án 1 cho câu 89", 89, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1178), null, true, null, null, null },
                    { 354, "Đáp án 2 cho câu 89", 89, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1179), null, false, null, null, null },
                    { 355, "Đáp án 3 cho câu 89", 89, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1180), null, false, null, null, null },
                    { 356, "Đáp án 4 cho câu 89", 89, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1181), null, false, null, null, null },
                    { 357, "Đáp án 1 cho câu 90", 90, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1182), null, true, null, null, null },
                    { 358, "Đáp án 2 cho câu 90", 90, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1183), null, false, null, null, null },
                    { 359, "Đáp án 3 cho câu 90", 90, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1185), null, false, null, null, null },
                    { 360, "Đáp án 4 cho câu 90", 90, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1186), null, false, null, null, null },
                    { 361, "Đáp án 1 cho câu 91", 91, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1187), null, true, null, null, null },
                    { 362, "Đáp án 2 cho câu 91", 91, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1188), null, false, null, null, null },
                    { 363, "Đáp án 3 cho câu 91", 91, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1189), null, false, null, null, null },
                    { 364, "Đáp án 4 cho câu 91", 91, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1191), null, false, null, null, null },
                    { 365, "Đáp án 1 cho câu 92", 92, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1192), null, true, null, null, null },
                    { 366, "Đáp án 2 cho câu 92", 92, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1193), null, false, null, null, null },
                    { 367, "Đáp án 3 cho câu 92", 92, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1195), null, false, null, null, null },
                    { 368, "Đáp án 4 cho câu 92", 92, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1196), null, false, null, null, null },
                    { 369, "Đáp án 1 cho câu 93", 93, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1197), null, true, null, null, null },
                    { 370, "Đáp án 2 cho câu 93", 93, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1198), null, false, null, null, null },
                    { 371, "Đáp án 3 cho câu 93", 93, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1199), null, false, null, null, null },
                    { 372, "Đáp án 4 cho câu 93", 93, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1200), null, false, null, null, null },
                    { 373, "Đáp án 1 cho câu 94", 94, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1211), null, true, null, null, null },
                    { 374, "Đáp án 2 cho câu 94", 94, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1212), null, false, null, null, null },
                    { 375, "Đáp án 3 cho câu 94", 94, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1214), null, false, null, null, null },
                    { 376, "Đáp án 4 cho câu 94", 94, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1215), null, false, null, null, null },
                    { 377, "Đáp án 1 cho câu 95", 95, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1216), null, true, null, null, null },
                    { 378, "Đáp án 2 cho câu 95", 95, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1217), null, false, null, null, null },
                    { 379, "Đáp án 3 cho câu 95", 95, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1218), null, false, null, null, null },
                    { 380, "Đáp án 4 cho câu 95", 95, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1219), null, false, null, null, null },
                    { 381, "Đáp án 1 cho câu 96", 96, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1221), null, true, null, null, null },
                    { 382, "Đáp án 2 cho câu 96", 96, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1222), null, false, null, null, null },
                    { 383, "Đáp án 3 cho câu 96", 96, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1223), null, false, null, null, null },
                    { 384, "Đáp án 4 cho câu 96", 96, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1224), null, false, null, null, null },
                    { 385, "Đáp án 1 cho câu 97", 97, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1225), null, true, null, null, null },
                    { 386, "Đáp án 2 cho câu 97", 97, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1226), null, false, null, null, null },
                    { 387, "Đáp án 3 cho câu 97", 97, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1227), null, false, null, null, null },
                    { 388, "Đáp án 4 cho câu 97", 97, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1229), null, false, null, null, null },
                    { 389, "Đáp án 1 cho câu 98", 98, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1230), null, true, null, null, null },
                    { 390, "Đáp án 2 cho câu 98", 98, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1232), null, false, null, null, null },
                    { 391, "Đáp án 3 cho câu 98", 98, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1233), null, false, null, null, null },
                    { 392, "Đáp án 4 cho câu 98", 98, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1234), null, false, null, null, null },
                    { 393, "Đáp án 1 cho câu 99", 99, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1235), null, true, null, null, null },
                    { 394, "Đáp án 2 cho câu 99", 99, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1237), null, false, null, null, null },
                    { 395, "Đáp án 3 cho câu 99", 99, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1258), null, false, null, null, null },
                    { 396, "Đáp án 4 cho câu 99", 99, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1259), null, false, null, null, null },
                    { 397, "Đáp án 1 cho câu 100", 100, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1261), null, true, null, null, null },
                    { 398, "Đáp án 2 cho câu 100", 100, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1262), null, false, null, null, null },
                    { 399, "Đáp án 3 cho câu 100", 100, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1263), null, false, null, null, null },
                    { 400, "Đáp án 4 cho câu 100", 100, new DateTime(2025, 6, 29, 13, 17, 38, 252, DateTimeKind.Local).AddTicks(1264), null, false, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "QuestionExams",
                columns: new[] { "Id", "BankQuestionId", "Content", "CreatedAt", "DeletedAt", "ExamId", "IsPublic", "LevelId", "QuestionTypeId", "UpdateBy", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, "Câu 1: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 2, 2, "Câu 2: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 3, 1, null, null },
                    { 3, 3, "Câu 3: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 3, 1, null, null },
                    { 4, 4, "Câu 4: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 3, 1, null, null },
                    { 5, 5, "Câu 5: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 3, 1, null, null },
                    { 6, 6, "Câu 6: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 3, 1, null, null },
                    { 7, 7, "Câu 7: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 8, 8, "Câu 8: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 9, 9, "Câu 9: Chủ nghĩa duy vật biện chứng - Nội dung trọng tâm số 9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 10, 10, "Câu 10: Phép biện chứng - Nội dung trọng tâm số 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 11, 11, "Câu 11: Phép biện chứng - Nội dung trọng tâm số 11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 2, 1, null, null },
                    { 12, 12, "Câu 12: Phép biện chứng - Nội dung trọng tâm số 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 3, 1, null, null },
                    { 13, 13, "Câu 13: Phép biện chứng - Nội dung trọng tâm số 13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 14, 14, "Câu 14: Phép biện chứng - Nội dung trọng tâm số 14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 3, 1, null, null },
                    { 15, 15, "Câu 15: Phép biện chứng - Nội dung trọng tâm số 15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 16, 16, "Câu 16: Phép biện chứng - Nội dung trọng tâm số 16", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 3, 1, null, null },
                    { 17, 17, "Câu 17: Phép biện chứng - Nội dung trọng tâm số 17", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 18, 18, "Câu 18: Phép biện chứng - Nội dung trọng tâm số 18", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 19, 19, "Câu 19: Vật chất và ý thức - Nội dung trọng tâm số 19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 2, 1, null, null },
                    { 20, 20, "Câu 20: Vật chất và ý thức - Nội dung trọng tâm số 20", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 21, 21, "Câu 21: Vật chất và ý thức - Nội dung trọng tâm số 21", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 3, 1, null, null },
                    { 22, 22, "Câu 22: Vật chất và ý thức - Nội dung trọng tâm số 22", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 3, 1, null, null },
                    { 23, 23, "Câu 23: Vật chất và ý thức - Nội dung trọng tâm số 23", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 2, 1, null, null },
                    { 24, 24, "Câu 24: Vật chất và ý thức - Nội dung trọng tâm số 24", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 3, 1, null, null },
                    { 25, 25, "Câu 25: Vật chất và ý thức - Nội dung trọng tâm số 25", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 3, 1, null, null },
                    { 26, 26, "Câu 26: Vật chất và ý thức - Nội dung trọng tâm số 26", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 27, 27, "Câu 27: Vật chất và ý thức - Nội dung trọng tâm số 27", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 2, 1, null, null },
                    { 28, 28, "Câu 28: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 28", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 29, 29, "Câu 29: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 29", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 2, 1, null, null },
                    { 30, 30, "Câu 30: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 30", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 2, 1, null, null },
                    { 31, 31, "Câu 31: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 31", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 3, 1, null, null },
                    { 32, 32, "Câu 32: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 32", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 2, 1, null, null },
                    { 33, 33, "Câu 33: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 33", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 2, 1, null, null },
                    { 34, 34, "Câu 34: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 34", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 2, 1, null, null },
                    { 35, 35, "Câu 35: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 35", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 36, 36, "Câu 36: Phép biện chứng về lượng và chất - Nội dung trọng tâm số 36", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 37, 37, "Câu 37: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 37", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 38, 38, "Câu 38: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 38", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 2, 1, null, null },
                    { 39, 39, "Câu 39: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 39", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 3, 1, null, null },
                    { 40, 40, "Câu 40: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 40", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 2, 1, null, null },
                    { 41, 41, "Câu 41: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 41", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 3, 1, null, null },
                    { 42, 42, "Câu 42: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 42", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 43, 43, "Câu 43: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 43", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 3, 1, null, null },
                    { 44, 44, "Câu 44: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 44", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 2, 1, null, null },
                    { 45, 45, "Câu 45: Nguyên lý về mâu thuẫn - Nội dung trọng tâm số 45", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 46, 46, "Câu 46: Nhận thức và thực tiễn - Nội dung trọng tâm số 46", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 47, 47, "Câu 47: Nhận thức và thực tiễn - Nội dung trọng tâm số 47", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 2, 1, null, null },
                    { 48, 48, "Câu 48: Nhận thức và thực tiễn - Nội dung trọng tâm số 48", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 1, 1, null, null },
                    { 49, 49, "Câu 49: Nhận thức và thực tiễn - Nội dung trọng tâm số 49", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 3, 1, null, null },
                    { 50, 50, "Câu 50: Nhận thức và thực tiễn - Nội dung trọng tâm số 50", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, 3, 1, null, null },
                    { 51, 51, "Câu 51: Nhận thức và thực tiễn - Nội dung trọng tâm số 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 52, 52, "Câu 52: Nhận thức và thực tiễn - Nội dung trọng tâm số 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 53, 53, "Câu 53: Nhận thức và thực tiễn - Nội dung trọng tâm số 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 54, 54, "Câu 54: Nhận thức và thực tiễn - Nội dung trọng tâm số 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 55, 55, "Câu 55: Vai trò của con người - Nội dung trọng tâm số 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 56, 56, "Câu 56: Vai trò của con người - Nội dung trọng tâm số 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 57, 57, "Câu 57: Vai trò của con người - Nội dung trọng tâm số 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 58, 58, "Câu 58: Vai trò của con người - Nội dung trọng tâm số 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 1, 1, null, null },
                    { 59, 59, "Câu 59: Vai trò của con người - Nội dung trọng tâm số 9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 1, 1, null, null },
                    { 60, 60, "Câu 60: Vai trò của con người - Nội dung trọng tâm số 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 3, 1, null, null },
                    { 61, 61, "Câu 61: Vai trò của con người - Nội dung trọng tâm số 11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 1, 1, null, null },
                    { 62, 62, "Câu 62: Vai trò của con người - Nội dung trọng tâm số 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 3, 1, null, null },
                    { 63, 63, "Câu 63: Vai trò của con người - Nội dung trọng tâm số 13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 3, 1, null, null },
                    { 64, 64, "Câu 64: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 3, 1, null, null },
                    { 65, 65, "Câu 65: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 66, 66, "Câu 66: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 16", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 67, 67, "Câu 67: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 17", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 68, 68, "Câu 68: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 18", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 69, 69, "Câu 69: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 3, 1, null, null },
                    { 70, 70, "Câu 70: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 20", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 1, 1, null, null },
                    { 71, 71, "Câu 71: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 21", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 72, 72, "Câu 72: Chủ nghĩa duy vật lịch sử - Nội dung trọng tâm số 22", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 73, 73, "Câu 73: Hình thái kinh tế xã hội - Nội dung trọng tâm số 23", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 3, 1, null, null },
                    { 74, 74, "Câu 74: Hình thái kinh tế xã hội - Nội dung trọng tâm số 24", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 75, 75, "Câu 75: Hình thái kinh tế xã hội - Nội dung trọng tâm số 25", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 3, 1, null, null },
                    { 76, 76, "Câu 76: Hình thái kinh tế xã hội - Nội dung trọng tâm số 26", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 77, 77, "Câu 77: Hình thái kinh tế xã hội - Nội dung trọng tâm số 27", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 3, 1, null, null },
                    { 78, 78, "Câu 78: Hình thái kinh tế xã hội - Nội dung trọng tâm số 28", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 1, 1, null, null },
                    { 79, 79, "Câu 79: Hình thái kinh tế xã hội - Nội dung trọng tâm số 29", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 3, 1, null, null },
                    { 80, 80, "Câu 80: Hình thái kinh tế xã hội - Nội dung trọng tâm số 30", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 3, 1, null, null },
                    { 81, 81, "Câu 81: Hình thái kinh tế xã hội - Nội dung trọng tâm số 31", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 82, 82, "Câu 82: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 32", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 1, 1, null, null },
                    { 83, 83, "Câu 83: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 33", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 1, 1, null, null },
                    { 84, 84, "Câu 84: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 34", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 3, 1, null, null },
                    { 85, 85, "Câu 85: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 35", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 3, 1, null, null },
                    { 86, 86, "Câu 86: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 36", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 87, 87, "Câu 87: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 37", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 1, 1, null, null },
                    { 88, 88, "Câu 88: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 38", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 89, 89, "Câu 89: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 39", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 3, 1, null, null },
                    { 90, 90, "Câu 90: Giai cấp và đấu tranh giai cấp - Nội dung trọng tâm số 40", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 3, 1, null, null },
                    { 91, 91, "Câu 91: Nhà nước và cách mạng - Nội dung trọng tâm số 41", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 3, 1, null, null },
                    { 92, 92, "Câu 92: Nhà nước và cách mạng - Nội dung trọng tâm số 42", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 93, 93, "Câu 93: Nhà nước và cách mạng - Nội dung trọng tâm số 43", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 1, 1, null, null },
                    { 94, 94, "Câu 94: Nhà nước và cách mạng - Nội dung trọng tâm số 44", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 3, 1, null, null },
                    { 95, 95, "Câu 95: Nhà nước và cách mạng - Nội dung trọng tâm số 45", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 1, 1, null, null },
                    { 96, 96, "Câu 96: Nhà nước và cách mạng - Nội dung trọng tâm số 46", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 97, 97, "Câu 97: Nhà nước và cách mạng - Nội dung trọng tâm số 47", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 98, 98, "Câu 98: Nhà nước và cách mạng - Nội dung trọng tâm số 48", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 1, 1, null, null },
                    { 99, 99, "Câu 99: Nhà nước và cách mạng - Nội dung trọng tâm số 49", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null },
                    { 100, 100, "Câu 100: Chủ nghĩa xã hội khoa học - Nội dung trọng tâm số 50", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, 2, 1, null, null }
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

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "SubcriptionPackages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 20, 16, 54, 644, DateTimeKind.Local).AddTicks(8892));
        }
    }
}
