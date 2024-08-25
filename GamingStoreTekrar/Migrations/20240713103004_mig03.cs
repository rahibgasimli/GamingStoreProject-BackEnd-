using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamingStoreTekrar.Migrations
{
    public partial class mig03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
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
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
    }
}
