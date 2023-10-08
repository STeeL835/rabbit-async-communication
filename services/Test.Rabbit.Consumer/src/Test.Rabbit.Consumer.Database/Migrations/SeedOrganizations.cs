using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Test.Rabbit.Consumer.Database.Migrations
{
    /// <inheritdoc />
    public partial class SeedOrganizations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("750f2041-6c70-40fc-8c21-f5dd889a6ad1"), "Organization 1" },
                    { new Guid("750f2041-6c70-40fc-8c21-f5dd889a6ad2"), "Organization 2" },
                    { new Guid("750f2041-6c70-40fc-8c21-f5dd889a6ad3"), "Organization 3" },
                    { new Guid("750f2041-6c70-40fc-8c21-f5dd889a6ad4"), "Organization 4" },
                    { new Guid("750f2041-6c70-40fc-8c21-f5dd889a6ad5"), "Organization 5" },
                    { new Guid("750f2041-6c70-40fc-8c21-f5dd889a6ad6"), "Organization 6" },
                    { new Guid("750f2041-6c70-40fc-8c21-f5dd889a6ad7"), "Organization 7" },
                    { new Guid("750f2041-6c70-40fc-8c21-f5dd889a6ad8"), "Organization 8" },
                    { new Guid("750f2041-6c70-40fc-8c21-f5dd889a6ad9"), "Organization 9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("750f2041-6c70-40fc-8c21-f5dd889a6ad1"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("750f2041-6c70-40fc-8c21-f5dd889a6ad2"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("750f2041-6c70-40fc-8c21-f5dd889a6ad3"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("750f2041-6c70-40fc-8c21-f5dd889a6ad4"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("750f2041-6c70-40fc-8c21-f5dd889a6ad5"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("750f2041-6c70-40fc-8c21-f5dd889a6ad6"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("750f2041-6c70-40fc-8c21-f5dd889a6ad7"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("750f2041-6c70-40fc-8c21-f5dd889a6ad8"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("750f2041-6c70-40fc-8c21-f5dd889a6ad9"));
        }
    }
}
