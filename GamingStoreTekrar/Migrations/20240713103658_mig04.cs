using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamingStoreTekrar.Migrations
{
    public partial class mig04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("1e087a01-ad30-48c9-8015-9d3937da5f54"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("34c39d68-3e69-4b79-9459-9e856da2aab0"));

            migrationBuilder.DeleteData(
                table: "GameTags",
                keyColumn: "Id",
                keyValue: new Guid("c4b3b757-d166-476f-8f3a-e5d4976a9f00"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("030376bf-fa43-4e5e-8579-f6a21e957f6e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("06af56ea-ebbf-427b-aba0-ad7c24599c39"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4c28d261-9080-46cb-bcae-52eeded322fb"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("618e1aa0-4d54-477b-aff6-4a841dbd90c1"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("7fbba26c-9b97-4f70-9764-f1413c60cf80"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("93ddba79-fd1f-413f-b368-3f36d1268183"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("9f5d890d-837a-4e7c-942c-3b996a3b7805"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c08b8037-936e-4223-8fbc-1bc58585862a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d0682606-78b3-4a62-8b8d-5276e523f891"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d60dcc9a-9ad1-43bf-920d-c02b6d42528a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ebfd32eb-d512-4b79-8dd7-2f7849031f3f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("18697bed-e3ad-44dc-8f45-33b8381a2a7d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("237db43c-efa3-44c7-a407-76c5e8f04e48"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("447ed388-7d85-4b11-b42b-25775378b857"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5c6fc38f-fe65-438b-949c-0a54af044b10"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("caeb4110-3752-4a75-b00b-507092a52c2c"));

            migrationBuilder.AddColumn<byte>(
                name: "Age",
                table: "AspNetUsers",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePhoto",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilePhoto",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "GameTags",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1e087a01-ad30-48c9-8015-9d3937da5f54"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(5056), false, "Survival", null },
                    { new Guid("34c39d68-3e69-4b79-9459-9e856da2aab0"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(5051), false, "War", null },
                    { new Guid("c4b3b757-d166-476f-8f3a-e5d4976a9f00"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(5054), false, "Crafting", null }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name", "PhotoPath", "Price", "ShortDesc", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("030376bf-fa43-4e5e-8579-f6a21e957f6e"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(4846), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptas aliquam aspernatur repellendus a, possimus vero at molestias voluptatibus maxime nisi!", false, "Assassin's Creed", "images/top-game-01.jpg", 50.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("06af56ea-ebbf-427b-aba0-ad7c24599c39"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(4884), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam nihil odio quos doloribus maiores, laborum minus, quibusdam distinctio consequatur!", false, "Grand Theft Auto V", "images/top-game-02.jpg", 40.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("4c28d261-9080-46cb-bcae-52eeded322fb"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(4832), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Impedit minus corrupti voluptate repudiandae assumenda illo consequuntur, quaerat animi. Quisquam, praesentium.", false, "Call of Duty", "images/cta-bg.jpg", 60.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("618e1aa0-4d54-477b-aff6-4a841dbd90c1"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(4874), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Consequuntur quam deleniti doloribus recusandae sequi, laudantium doloremque quod sit omnis.", false, "FIFA 22", "images/top-game-05.jpg", 45.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("7fbba26c-9b97-4f70-9764-f1413c60cf80"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(4881), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugiat quaerat molestiae laborum corporis, laudantium odit voluptate eligendi tempore vero!", false, "The Last of Us Part II", "images/top-game-03.jpg", 45.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("93ddba79-fd1f-413f-b368-3f36d1268183"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(4870), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque, quam exercitationem! Deserunt, obcaecati. Eaque minima tempora velit laudantium.", false, "Red Dead Redemption 2", "images/top-game-04.jpg", 55.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("9f5d890d-837a-4e7c-942c-3b996a3b7805"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(4854), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sint aliquid ab esse expedita veritatis eius quia repellendus, ipsam neque odit.", false, "The Witcher 3: Wild Hunt", "images/top-game-03.jpg", 40.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("c08b8037-936e-4223-8fbc-1bc58585862a"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(4876), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatem iusto sit quae. Nesciunt, veniam dolorum! Ad, saepe. At, ipsum.", false, "Minecraft", "images/top-game-06.jpg", 30.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("d0682606-78b3-4a62-8b8d-5276e523f891"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(4886), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Adipisci voluptas exercitationem reiciendis iure eius dolorem excepturi molestias dolorum voluptatibus.", false, "Fortnite", "images/top-game-04.jpg", 0.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("d60dcc9a-9ad1-43bf-920d-c02b6d42528a"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(4879), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Autem quis iusto, blanditiis fugit dolorem odit nisi laborum sapiente eius!", false, "Cyberpunk 2077", "images/top-game-05.jpg", 50.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null },
                    { new Guid("ebfd32eb-d512-4b79-8dd7-2f7849031f3f"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(4849), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Cupiditate quibusdam eveniet voluptatum maiores expedita eos dolore itaque, doloremque ab quae.", false, "Halo Infinite", "images/top-game-02.jpg", 70.0, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", null }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("18697bed-e3ad-44dc-8f45-33b8381a2a7d"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(5007), false, "Action", null },
                    { new Guid("237db43c-efa3-44c7-a407-76c5e8f04e48"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(5017), false, "Horror", null },
                    { new Guid("447ed388-7d85-4b11-b42b-25775378b857"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(5019), false, "Adventure", null },
                    { new Guid("5c6fc38f-fe65-438b-949c-0a54af044b10"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(5023), false, "Battle royale", null },
                    { new Guid("caeb4110-3752-4a75-b00b-507092a52c2c"), new DateTime(2024, 7, 13, 14, 30, 2, 409, DateTimeKind.Local).AddTicks(5021), false, "Simulation", null }
                });
        }
    }
}
