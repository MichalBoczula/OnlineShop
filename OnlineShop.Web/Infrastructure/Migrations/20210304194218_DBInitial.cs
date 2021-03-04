using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Web.Infrastructure.Migrations
{
    public partial class DBInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Multimedia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USBType = table.Column<string>(nullable: true),
                    Bluetooth = table.Column<bool>(nullable: false),
                    NFC = table.Column<bool>(nullable: false),
                    FingerPrintReader = table.Column<bool>(nullable: false),
                    LTE = table.Column<bool>(nullable: false),
                    GPS = table.Column<bool>(nullable: false),
                    WiFiCalling = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multimedia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                name: "MobilePhones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    MainImage = table.Column<string>(nullable: true),
                    FirstImage = table.Column<string>(nullable: true),
                    SecondImage = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ActiveStatus = table.Column<bool>(nullable: false),
                    BestSeller = table.Column<bool>(nullable: false),
                    QuantityInStack = table.Column<int>(nullable: false),
                    MultimediaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobilePhones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MobilePhones_Multimedia_MultimediaId",
                        column: x => x.MultimediaId,
                        principalTable: "Multimedia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ShoppingCardId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_ShoppingCart_ShoppingCardId",
                        column: x => x.ShoppingCardId,
                        principalTable: "ShoppingCart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Camera",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zoom = table.Column<int>(nullable: false),
                    FrontResulution = table.Column<int>(nullable: false),
                    MainResulution = table.Column<int>(nullable: false),
                    AdditionalResulution = table.Column<int>(nullable: false),
                    VideoRecorderResolution = table.Column<string>(nullable: true),
                    VideoFPS = table.Column<int>(nullable: false),
                    Functions = table.Column<string>(nullable: true),
                    MobilePhoneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camera", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Camera_MobilePhones_MobilePhoneId",
                        column: x => x.MobilePhoneId,
                        principalTable: "MobilePhones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hardware",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessorName = table.Column<string>(nullable: true),
                    OperationSystem = table.Column<string>(nullable: true),
                    GraphicsProcessor = table.Column<string>(nullable: true),
                    OperationMemory = table.Column<int>(nullable: false),
                    MemorySpace = table.Column<int>(nullable: false),
                    SimCardType = table.Column<string>(nullable: true),
                    BatteryCapacity = table.Column<int>(nullable: false),
                    MobilePhoneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hardware", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hardware_MobilePhones_MobilePhoneId",
                        column: x => x.MobilePhoneId,
                        principalTable: "MobilePhones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Screen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    ColorsQuantity = table.Column<int>(nullable: false),
                    ScreenType = table.Column<string>(nullable: true),
                    HorizontalResolution = table.Column<int>(nullable: false),
                    VerticalResolution = table.Column<int>(nullable: false),
                    MobilePhoneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Screen_MobilePhones_MobilePhoneId",
                        column: x => x.MobilePhoneId,
                        principalTable: "MobilePhones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartMobilePhones",
                columns: table => new
                {
                    ShoppingCartId = table.Column<string>(nullable: false),
                    MobilePhoneId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartMobilePhones", x => new { x.ShoppingCartId, x.MobilePhoneId });
                    table.ForeignKey(
                        name: "FK_ShoppingCartMobilePhones_MobilePhones_MobilePhoneId",
                        column: x => x.MobilePhoneId,
                        principalTable: "MobilePhones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartMobilePhones_ShoppingCart_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateTable(
                name: "ShippingAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    HouseNumber = table.Column<string>(nullable: true),
                    FlatNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShippingAddresses_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    ShippingAddressId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_ShippingAddresses_ShippingAddressId",
                        column: x => x.ShippingAddressId,
                        principalTable: "ShippingAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderMobilePhones",
                columns: table => new
                {
                    OrderId = table.Column<string>(nullable: false),
                    MobilePhoneId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderMobilePhones", x => new { x.OrderId, x.MobilePhoneId });
                    table.ForeignKey(
                        name: "FK_OrderMobilePhones_MobilePhones_MobilePhoneId",
                        column: x => x.MobilePhoneId,
                        principalTable: "MobilePhones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderMobilePhones_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Multimedia",
                columns: new[] { "Id", "Bluetooth", "FingerPrintReader", "GPS", "LTE", "NFC", "USBType", "WiFiCalling" },
                values: new object[] { 1, true, true, true, true, true, "Lighting", false });

            migrationBuilder.InsertData(
                table: "Multimedia",
                columns: new[] { "Id", "Bluetooth", "FingerPrintReader", "GPS", "LTE", "NFC", "USBType", "WiFiCalling" },
                values: new object[] { 2, true, true, true, true, true, "USB C", false });

            migrationBuilder.InsertData(
                table: "MobilePhones",
                columns: new[] { "Id", "ActiveStatus", "BestSeller", "Brand", "Description", "FirstImage", "MainImage", "MultimediaId", "Name", "Price", "QuantityInStack", "SecondImage", "ShortDescription" },
                values: new object[,]
                {
                    { 1, true, true, "Apple", "Donec sagittis molestie feugiat. Duis ac enim eu ex imperdiet hendrerit. Aenean molestie, leo sit amet dapibus gravida, metus nisl volutpat massa, in scelerisque diam ante id diam. Suspendisse semper nulla vel lectus venenatis cursus. Sed tincidunt auctor euismod. Praesent et mollis nisi, quis porta tellus. Aliquam eget arcu vel velit vestibulum ultrices eu sed nulla. Morbi augue velit, mattis sed ipsum in, molestie ultricies quam. Nam vitae malesuada nisl. Sed tempor dui in ullamcorper facilisis. Nam nec nulla sit amet ligula finibus aliquet. Aenean ante lacus, venenatis cursus eros ut, efficitur mollis nisl.", "/Apple/iPhone 12/First.png", "/Apple/iPhone 12/Main.png", 1, "iPhone 12", 3000.0, 0, "/Apple/iPhone 12/Second.png", "Donec sagittis molestie feugiat. Duis ac enim eu ex imperdiet hendrerit. Aenean molestie, leo sit amet dapibus gravida, metus nisl volutpat massa, in scelerisque diam ante id diam." },
                    { 28, true, false, "Samsung", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Samsung/Galaxy Xcover 4/First.png", "/Samsung/Galaxy Xcover 4/Main.png", 2, "Galaxy Xcover 4", 1000.0, 0, "/Samsung/Galaxy Xcover 4/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 27, true, false, "Oppo", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/OPPO/A53/First.png", "/OPPO/A53/Main.png", 2, "A53", 1000.0, 0, "/OPPO/A53/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 26, true, false, "Oppo", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/OPPO/Reno4 Lite/First.png", "/OPPO/Reno4 Lite/Main.png", 2, "Reno4 Lite", 1600.0, 0, "/OPPO/Reno4 Lite/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 25, true, false, "Oppo", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Oppo/Reno4 Pro/First.png", "/Oppo/Reno4 Pro/Main.png", 2, "Reno4 Pro", 3300.0, 0, "/Oppo/Reno4 Pro/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 21, true, false, "Nokia", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Nokia/7.2/First.png", "/Nokia/7.2/Main.png", 2, "7.2", 1000.0, 0, "/Nokia/7.2/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 22, true, false, "Nokia", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Nokia/7.2/First.png", "/Nokia/7.2/Main.png", 2, "8.3", 2700.0, 0, "/Nokia/7.2/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 20, true, false, "Motorola ", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Motorola/Moto G/First.png", "/Motorola/Moto G/Main.png", 2, "Moto G", 1700.0, 0, "/Motorola/Moto G/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 19, true, false, "Motorola ", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Motorola/Edge/First.png", "/Motorola/Edge/Main.png", 2, "Edge", 2700.0, 0, "/Motorola/Edge/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 18, true, false, "Motorola ", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Motorola/Razr/First.png", "/Motorola/Razr/Main.png", 2, "Razr", 6500.0, 0, "/Motorola/Razr/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 17, true, false, "Xiaomi", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Xiaomi/Redmi Note 9/First.png", "/Xiaomi/Redmi Note 9/Main.png", 2, "Redmi Note 9", 700.0, 0, "/Xiaomi/Redmi Note 9/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 16, true, false, "Xiaomi", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Xiaomi/Mi 10T Pro/First.png", "/Xiaomi/Mi 10T Pro/Main.png", 2, "10T Pro", 2600.0, 0, "/Xiaomi/Mi 10T Pro/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 15, true, false, "Xiaomi", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Xiaomi/Mi 10T Lite/First.png", "/Xiaomi/Mi 10T Lite/Main.png", 2, "10T Lite", 1500.0, 0, "/Xiaomi/Mi 10T Lite/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 14, true, false, "Sony", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Sony/Xperia 10/First.png", "/Sony/Xperia 10/Main.png", 2, "Xperia 10", 1800.0, 0, "/Sony/Xperia 10/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 13, true, false, "Sony", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Sony/Xperia L4/First.png", "/Sony/Xperia L4/Main.png", 2, "Xperia L4", 1000.0, 0, "/Sony/Xperia L4/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 12, true, false, "Huawei", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Huawei/Mate 40 Pro/First.png", "/Huawei/Mate 40 Pro/Main.png", 2, "Mate 40 Pro", 5400.0, 0, "/Huawei/Mate 40 Pro/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 11, true, false, "Huawei", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Huawei/Mate XS/First.png", "/Huawei/Mate XS/Main.png", 2, "Mate XS", 10000.0, 0, "/Huawei/Mate XS/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 10, true, false, "Samsung", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Samsung/Galaxy A51/First.png", "/Samsung/Galaxy A51/Main.png", 2, "Galaxy A51", 1700.0, 0, "/Samsung/Galaxy A51/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 9, true, false, "Samsung", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Samsung/Galaxy S21/First.png", "/Samsung/Galaxy S21/Main.png", 2, "Galaxy S21", 3900.0, 0, "/Samsung/Galaxy S21/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 8, true, false, "Samsung", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Samsung/Galaxy Z Flip/First.png", "/Samsung/Galaxy Z Flip/Main.png", 2, "Galaxy Z Flip 5G", 6800.0, 0, "/Samsung/Galaxy Z Flip/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 7, true, true, "Samsung", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Samsung/Galaxy Z Fold2/First.png", "/Samsung/Galaxy Z Fold2/Main.png", 2, "Galaxy Z Fold2 5G", 8800.0, 0, "/Samsung/Galaxy Z Fold2/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 6, true, false, "LG", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum. Aenean eget eros faucibus, egestas nisi vel, lobortis mauris. Quisque luctus risus quam, nec bibendum sapien imperdiet ut. Nulla iaculis mauris leo, a finibus leo varius sed. Aenean tristique orci vel convallis luctus. Aenean a enim ac nulla congue aliquam. Vestibulum lobortis turpis sit amet augue vestibulum tincidunt. Proin nec libero scelerisque, efficitur libero sed, interdum augue. Suspendisse condimentum accumsan condimentum. Suspendisse vitae pellentesque ante.", "/LG/K61/First.png", "/LG/K61/Main.png", 2, "K61", 1000.0, 0, "/LG/K61/Second.png", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum." },
                    { 5, true, false, "LG", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum. Aenean eget eros faucibus, egestas nisi vel, lobortis mauris. Quisque luctus risus quam, nec bibendum sapien imperdiet ut. Nulla iaculis mauris leo, a finibus leo varius sed. Aenean tristique orci vel convallis luctus. Aenean a enim ac nulla congue aliquam. Vestibulum lobortis turpis sit amet augue vestibulum tincidunt. Proin nec libero scelerisque, efficitur libero sed, interdum augue. Suspendisse condimentum accumsan condimentum. Suspendisse vitae pellentesque ante.", "/LG/Velvet/First.png", "/LG/Velvet/Main.png", 2, "Velvet", 2300.0, 0, "/LG/Velvet/Second.png", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum." },
                    { 4, true, true, "LG", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum. Aenean eget eros faucibus, egestas nisi vel, lobortis mauris. Quisque luctus risus quam, nec bibendum sapien imperdiet ut. Nulla iaculis mauris leo, a finibus leo varius sed. Aenean tristique orci vel convallis luctus. Aenean a enim ac nulla congue aliquam. Vestibulum lobortis turpis sit amet augue vestibulum tincidunt. Proin nec libero scelerisque, efficitur libero sed, interdum augue. Suspendisse condimentum accumsan condimentum. Suspendisse vitae pellentesque ante.", "/LG/Wing/First.png", "/LG/Wing/Main.png", 2, "Wing 5G", 4500.0, 0, "/LG/Wing/Second.png", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum." },
                    { 24, true, false, "Apple", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Apple/iPhone SE/First.png", "/Apple/iPhone SE/Main.png", 1, "iPhone SE", 2100.0, 0, "/Apple/iPhone SE/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 23, true, false, "Apple", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Apple/iPhone 11/First.png", "/Apple/iPhone 11/Main.png", 1, "iPhone 11", 3100.0, 0, "/Apple/iPhone 11/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 3, true, false, "Apple", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum. Aenean eget eros faucibus, egestas nisi vel, lobortis mauris. Quisque luctus risus quam, nec bibendum sapien imperdiet ut. Nulla iaculis mauris leo, a finibus leo varius sed. Aenean tristique orci vel convallis luctus. Aenean a enim ac nulla congue aliquam. Vestibulum lobortis turpis sit amet augue vestibulum tincidunt. Proin nec libero scelerisque, efficitur libero sed, interdum augue. Suspendisse condimentum accumsan condimentum. Suspendisse vitae pellentesque ante.", "/Apple/iPhone 12 Mini/First.png", "/Apple/iPhone 12 Mini/Main.png", 1, "12 Mini", 3600.0, 0, "/Apple/iPhone 12 Mini/Second.png", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum." },
                    { 2, true, false, "Apple", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum. Aenean eget eros faucibus, egestas nisi vel, lobortis mauris. Quisque luctus risus quam, nec bibendum sapien imperdiet ut. Nulla iaculis mauris leo, a finibus leo varius sed. Aenean tristique orci vel convallis luctus. Aenean a enim ac nulla congue aliquam. Vestibulum lobortis turpis sit amet augue vestibulum tincidunt. Proin nec libero scelerisque, efficitur libero sed, interdum augue. Suspendisse condimentum accumsan condimentum. Suspendisse vitae pellentesque ante.", "/Apple/iPhone 12 Pro/First.png", "/Apple/iPhone 12 Pro/Main.png", 1, "12 Pro", 5200.0, 0, "/Apple/iPhone 12 Pro/Second.png", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum." },
                    { 29, true, false, "Samsung", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Samsung/Galaxy A71/First.png", "/Samsung/Galaxy A71/Main.png", 2, "Galaxy A71", 1900.0, 0, "/Samsung/Galaxy A71/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 30, true, false, "LG", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/LG/K52/First.png", "/LG/K52/Main.png", 2, "K52", 1000.0, 0, "/Lg/K52/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." }
                });

            migrationBuilder.InsertData(
                table: "Camera",
                columns: new[] { "Id", "AdditionalResulution", "FrontResulution", "Functions", "MainResulution", "MobilePhoneId", "VideoFPS", "VideoRecorderResolution", "Zoom" },
                values: new object[,]
                {
                    { 1, 16, 16, "Video Recorder;Autofokus;Flash", 32, 1, 120, "4K", 8 },
                    { 7, 12, 12, "Video Recorder;Autofokus;Flash", 12, 7, 60, "4K", 2 },
                    { 8, 12, 10, "Video Recorder;Autofokus;Flash;HDR;Dynamic Photo", 12, 8, 60, "4K", 8 },
                    { 27, 2, 8, "Video Recorder;Autofokus;Flash", 13, 27, 30, "HD", 2 },
                    { 9, 12, 12, "Video Recorder;Autofokus;Flash;HDR;Dynamic Photo", 64, 9, 120, "4K", 30 },
                    { 11, 8, 40, "Video Recorder;Autofokus; Flash;HDR;Deep Photo", 40, 11, 120, "4K", 30 },
                    { 26, 8, 16, "Video Recorder;Autofokus;Flash;Night mode", 48, 26, 60, "HD", 4 },
                    { 12, 20, 13, "Video Recorder;Autofokus;Flash;HDR:Deep Photo 3D", 50, 12, 120, "4K", 10 },
                    { 13, 5, 8, "Video Recorder;Autofokus;Flash", 13, 13, 120, "HD", 2 },
                    { 14, 8, 8, "Video Recorder;Autofokus;Flash", 12, 14, 120, "HD", 4 },
                    { 15, 8, 16, "Video Recorder;Autofokus;Flash;Ultra-wide;Deep view", 64, 15, 30, "4K", 10 },
                    { 25, 12, 32, "Video Recorder;Autofokus;Flash;Night mode", 48, 25, 30, "4K", 10 },
                    { 16, 13, 20, "Video Recorder;Autofokus;Flash;Ultra-wide;Deep view;HMX", 108, 16, 120, "4K", 10 },
                    { 17, 8, 13, "Video Recorder;Autofokus;Flash", 48, 17, 60, "2K", 2 },
                    { 18, 0, 20, "Video Recorder;Autofokus;Flash;Portrait;Live filtr;In motion;Night mode", 48, 18, 30, "4K", 8 },
                    { 21, 8, 20, "Video Recorder;Autofokus;Flash", 48, 21, 60, "HD", 2 },
                    { 19, 16, 25, "Video Recorder;Autofokus:Flash;Portrait;In motion;Night mode", 64, 19, 30, "4K", 4 },
                    { 20, 8, 16, "Video Recorder;Autofokus;Flash;Portrait;Night mode", 48, 20, 60, "HD", 2 },
                    { 6, 8, 16, "Video Recorder;Autofokus;Flash;Night Mode;HDR", 48, 6, 120, "4K", 2 },
                    { 28, 0, 5, "Video Recorder;Autofokus;Flash", 16, 28, 30, "HD", 2 },
                    { 10, 12, 32, "Video Recorder;Autofokus;Flash;HDR;Dynamic Photo", 48, 10, 30, "4K", 2 },
                    { 5, 8, 16, "Video Recorder;Autofokus;Flash;Night Mode;AI CAM;AR Stickers", 48, 5, 120, "4K", 2 },
                    { 30, 5, 13, "Video Recorder;Autofokus;Flash;Google Lens", 48, 30, 30, "HD", 2 },
                    { 2, 12, 12, "Video Recorder;Autofokus;Flash;HDR;Dolby Vision;Night Mode;Deep Fusion", 12, 2, 120, "4K", 10 },
                    { 3, 12, 12, "Video Recorder;Autofokus;Flash;HDR;Dolby Vision;Night Mode;Deep Fusion", 12, 3, 120, "4K", 10 },
                    { 23, 12, 12, "Video Recorder;Autofokus;Flash;Night mode;Deep photo;Portrait", 12, 23, 60, "HD", 4 },
                    { 29, 12, 32, "Video Recorder;Autofokus;Flash", 64, 29, 30, "4K", 4 },
                    { 24, 5, 7, "Video Recorder;Autofokus;Flash;Night mode", 12, 24, 30, "HD", 2 },
                    { 4, 12, 32, "Video Recorder;Autofokus;Flash;Night Mode;Gimbal;AI CAM;AR Stickers", 64, 4, 120, "4K", 2 },
                    { 22, 12, 24, "Video Recorder;Autofokus;Flash;Night mode;Deep photo;Live colors", 64, 22, 60, "4K", 8 }
                });

            migrationBuilder.InsertData(
                table: "Hardware",
                columns: new[] { "Id", "BatteryCapacity", "GraphicsProcessor", "MemorySpace", "MobilePhoneId", "OperationMemory", "OperationSystem", "ProcessorName", "SimCardType" },
                values: new object[,]
                {
                    { 29, 4500, "Adreno 618", 128, 29, 6, "Android", "Qualcomm Snapdragon 730", "Nano" },
                    { 20, 5000, "Adreno 620", 128, 20, 6, "Android", "Qualcomm Snapdragon 765", "Nano" },
                    { 1, 2500, "A14 Bionic", 64, 1, 4, "iOS", "A14 Bionic", "Nano" },
                    { 19, 5000, "Adreno 620", 128, 19, 6, "Android", "Qualcomm Snapdragon 765", "Nano" },
                    { 6, 4000, "IMG GE8320 680MHz", 128, 6, 4, "Android", "MediaTek Helio P35", "Nano" },
                    { 18, 2800, "Adreno 620", 256, 18, 8, "Android", "Qualcomm Snapdragon 765", "Nano" },
                    { 2, 2775, "A14 Bionic", 128, 2, 6, "iOS", "A14 Bionic", "Nano" },
                    { 21, 3500, "Adreno 512", 64, 21, 4, "Android", "Qualcomm Snapdragon 660", "Nano" },
                    { 17, 5020, "ARM G52 MC2", 128, 17, 4, "Android", "MediaTek Helio G85", "Nano" },
                    { 16, 5000, "Adreno 650", 256, 16, 8, "Android", "Qualcomm Snapdragon 865", "Nano" },
                    { 28, 2800, "Mali-G71 MP2", 32, 28, 3, "Android", "Exynos", "Nano" },
                    { 3, 2775, "A14 Bionic", 64, 3, 4, "iOS", "A14 Bionic", "Nano" },
                    { 15, 4820, "Adreno™ GPU 619", 64, 15, 6, "Android", "Qualcomm Snapdragon 750G", "Nano" },
                    { 8, 3300, "Adreno 650", 256, 8, 8, "Android", "Snapdragon 865+", "Nano" },
                    { 25, 4000, "Adreno 620", 256, 25, 12, "Android", "Qualcomm Snapdragon 765 5G", "Nano" },
                    { 14, 3600, "Adreno 610", 128, 14, 4, "Android", "Qualcomm Snapdragon 665", "Nano" },
                    { 13, 3580, "IMG GE8320", 64, 13, 3, "Android", "MediaTek MT6762", "Nano" },
                    { 30, 4000, "IMG GE8320 680MHz", 64, 30, 4, "Android", "Helio P35 MT6765", "Nano" },
                    { 9, 4000, "Mali G78 MP14", 256, 9, 8, "Android", "Exynos", "Nano" },
                    { 22, 4500, "Adreno 620", 128, 22, 8, "Android", "Qualcomm Snapdragon 765G", "Nano" },
                    { 10, 4000, "Mali G72 MP3", 128, 10, 4, "Android", "Exynos 9611", "Nano" },
                    { 26, 4000, "PowerVR GM9446", 128, 26, 8, "Android", "MediaTek Helio P95", "Nano" },
                    { 24, 1821, "A13 Bionic", 64, 24, 4, "iOS", "A13 Bionic", "Nano" },
                    { 7, 4500, "Adreno 650", 256, 7, 12, "Android", "Qualcomm", "Nano" },
                    { 4, 4000, "Adreno 620 GPU", 128, 4, 8, "Android", "Qualcomm Snapdragon 765G", "Nano" },
                    { 11, 4500, "Kirin 990 5G", 512, 11, 8, "Android", "Kirin 990 5G", "Nano" },
                    { 27, 5000, "Adreno 610", 128, 27, 4, "Android", "Qualcomm Snapdragon 460", "Nano" },
                    { 12, 4500, "Kirin 9000", 256, 12, 8, "Android", "Kirin 9000", "Nano" },
                    { 23, 3110, "A13 Bionic", 64, 23, 6, "iOS", "A13 Bionic", "Nano" },
                    { 5, 4300, "Adreno 620 GPU", 128, 5, 6, "Android", "Qualcomm Snapdragon 765G", "Nano" }
                });

            migrationBuilder.InsertData(
                table: "Screen",
                columns: new[] { "Id", "ColorsQuantity", "HorizontalResolution", "MobilePhoneId", "ScreenType", "Size", "VerticalResolution" },
                values: new object[,]
                {
                    { 21, 16, 2340, 21, "IPS TFT", 6.3m, 1080 },
                    { 27, 16, 1600, 27, "LCD", 6.5m, 720 },
                    { 25, 16, 2400, 25, "AMOLED HDR10+", 6.5m, 1080 },
                    { 22, 16, 2400, 22, "FHD+ LCD with PureDisplay", 6.8m, 1080 },
                    { 26, 16, 2400, 26, "AMOLED", 6.4m, 1080 },
                    { 29, 16, 2400, 29, "FHD+ Super AMOLED", 6.7m, 1080 },
                    { 28, 16, 1280, 28, "PLS TFT LCD", 5.0m, 720 },
                    { 13, 16, 1680, 13, "TFT LCD", 6.2m, 720 },
                    { 19, 16, 2340, 19, "FHD+ OLED", 6.7m, 1080 },
                    { 1, 16, 2532, 1, "OLED Super Retina XDR", 6.1m, 1170 },
                    { 2, 16, 2532, 2, "Super Retina XDR", 6.1m, 1170 },
                    { 3, 16, 2340, 3, "Super Retina XDR", 5.4m, 1080 },
                    { 23, 16, 1792, 23, "Liquid Retina HD", 6.1m, 828 },
                    { 24, 16, 1334, 24, "Retina HD IPS", 4.7m, 750 },
                    { 4, 16, 2460, 4, "FHD+ P-OLED FullVision", 6.8m, 1080 },
                    { 5, 16, 2460, 5, "FHD+ OLED FullVision", 6.8m, 1080 },
                    { 6, 16, 2340, 6, "FHD+ IPS", 6.5m, 1080 },
                    { 7, 16, 2208, 7, "Dynamic AMOLED 2X", 6.1m, 1768 },
                    { 8, 16, 2636, 8, "Dynamic AMOLED & Super AMOLED", 6.7m, 1080 },
                    { 9, 16, 2400, 9, "Dynamic AMOLED 2X, 120Hz, HDR10+", 6.2m, 1080 },
                    { 10, 16, 2400, 10, "FHD+ Super AMOLED", 6.5m, 1080 },
                    { 11, 16, 2480, 11, "OLED", 6.6m, 1148 },
                    { 12, 16, 2772, 12, "FHD+ OLED", 6.8m, 1344 },
                    { 14, 16, 2520, 14, "OLED", 6.0m, 1080 },
                    { 15, 16, 2400, 15, "FHD+ DotDisplay 120 Hz IPS", 6.7m, 1080 },
                    { 16, 16, 2440, 16, "FHD+ DotDisplay 144Hz IPS", 6.7m, 1080 },
                    { 17, 16, 2340, 17, "FHD+ AMOLED", 6.7m, 1080 },
                    { 18, 16, 2142, 18, "pOLED", 6.2m, 876 },
                    { 20, 16, 2520, 20, "FHD+ IPS CinemaVision", 6.7m, 1080 },
                    { 30, 16, 1600, 30, "HD+, ISP-LCD", 6.6m, 720 }
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ShoppingCardId",
                table: "AspNetUsers",
                column: "ShoppingCardId",
                unique: true,
                filter: "[ShoppingCardId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Camera_MobilePhoneId",
                table: "Camera",
                column: "MobilePhoneId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hardware_MobilePhoneId",
                table: "Hardware",
                column: "MobilePhoneId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MobilePhones_MultimediaId",
                table: "MobilePhones",
                column: "MultimediaId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderMobilePhones_MobilePhoneId",
                table: "OrderMobilePhones",
                column: "MobilePhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShippingAddressId",
                table: "Orders",
                column: "ShippingAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Screen_MobilePhoneId",
                table: "Screen",
                column: "MobilePhoneId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShippingAddresses_ApplicationUserId",
                table: "ShippingAddresses",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartMobilePhones_MobilePhoneId",
                table: "ShoppingCartMobilePhones",
                column: "MobilePhoneId");
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
                name: "Camera");

            migrationBuilder.DropTable(
                name: "Hardware");

            migrationBuilder.DropTable(
                name: "OrderMobilePhones");

            migrationBuilder.DropTable(
                name: "Screen");

            migrationBuilder.DropTable(
                name: "ShoppingCartMobilePhones");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "MobilePhones");

            migrationBuilder.DropTable(
                name: "ShippingAddresses");

            migrationBuilder.DropTable(
                name: "Multimedia");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ShoppingCart");
        }
    }
}
