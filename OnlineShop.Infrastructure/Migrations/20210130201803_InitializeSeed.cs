using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Infrastructure.Migrations
{
    public partial class InitializeSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BatteryCapacity",
                table: "Hardwares",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.InsertData(
                table: "MobilePhones",
                columns: new[] { "Id", "ActiveStatus", "BestSeller", "Brand", "Description", "FirstImage", "MainImage", "MultimediaId", "Name", "Price", "QuantityInStack", "SecondImage", "ShortDescription" },
                values: new object[,]
                {
                    { 1, true, true, "Apple", "Donec sagittis molestie feugiat. Duis ac enim eu ex imperdiet hendrerit. Aenean molestie, leo sit amet dapibus gravida, metus nisl volutpat massa, in scelerisque diam ante id diam. Suspendisse semper nulla vel lectus venenatis cursus. Sed tincidunt auctor euismod. Praesent et mollis nisi, quis porta tellus. Aliquam eget arcu vel velit vestibulum ultrices eu sed nulla. Morbi augue velit, mattis sed ipsum in, molestie ultricies quam. Nam vitae malesuada nisl. Sed tempor dui in ullamcorper facilisis. Nam nec nulla sit amet ligula finibus aliquet. Aenean ante lacus, venenatis cursus eros ut, efficitur mollis nisl.", "/Apple/iPhone 12/First.png", "/Apple/iPhone 12/Main.png", null, "iPhone 12", 3000.0, 0, "/Apple/iPhone 12/Second.png", "Donec sagittis molestie feugiat. Duis ac enim eu ex imperdiet hendrerit. Aenean molestie, leo sit amet dapibus gravida, metus nisl volutpat massa, in scelerisque diam ante id diam." },
                    { 30, true, false, "LG", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/LG/K52/First.png", "/LG/K52/Main.png", null, "K52", 1000.0, 0, "/Lg/K52/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 29, true, false, "Samsung", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Samsung/Galaxy A71/First.png", "/Samsung/Galaxy A71/Main.png", null, "Galaxy A71", 1900.0, 0, "/Samsung/Galaxy A71/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 28, true, false, "Samsung", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Samsung/Galaxy Xcover 4/First.png", "/Samsung/Galaxy Xcover 4/Main.png", null, "Galaxy Xcover 4", 1000.0, 0, "/Samsung/Galaxy Xcover 4/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 27, true, false, "Oppo", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/OPPO/A53/First.png", "/OPPO/A53/Main.png", null, "A53", 1000.0, 0, "/OPPO/A53/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 26, true, false, "Oppo", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/OPPO/Reno4 Lite/First.png", "/OPPO/Reno4 Lite/Main.png", null, "Reno4 Lite", 1600.0, 0, "/OPPO/Reno4 Lite/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 25, true, false, "Oppo", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Oppo/Reno4 Pro/First.png", "/Oppo/Reno4 Pro/Main.png", null, "Reno4 Pro", 3300.0, 0, "/Oppo/Reno4 Pro/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 24, true, false, "Apple", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Apple/iPhone SE/First.png", "/Apple/iPhone SE/Main.png", null, "iPhone SE", 2100.0, 0, "/Apple/iPhone SE/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 23, true, false, "Apple", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Apple/iPhone 11/First.png", "/Apple/iPhone 11/Main.png", null, "iPhone 11", 3100.0, 0, "/Apple/iPhone 11/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 21, true, false, "Nokia", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Nokia/7.2/First.png", "/Nokia/7.2/Main.png", null, "7.2", 1000.0, 0, "/Nokia/7.2/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 22, true, false, "Nokia", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Nokia/7.2/First.png", "/Nokia/7.2/Main.png", null, "8.3", 2700.0, 0, "/Nokia/7.2/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 20, true, false, "Motorola ", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Motorola/Moto G/First.png", "/Motorola/Moto G/Main.png", null, "Moto G", 1700.0, 0, "/Motorola/Moto G/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 19, true, false, "Motorola ", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Motorola/Edge/First.png", "/Motorola/Edge/Main.png", null, "Edge", 2700.0, 0, "/Motorola/Edge/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 18, true, false, "Motorola ", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Motorola/Razr/First.png", "/Motorola/Razr/Main.png", null, "Razr", 6500.0, 0, "/Motorola/Razr/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 17, true, false, "Xiaomi", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Xiaomi/Redmi Note 9/First.png", "/Xiaomi/Redmi Note 9/Main.png", null, "Redmi Note 9", 700.0, 0, "/Xiaomi/Redmi Note 9/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 16, true, false, "Xiaomi", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Xiaomi/Mi 10T Pro/First.png", "/Xiaomi/Mi 10T Pro/Main.png", null, "10T Pro", 2600.0, 0, "/Xiaomi/Mi 10T Pro/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 15, true, false, "Xiaomi", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Xiaomi/Mi 10T Lite/First.png", "/Xiaomi/Mi 10T Lite/Main.png", null, "10T Lite", 1500.0, 0, "/Xiaomi/Mi 10T Lite/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 14, true, false, "Sony", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Sony/Xperia 10/First.png", "/Sony/Xperia 10/Main.png", null, "Xperia 10", 1800.0, 0, "/Sony/Xperia 10/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 13, true, false, "Sony", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Sony/Xperia L4/First.png", "/Sony/Xperia L4/Main.png", null, "Xperia L4", 1000.0, 0, "/Sony/Xperia L4/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 12, true, false, "Huawei", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Huawei/Mate 40 Pro/First.png", "/Huawei/Mate 40 Pro/Main.png", null, "Mate 40 Pro", 5400.0, 0, "/Huawei/Mate 40 Pro/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 11, true, false, "Huawei", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Huawei/Mate XS/First.png", "/Huawei/Mate XS/Main.png", null, "Mate XS", 10000.0, 0, "/Huawei/Mate XS/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 10, true, false, "Samsung", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Samsung/Galaxy A51/First.png", "/Samsung/Galaxy A51/Main.png", null, "Galaxy A51", 1700.0, 0, "/Samsung/Galaxy A51/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 9, true, false, "Samsung", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Samsung/Galaxy S21/First.png", "/Samsung/Galaxy S21/Main.png", null, "Galaxy S21", 3900.0, 0, "/Samsung/Galaxy S21/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 8, true, false, "Samsung", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Samsung/Galaxy Z Flip/First.png", "/Samsung/Galaxy Z Flip/Main.png", null, "Galaxy Z Flip 5G", 6800.0, 0, "/Samsung/Galaxy Z Flip/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 7, true, true, "Samsung", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut. Phasellus vehicula sed risus vitae aliquet. Sed neque metus, sollicitudin blandit venenatis hendrerit, pulvinar at diam. Fusce blandit eu arcu vitae aliquet. Donec placerat at felis in convallis. Nam tristique neque sed dolor pharetra, sed vestibulum nulla varius. Phasellus non diam nunc. Cras dignissim scelerisque tortor, vel sodales massa ornare sed. Pellentesque consectetur nisl eros, nec lobortis sem interdum sit amet.", "/Samsung/Galaxy Z Fold2/First.png", "/Samsung/Galaxy Z Fold2/Main.png", null, "Galaxy Z Fold2 5G", 8800.0, 0, "/Samsung/Galaxy Z Fold2/Second.png", "Nunc eget sapien quis eros semper tincidunt. Proin rhoncus blandit diam, a vulputate augue tristique ut. Vivamus tincidunt ligula purus, vel pellentesque nunc lacinia ut." },
                    { 6, true, false, "LG", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum. Aenean eget eros faucibus, egestas nisi vel, lobortis mauris. Quisque luctus risus quam, nec bibendum sapien imperdiet ut. Nulla iaculis mauris leo, a finibus leo varius sed. Aenean tristique orci vel convallis luctus. Aenean a enim ac nulla congue aliquam. Vestibulum lobortis turpis sit amet augue vestibulum tincidunt. Proin nec libero scelerisque, efficitur libero sed, interdum augue. Suspendisse condimentum accumsan condimentum. Suspendisse vitae pellentesque ante.", "/LG/K61/First.png", "/LG/K61/Main.png", null, "K61", 1000.0, 0, "/LG/K61/Second.png", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum." },
                    { 5, true, false, "LG", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum. Aenean eget eros faucibus, egestas nisi vel, lobortis mauris. Quisque luctus risus quam, nec bibendum sapien imperdiet ut. Nulla iaculis mauris leo, a finibus leo varius sed. Aenean tristique orci vel convallis luctus. Aenean a enim ac nulla congue aliquam. Vestibulum lobortis turpis sit amet augue vestibulum tincidunt. Proin nec libero scelerisque, efficitur libero sed, interdum augue. Suspendisse condimentum accumsan condimentum. Suspendisse vitae pellentesque ante.", "/LG/Velvet/First.png", "/LG/Velvet/Main.png", null, "Velvet", 2300.0, 0, "/LG/Velvet/Second.png", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum." },
                    { 4, true, true, "LG", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum. Aenean eget eros faucibus, egestas nisi vel, lobortis mauris. Quisque luctus risus quam, nec bibendum sapien imperdiet ut. Nulla iaculis mauris leo, a finibus leo varius sed. Aenean tristique orci vel convallis luctus. Aenean a enim ac nulla congue aliquam. Vestibulum lobortis turpis sit amet augue vestibulum tincidunt. Proin nec libero scelerisque, efficitur libero sed, interdum augue. Suspendisse condimentum accumsan condimentum. Suspendisse vitae pellentesque ante.", "/LG/Wing/First.png", "/LG/Wing/Main.png", null, "Wing 5G", 4500.0, 0, "/LG/Wing/Second.png", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum." },
                    { 3, true, false, "Apple", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum. Aenean eget eros faucibus, egestas nisi vel, lobortis mauris. Quisque luctus risus quam, nec bibendum sapien imperdiet ut. Nulla iaculis mauris leo, a finibus leo varius sed. Aenean tristique orci vel convallis luctus. Aenean a enim ac nulla congue aliquam. Vestibulum lobortis turpis sit amet augue vestibulum tincidunt. Proin nec libero scelerisque, efficitur libero sed, interdum augue. Suspendisse condimentum accumsan condimentum. Suspendisse vitae pellentesque ante.", "/Apple/iPhone 12 Mini/First.png", "/Apple/iPhone 12 Mini/Main.png", null, "12 Mini", 3600.0, 0, "/Apple/iPhone 12 Mini/Second.png", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum." },
                    { 2, true, false, "Apple", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum. Aenean eget eros faucibus, egestas nisi vel, lobortis mauris. Quisque luctus risus quam, nec bibendum sapien imperdiet ut. Nulla iaculis mauris leo, a finibus leo varius sed. Aenean tristique orci vel convallis luctus. Aenean a enim ac nulla congue aliquam. Vestibulum lobortis turpis sit amet augue vestibulum tincidunt. Proin nec libero scelerisque, efficitur libero sed, interdum augue. Suspendisse condimentum accumsan condimentum. Suspendisse vitae pellentesque ante.", "/Apple/iPhone 12 Pro/First.png", "/Apple/iPhone 12 Pro/Main.png", null, "12 Pro", 5200.0, 0, "/Apple/iPhone 12 Pro/Second.png", "Sed eget dui vitae est ultricies aliquet sit amet sed lectus. Morbi sit amet pellentesque quam. Nulla viverra commodo tortor ac dictum. Morbi nec sapien nec velit ullamcorper dictum." }
                });

            migrationBuilder.InsertData(
                table: "Multimedia",
                columns: new[] { "Id", "Bluetooth", "FingerPrintReader", "GPS", "LTE", "NFC", "USBType", "WiFiCalling" },
                values: new object[,]
                {
                    { 1, true, true, true, true, true, "Lighting", false },
                    { 2, true, true, true, true, true, "USB C", false }
                });

            migrationBuilder.InsertData(
                table: "Cameras",
                columns: new[] { "Id", "AdditionalResulution", "FrontResulution", "Functions", "MainResulution", "MobilePhoneId", "VideoFPS", "VideoRecorderResolution", "Zoom" },
                values: new object[,]
                {
                    { 1, 16, 16, "Video Recorder;Autofokus;Flash", 32, 1, 120, "4K", 8 },
                    { 9, 12, 12, "Video Recorder;Autofokus;Flash;HDR;Dynamic Photo", 64, 9, 120, "4K", 30 },
                    { 10, 12, 32, "Video Recorder;Autofokus;Flash;HDR;Dynamic Photo", 48, 10, 30, "4K", 2 },
                    { 27, 2, 8, "Video Recorder;Autofokus;Flash", 13, 27, 30, "HD", 2 },
                    { 11, 8, 40, "Video Recorder;Autofokus; Flash;HDR;Deep Photo", 40, 11, 120, "4K", 30 },
                    { 13, 5, 8, "Video Recorder;Autofokus;Flash", 13, 13, 120, "HD", 2 },
                    { 26, 8, 16, "Video Recorder;Autofokus;Flash;Night mode", 48, 26, 60, "HD", 4 },
                    { 14, 8, 8, "Video Recorder;Autofokus;Flash", 12, 14, 120, "HD", 4 },
                    { 15, 8, 16, "Video Recorder;Autofokus;Flash;Ultra-wide;Deep view", 64, 15, 30, "4K", 10 },
                    { 16, 13, 20, "Video Recorder;Autofokus;Flash;Ultra-wide;Deep view;HMX", 108, 16, 120, "4K", 10 },
                    { 17, 8, 13, "Video Recorder;Autofokus;Flash", 48, 17, 60, "2K", 2 },
                    { 25, 12, 32, "Video Recorder;Autofokus;Flash;Night mode", 48, 25, 30, "4K", 10 },
                    { 18, 0, 20, "Video Recorder;Autofokus;Flash;Portrait;Live filtr;In motion;Night mode", 48, 18, 30, "4K", 8 },
                    { 19, 16, 25, "Video Recorder;Autofokus:Flash;Portrait;In motion;Night mode", 64, 19, 30, "4K", 4 },
                    { 20, 8, 16, "Video Recorder;Autofokus;Flash;Portrait;Night mode", 48, 20, 60, "HD", 2 },
                    { 24, 5, 7, "Video Recorder;Autofokus;Flash;Night mode", 12, 24, 30, "HD", 2 },
                    { 22, 12, 24, "Video Recorder;Autofokus;Flash;Night mode;Deep photo;Live colors", 64, 22, 60, "4K", 8 },
                    { 21, 8, 20, "Video Recorder;Autofokus;Flash", 48, 21, 60, "HD", 2 },
                    { 8, 12, 10, "Video Recorder;Autofokus;Flash;HDR;Dynamic Photo", 12, 8, 60, "4K", 8 },
                    { 28, 0, 5, "Video Recorder;Autofokus;Flash", 16, 28, 30, "HD", 2 },
                    { 12, 20, 13, "Video Recorder;Autofokus;Flash;HDR:Deep Photo 3D", 50, 12, 120, "4K", 10 },
                    { 7, 12, 12, "Video Recorder;Autofokus;Flash", 12, 7, 60, "4K", 2 },
                    { 30, 5, 13, "Video Recorder;Autofokus;Flash;Google Lens", 48, 30, 30, "HD", 2 },
                    { 2, 12, 12, "Video Recorder;Autofokus;Flash;HDR;Dolby Vision;Night Mode;Deep Fusion", 12, 2, 120, "4K", 10 },
                    { 3, 12, 12, "Video Recorder;Autofokus;Flash;HDR;Dolby Vision;Night Mode;Deep Fusion", 12, 3, 120, "4K", 10 },
                    { 4, 12, 32, "Video Recorder;Autofokus;Flash;Night Mode;Gimbal;AI CAM;AR Stickers", 64, 4, 120, "4K", 2 },
                    { 29, 12, 32, "Video Recorder;Autofokus;Flash", 64, 29, 30, "4K", 4 },
                    { 5, 8, 16, "Video Recorder;Autofokus;Flash;Night Mode;AI CAM;AR Stickers", 48, 5, 120, "4K", 2 },
                    { 6, 8, 16, "Video Recorder;Autofokus;Flash;Night Mode;HDR", 48, 6, 120, "4K", 2 },
                    { 23, 12, 12, "Video Recorder;Autofokus;Flash;Night mode;Deep photo;Portrait", 12, 23, 60, "HD", 4 }
                });

            migrationBuilder.InsertData(
                table: "Hardwares",
                columns: new[] { "Id", "BatteryCapacity", "GraphicsProcessor", "MemorySpace", "MobilePhoneId", "OperationMemory", "OperationSystem", "ProcessorName", "SimCardType" },
                values: new object[,]
                {
                    { 29, 4500, "Adreno 618", 128, 29, 6, "Android", "Qualcomm Snapdragon 730", "Nano" },
                    { 21, 3500, "Adreno 512", 64, 21, 4, "Android", "Qualcomm Snapdragon 660", "Nano" },
                    { 1, 2500, "A14 Bionic", 64, 1, 4, "iOS", "A14 Bionic", "Nano" },
                    { 22, 4500, "Adreno 620", 128, 22, 8, "Android", "Qualcomm Snapdragon 765G", "Nano" },
                    { 8, 3300, "Adreno 650", 256, 8, 8, "Android", "Snapdragon 865+", "Nano" },
                    { 20, 5000, "Adreno 620", 128, 20, 6, "Android", "Qualcomm Snapdragon 765", "Nano" },
                    { 2, 2775, "A14 Bionic", 128, 2, 6, "iOS", "A14 Bionic", "Nano" },
                    { 24, 1821, "A13 Bionic", 64, 24, 4, "Android", "A13 Bionic", "Nano" },
                    { 19, 5000, "Adreno 620", 128, 19, 6, "Android", "Qualcomm Snapdragon 765", "Nano" },
                    { 18, 2800, "Adreno 620", 256, 18, 8, "Android", "Qualcomm Snapdragon 765", "Nano" },
                    { 28, 2800, "Mali-G71 MP2", 32, 28, 3, "Android", "Exynos", "Nano" },
                    { 3, 2775, "A14 Bionic", 64, 3, 4, "iOS", "A14 Bionic", "Nano" },
                    { 17, 5020, "ARM G52 MC2", 128, 17, 4, "Android", "MediaTek Helio G85", "Nano" },
                    { 10, 4000, "Mali G72 MP3", 128, 10, 4, "Android", "Exynos 9611", "Nano" },
                    { 25, 4000, "Adreno 620", 256, 25, 12, "Android", "Qualcomm Snapdragon 765 5G", "Nano" },
                    { 16, 5000, "Adreno 650", 256, 16, 8, "Android", "Qualcomm Snapdragon 865", "Nano" },
                    { 15, 4820, "Adreno™ GPU 619", 64, 15, 6, "Android", "Qualcomm Snapdragon 750G", "Nano" },
                    { 30, 4000, "IMG GE8320 680MHz", 64, 30, 4, "Android", "Helio P35 MT6765", "Nano" },
                    { 11, 4500, "Kirin 990 5G", 512, 11, 8, "Android", "Kirin 990 5G", "Nano" },
                    { 23, 3110, "A13 Bionic", 64, 23, 6, "Android", "A13 Bionic", "Nano" },
                    { 12, 4500, "Kirin 9000", 256, 12, 8, "Android", "Kirin 9000", "Nano" },
                    { 26, 4000, "PowerVR GM9446", 128, 26, 8, "Android", "MediaTek Helio P95", "Nano" },
                    { 5, 4300, "Adreno 620 GPU", 128, 5, 6, "Android", "Qualcomm Snapdragon 765G", "Nano" },
                    { 9, 4000, "Mali G78 MP14", 256, 9, 8, "Android", "Exynos", "Nano" },
                    { 6, 4000, "IMG GE8320 680MHz", 128, 6, 4, "Android", "MediaTek Helio P35", "Nano" },
                    { 13, 3580, "IMG GE8320", 64, 13, 3, "Android", "MediaTek MT6762", "Nano" },
                    { 27, 5000, "Adreno 610", 128, 27, 4, "Android", "Qualcomm Snapdragon 460", "Nano" },
                    { 14, 3600, "Adreno 610", 128, 14, 4, "Android", "Qualcomm Snapdragon 665", "Nano" },
                    { 4, 4000, "Adreno 620 GPU", 128, 4, 8, "Android", "Qualcomm Snapdragon 765G", "Nano" },
                    { 7, 4500, "Adreno 650", 256, 7, 12, "Android", "Qualcomm", "Nano" }
                });

            migrationBuilder.InsertData(
                table: "Screens",
                columns: new[] { "Id", "ColorsQuantity", "HorizontalResolution", "MobilePhoneId", "ScreenType", "Size", "VerticalResolution" },
                values: new object[,]
                {
                    { 24, 16, 1334, 24, "Retina HD IPS", 4.7m, 750 },
                    { 27, 16, 1600, 27, "LCD", 6.5m, 720 },
                    { 25, 16, 2400, 25, "AMOLED HDR10+", 6.5m, 1080 },
                    { 23, 16, 1792, 23, "Liquid Retina HD", 6.1m, 828 },
                    { 26, 16, 2400, 26, "AMOLED", 6.4m, 1080 },
                    { 29, 16, 2400, 29, "FHD+ Super AMOLED", 6.7m, 1080 },
                    { 28, 16, 1280, 28, "PLS TFT LCD", 5.0m, 720 },
                    { 15, 16, 2400, 15, "FHD+ DotDisplay 120 Hz IPS", 6.7m, 1080 },
                    { 22, 16, 2400, 22, "FHD+ LCD with PureDisplay", 6.8m, 1080 },
                    { 1, 16, 2532, 1, "OLED Super Retina XDR", 6.1m, 1170 },
                    { 2, 16, 2532, 2, "Super Retina XDR", 6.1m, 1170 },
                    { 3, 16, 2340, 3, "Super Retina XDR", 5.4m, 1080 },
                    { 4, 16, 2460, 4, "FHD+ P-OLED FullVision", 6.8m, 1080 },
                    { 5, 16, 2460, 5, "FHD+ OLED FullVision", 6.8m, 1080 },
                    { 6, 16, 2340, 6, "FHD+ IPS", 6.5m, 1080 },
                    { 7, 16, 2208, 7, "Dynamic AMOLED 2X", 6.1m, 1768 },
                    { 8, 16, 2636, 8, "Dynamic AMOLED & Super AMOLED", 6.7m, 1080 },
                    { 9, 16, 2400, 9, "Dynamic AMOLED 2X, 120Hz, HDR10+", 6.2m, 1080 },
                    { 10, 16, 2400, 10, "FHD+ Super AMOLED", 6.5m, 1080 },
                    { 11, 16, 2480, 11, "OLED", 6.6m, 1148 },
                    { 12, 16, 2772, 12, "FHD+ OLED", 6.8m, 1344 },
                    { 13, 16, 1680, 13, "TFT LCD", 6.2m, 720 },
                    { 14, 16, 2520, 14, "OLED", 6.0m, 1080 },
                    { 16, 16, 2440, 16, "FHD+ DotDisplay 144Hz IPS", 6.7m, 1080 },
                    { 17, 16, 2340, 17, "FHD+ AMOLED", 6.7m, 1080 },
                    { 18, 16, 2142, 18, "pOLED", 6.2m, 876 },
                    { 19, 16, 2340, 19, "FHD+ OLED", 6.7m, 1080 },
                    { 20, 16, 2520, 20, "FHD+ IPS CinemaVision", 6.7m, 1080 },
                    { 21, 16, 2340, 21, "IPS TFT", 6.3m, 1080 },
                    { 30, 16, 1600, 30, "HD+, ISP-LCD", 6.6m, 720 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Hardwares",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Multimedia",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Multimedia",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MobilePhones",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.AlterColumn<long>(
                name: "BatteryCapacity",
                table: "Hardwares",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
