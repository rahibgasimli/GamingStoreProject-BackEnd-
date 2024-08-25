using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamingStoreTekrar.Migrations
{
    public partial class mig05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("54c70052-1962-49b2-a365-94b19b99cd90"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("781cec06-de06-4a1a-bb55-477fe77f3a10"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("9edbfd86-fe2d-48dd-8b71-c3047d853cb2"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("205ec818-9135-42d4-80a8-3a98b5808279"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("42e6812c-8744-4cf6-8391-ea388e0fdca3"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4e15ff18-9e91-42ad-969e-71c0e888bf1a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("526d7f8e-d989-45a3-87aa-27806385abd0"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("59f4fadb-a264-4d94-a033-6b2734b3e038"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5d3288ef-99c8-4741-8cc2-60d3423f9156"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("61821ed4-b660-4507-87ff-fc5b0f50aecc"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85c4136d-af38-4be5-9504-eed922015e60"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ad80d084-69ac-4422-89bf-4eb180fdb448"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("af065e42-aea2-4a96-bdcd-ba31f879c608"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e4d93132-4292-467f-9eb9-a9460c3650a1"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0311f88a-e3f7-42fb-b889-30f0ce6e022f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("942a41bb-c612-483d-b1fd-11326e6711ee"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d9015424-d1f3-47f8-a28a-686a0012641a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e4edf488-73ff-4926-8880-5c8fe135dcec"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fc110e2e-8277-40cc-8104-d6f76fbcae80"));

            migrationBuilder.AddColumn<int>(
                name: "ClickCount",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("89c0870d-3f03-45ea-aa3f-0911adad553a"), new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1958), false, "War", null },
                    { new Guid("aca1be9b-f679-4c4d-bdb7-d5191a06d0cf"), new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1962), false, "Crafting", null },
                    { new Guid("e9b5cdfa-e618-4e67-b8ac-df7ec4ab3016"), new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1964), false, "Survival", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ClickCount", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "ShortDesc", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0e721b54-eb91-4d70-87cb-f6a7fc85232d"), 0, new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1788), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Impedit minus corrupti voluptate repudiandae assumenda illo consequuntur, quaerat animi. Quisquam, praesentium.", false, "Call of Duty", "images/cta-bg.jpg", 60.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("1adea5d0-c77a-456a-933c-584e817dbd0b"), 0, new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1841), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam nihil odio quos doloribus maiores, laborum minus, quibusdam distinctio consequatur!", false, "Grand Theft Auto V", "images/top-game-02.jpg", 40.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("24092a9b-62f3-4a7e-ae9d-e50824bfcfc8"), 0, new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1820), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Consequuntur quam deleniti doloribus recusandae sequi, laudantium doloremque quod sit omnis.", false, "FIFA 22", "images/top-game-05.jpg", 45.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("43476aa3-31ec-42e9-b907-d2181f58c0ab"), 0, new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1810), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Cupiditate quibusdam eveniet voluptatum maiores expedita eos dolore itaque, doloremque ab quae.", false, "Halo Infinite", "images/top-game-02.jpg", 70.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("58101529-76de-4e5f-a9e5-8cd86f59b839"), 0, new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1807), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptas aliquam aspernatur repellendus a, possimus vero at molestias voluptatibus maxime nisi!", false, "Assassin's Creed", "images/top-game-01.jpg", 50.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("5ec23775-6ef2-4db8-9962-3cb6e942856b"), 0, new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1822), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatem iusto sit quae. Nesciunt, veniam dolorum! Ad, saepe. At, ipsum.", false, "Minecraft", "images/top-game-06.jpg", 30.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("642003f9-7ec2-43c1-a91f-dc8d95f61f3d"), 0, new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1843), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Adipisci voluptas exercitationem reiciendis iure eius dolorem excepturi molestias dolorum voluptatibus.", false, "Fortnite", "images/top-game-04.jpg", 0.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("ada94c01-8d58-428b-85db-50b221c2dc51"), 0, new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1838), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugiat quaerat molestiae laborum corporis, laudantium odit voluptate eligendi tempore vero!", false, "The Last of Us Part II", "images/top-game-03.jpg", 45.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("d72d42f5-88b9-45ad-8b83-ad32471ab4e9"), 0, new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1836), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Autem quis iusto, blanditiis fugit dolorem odit nisi laborum sapiente eius!", false, "Cyberpunk 2077", "images/top-game-05.jpg", 50.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("e210ed1d-9149-4cfb-9084-ee8de717d999"), 0, new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1812), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sint aliquid ab esse expedita veritatis eius quia repellendus, ipsam neque odit.", false, "The Witcher 3: Wild Hunt", "images/top-game-03.jpg", 40.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("f7f15f76-d41d-4a6b-9cb9-28e1227c40cf"), 0, new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1814), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque, quam exercitationem! Deserunt, obcaecati. Eaque minima tempora velit laudantium.", false, "Red Dead Redemption 2", "images/top-game-04.jpg", 55.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("7821901f-12c6-4881-b852-9d9d6aebb3d6"), new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1906), false, "Action", null },
                    { new Guid("be8c073c-0e33-46cc-8d6e-d09887fd5964"), new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1914), false, "Simulation", null },
                    { new Guid("d5f3aade-fdc1-4d17-8202-1dd667bff05f"), new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1910), false, "Horror", null },
                    { new Guid("d62c33da-ce53-4e08-8def-e4ef70767e94"), new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1920), false, "Battle royale", null },
                    { new Guid("fc66c941-2d00-4a10-9380-0bb6a210373c"), new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1912), false, "Adventure", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("89c0870d-3f03-45ea-aa3f-0911adad553a"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("aca1be9b-f679-4c4d-bdb7-d5191a06d0cf"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("e9b5cdfa-e618-4e67-b8ac-df7ec4ab3016"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0e721b54-eb91-4d70-87cb-f6a7fc85232d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1adea5d0-c77a-456a-933c-584e817dbd0b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("24092a9b-62f3-4a7e-ae9d-e50824bfcfc8"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("43476aa3-31ec-42e9-b907-d2181f58c0ab"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("58101529-76de-4e5f-a9e5-8cd86f59b839"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5ec23775-6ef2-4db8-9962-3cb6e942856b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("642003f9-7ec2-43c1-a91f-dc8d95f61f3d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ada94c01-8d58-428b-85db-50b221c2dc51"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d72d42f5-88b9-45ad-8b83-ad32471ab4e9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e210ed1d-9149-4cfb-9084-ee8de717d999"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f7f15f76-d41d-4a6b-9cb9-28e1227c40cf"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7821901f-12c6-4881-b852-9d9d6aebb3d6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("be8c073c-0e33-46cc-8d6e-d09887fd5964"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d5f3aade-fdc1-4d17-8202-1dd667bff05f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d62c33da-ce53-4e08-8def-e4ef70767e94"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fc66c941-2d00-4a10-9380-0bb6a210373c"));

            migrationBuilder.DropColumn(
                name: "ClickCount",
                table: "Games");

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("54c70052-1962-49b2-a365-94b19b99cd90"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(1990), false, "War", null },
                    { new Guid("781cec06-de06-4a1a-bb55-477fe77f3a10"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(2010), false, "Crafting", null },
                    { new Guid("9edbfd86-fe2d-48dd-8b71-c3047d853cb2"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(2015), false, "Survival", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "ShortDesc", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("205ec818-9135-42d4-80a8-3a98b5808279"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(1745), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam nihil odio quos doloribus maiores, laborum minus, quibusdam distinctio consequatur!", false, "Grand Theft Auto V", "images/top-game-02.jpg", 40.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("42e6812c-8744-4cf6-8391-ea388e0fdca3"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(1691), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Cupiditate quibusdam eveniet voluptatum maiores expedita eos dolore itaque, doloremque ab quae.", false, "Halo Infinite", "images/top-game-02.jpg", 70.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("4e15ff18-9e91-42ad-969e-71c0e888bf1a"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(1687), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptas aliquam aspernatur repellendus a, possimus vero at molestias voluptatibus maxime nisi!", false, "Assassin's Creed", "images/top-game-01.jpg", 50.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("526d7f8e-d989-45a3-87aa-27806385abd0"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(1732), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugiat quaerat molestiae laborum corporis, laudantium odit voluptate eligendi tempore vero!", false, "The Last of Us Part II", "images/top-game-03.jpg", 45.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("59f4fadb-a264-4d94-a033-6b2734b3e038"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(1695), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sint aliquid ab esse expedita veritatis eius quia repellendus, ipsam neque odit.", false, "The Witcher 3: Wild Hunt", "images/top-game-03.jpg", 40.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("5d3288ef-99c8-4741-8cc2-60d3423f9156"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(1752), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Adipisci voluptas exercitationem reiciendis iure eius dolorem excepturi molestias dolorum voluptatibus.", false, "Fortnite", "images/top-game-04.jpg", 0.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("61821ed4-b660-4507-87ff-fc5b0f50aecc"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(1718), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatem iusto sit quae. Nesciunt, veniam dolorum! Ad, saepe. At, ipsum.", false, "Minecraft", "images/top-game-06.jpg", 30.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("85c4136d-af38-4be5-9504-eed922015e60"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(1702), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque, quam exercitationem! Deserunt, obcaecati. Eaque minima tempora velit laudantium.", false, "Red Dead Redemption 2", "images/top-game-04.jpg", 55.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("ad80d084-69ac-4422-89bf-4eb180fdb448"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(1636), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Impedit minus corrupti voluptate repudiandae assumenda illo consequuntur, quaerat animi. Quisquam, praesentium.", false, "Call of Duty", "images/cta-bg.jpg", 60.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("af065e42-aea2-4a96-bdcd-ba31f879c608"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(1715), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Consequuntur quam deleniti doloribus recusandae sequi, laudantium doloremque quod sit omnis.", false, "FIFA 22", "images/top-game-05.jpg", 45.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("e4d93132-4292-467f-9eb9-a9460c3650a1"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(1724), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Autem quis iusto, blanditiis fugit dolorem odit nisi laborum sapiente eius!", false, "Cyberpunk 2077", "images/top-game-05.jpg", 50.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0311f88a-e3f7-42fb-b889-30f0ce6e022f"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(1904), false, "Simulation", null },
                    { new Guid("942a41bb-c612-483d-b1fd-11326e6711ee"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(1910), false, "Battle royale", null },
                    { new Guid("d9015424-d1f3-47f8-a28a-686a0012641a"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(1898), false, "Horror", null },
                    { new Guid("e4edf488-73ff-4926-8880-5c8fe135dcec"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(1901), false, "Adventure", null },
                    { new Guid("fc110e2e-8277-40cc-8104-d6f76fbcae80"), new DateTime(2024, 7, 13, 14, 36, 55, 790, DateTimeKind.Local).AddTicks(1884), false, "Action", null }
                });
        }
    }
}
