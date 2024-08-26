using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamingStoreTekrar.Migrations
{
    public partial class mig07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d981205-99c0-4bba-a36c-ba0ad7baf245");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cb928ee-afdc-42ee-8775-67f9c670c90c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fe1f140-47dc-4c95-8c92-06f62a2262bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf5287ad-93f2-47c2-a685-8aa202d0a6be");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReviewText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "58d3b9f6-c83b-4f53-a50b-d94333596e8c", "a24aeb72-c3a3-4fe0-8f0d-2cd11f370d94", "None", "NONE" },
                    { "82ad0838-e424-445c-800e-fa698f7f5717", "275a43b9-844c-4c0d-88af-112d35fdd008", "Admin", "ADMİN" },
                    { "8750bb40-28b5-454d-92d3-25bb26630774", "9218ac36-ac6a-4d46-833e-e9f255b06a2c", "Moderator", "MODERATOR" },
                    { "b9b73826-4a7b-4b02-bf20-02aa5957728d", "b26502bb-b2b9-4769-a08b-e4f6bec881fa", "Client", "CLİENT" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_GameId",
                table: "Reviews",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58d3b9f6-c83b-4f53-a50b-d94333596e8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82ad0838-e424-445c-800e-fa698f7f5717");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8750bb40-28b5-454d-92d3-25bb26630774");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9b73826-4a7b-4b02-bf20-02aa5957728d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d981205-99c0-4bba-a36c-ba0ad7baf245", "7a7ca5eb-046a-45e6-bbce-2075c2c4c486", "None", "NONE" },
                    { "6cb928ee-afdc-42ee-8775-67f9c670c90c", "ebe43935-fafd-495f-9dba-4c8f1b3aa559", "Moderator", "MODERATOR" },
                    { "9fe1f140-47dc-4c95-8c92-06f62a2262bc", "8adfe27e-27f3-4a0a-aa91-f2413326ff2e", "Client", "CLİENT" },
                    { "cf5287ad-93f2-47c2-a685-8aa202d0a6be", "a3ec1fd6-a9a2-426f-9afc-2d92ff804bae", "Admin", "ADMİN" }
                });
        }
    }
}
