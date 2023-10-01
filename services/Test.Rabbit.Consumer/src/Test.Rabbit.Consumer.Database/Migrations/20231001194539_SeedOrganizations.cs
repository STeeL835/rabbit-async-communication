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
                    { new Guid("09dfb161-d57c-42e6-89fc-f231dabd2c5f"), "Organization 9" },
                    { new Guid("3e233ece-de20-49a6-83c4-a6378907e526"), "Organization 7" },
                    { new Guid("47da97ac-b236-421b-9dac-e140dc90643a"), "Organization 10" },
                    { new Guid("62b6e811-e44b-4332-8356-12250262ca5d"), "Organization 6" },
                    { new Guid("6d56423c-b40a-4226-8273-06d9f28bac78"), "Organization 3" },
                    { new Guid("737731dc-b1fc-4196-9d9f-2f30566b7268"), "Organization 5" },
                    { new Guid("d82e1801-4e0a-47c0-9677-489aac621217"), "Organization 8" },
                    { new Guid("e47c38ee-8544-40b4-8e68-83f8ddc796b9"), "Organization 2" },
                    { new Guid("ea831b56-46bf-45c5-94dd-ef7acc8d9e28"), "Organization 4" },
                    { new Guid("fc75b1a2-24f9-45dc-b06f-a34eb1b1e7ef"), "Organization 1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("09dfb161-d57c-42e6-89fc-f231dabd2c5f"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("3e233ece-de20-49a6-83c4-a6378907e526"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("47da97ac-b236-421b-9dac-e140dc90643a"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("62b6e811-e44b-4332-8356-12250262ca5d"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("6d56423c-b40a-4226-8273-06d9f28bac78"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("737731dc-b1fc-4196-9d9f-2f30566b7268"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("d82e1801-4e0a-47c0-9677-489aac621217"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("e47c38ee-8544-40b4-8e68-83f8ddc796b9"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("ea831b56-46bf-45c5-94dd-ef7acc8d9e28"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("fc75b1a2-24f9-45dc-b06f-a34eb1b1e7ef"));
        }
    }
}
