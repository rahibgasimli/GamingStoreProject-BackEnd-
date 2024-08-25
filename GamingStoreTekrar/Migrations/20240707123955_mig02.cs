using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamingStoreTekrar.Migrations
{
    public partial class mig02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("67fedf7c-b775-41ed-a595-7bf345000057"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(2120), false, "Crafting", null },
                    { new Guid("c2bbbe97-c386-4794-9fe4-71a3681ac920"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(2122), false, "Survival", null },
                    { new Guid("f66c6a9c-af2a-426a-89dd-7fabc465b162"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(2117), false, "War", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "ShortDesc", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("08b5a70f-0f06-4e15-a43e-e3506a3c0a37"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(1968), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatem iusto sit quae. Nesciunt, veniam dolorum! Ad, saepe. At, ipsum.", false, "Minecraft", "images/top-game-06.jpg", 30.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("0d9cbc14-1f33-4792-9278-0a8ad50d1755"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(1984), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugiat quaerat molestiae laborum corporis, laudantium odit voluptate eligendi tempore vero!", false, "The Last of Us Part II", "images/top-game-03.jpg", 45.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("3785790e-0c3f-4c6c-90e9-7ff56fb854ca"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(1957), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Cupiditate quibusdam eveniet voluptatum maiores expedita eos dolore itaque, doloremque ab quae.", false, "Halo Infinite", "images/top-game-02.jpg", 70.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("3b4aeb54-91cc-4fd9-b3a1-9b7f140c4810"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(1954), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptas aliquam aspernatur repellendus a, possimus vero at molestias voluptatibus maxime nisi!", false, "Assassin's Creed", "images/top-game-01.jpg", 50.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("8caacba0-0990-47db-8402-5dfac9f14327"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(1961), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque, quam exercitationem! Deserunt, obcaecati. Eaque minima tempora velit laudantium.", false, "Red Dead Redemption 2", "images/top-game-04.jpg", 55.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("90e838b1-a39a-4f69-a8da-aacbfa11cd11"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(1935), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Impedit minus corrupti voluptate repudiandae assumenda illo consequuntur, quaerat animi. Quisquam, praesentium.", false, "Call of Duty", "images/cta-bg.jpg", 60.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("a5cdaa73-7b0a-40ab-b87c-e530bf623bc5"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(1959), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sint aliquid ab esse expedita veritatis eius quia repellendus, ipsam neque odit.", false, "The Witcher 3: Wild Hunt", "images/top-game-03.jpg", 40.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("ad9f426f-532a-4e11-a915-6b5f32830056"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(1966), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Consequuntur quam deleniti doloribus recusandae sequi, laudantium doloremque quod sit omnis.", false, "FIFA 22", "images/top-game-05.jpg", 45.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("ae364d6f-fb3d-4714-a21a-cfb22b2ba05d"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(1987), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam nihil odio quos doloribus maiores, laborum minus, quibusdam distinctio consequatur!", false, "Grand Theft Auto V", "images/top-game-02.jpg", 40.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("b949cd63-b760-4cd0-b8a8-6953f98474ac"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(1990), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Adipisci voluptas exercitationem reiciendis iure eius dolorem excepturi molestias dolorum voluptatibus.", false, "Fortnite", "images/top-game-04.jpg", 0.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("f91f5519-0103-4088-b8f5-1f309d3e88cf"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(1982), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Autem quis iusto, blanditiis fugit dolorem odit nisi laborum sapiente eius!", false, "Cyberpunk 2077", "images/top-game-05.jpg", 50.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("4f533c75-24ad-4c65-86da-4acee375c169"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(2075), false, "Simulation", null },
                    { new Guid("561acae1-6df0-417e-b077-851e4e323c40"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(2072), false, "Adventure", null },
                    { new Guid("d4c31d11-9e1b-4f9d-8903-1c326d2b5ae0"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(2070), false, "Horror", null },
                    { new Guid("ec9fb7ce-51c3-4a6a-a1b4-df35476e5469"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(2066), false, "Action", null },
                    { new Guid("f95bc565-e706-4443-9552-7b7562368ed2"), new DateTime(2024, 7, 7, 16, 39, 55, 219, DateTimeKind.Local).AddTicks(2081), false, "Battle royale", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("67fedf7c-b775-41ed-a595-7bf345000057"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("c2bbbe97-c386-4794-9fe4-71a3681ac920"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("f66c6a9c-af2a-426a-89dd-7fabc465b162"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("08b5a70f-0f06-4e15-a43e-e3506a3c0a37"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0d9cbc14-1f33-4792-9278-0a8ad50d1755"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3785790e-0c3f-4c6c-90e9-7ff56fb854ca"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3b4aeb54-91cc-4fd9-b3a1-9b7f140c4810"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8caacba0-0990-47db-8402-5dfac9f14327"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("90e838b1-a39a-4f69-a8da-aacbfa11cd11"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a5cdaa73-7b0a-40ab-b87c-e530bf623bc5"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ad9f426f-532a-4e11-a915-6b5f32830056"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ae364d6f-fb3d-4714-a21a-cfb22b2ba05d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b949cd63-b760-4cd0-b8a8-6953f98474ac"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f91f5519-0103-4088-b8f5-1f309d3e88cf"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4f533c75-24ad-4c65-86da-4acee375c169"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("561acae1-6df0-417e-b077-851e4e323c40"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d4c31d11-9e1b-4f9d-8903-1c326d2b5ae0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ec9fb7ce-51c3-4a6a-a1b4-df35476e5469"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f95bc565-e706-4443-9552-7b7562368ed2"));
        }
    }
}
