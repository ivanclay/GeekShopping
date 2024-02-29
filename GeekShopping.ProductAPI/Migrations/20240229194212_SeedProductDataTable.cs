using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 1L, "Cup", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.", "https://github.com/ivanclay/GeekShopping/blob/main/images/1_super_mario.jpg", "Super Mario Cup", 39.9m },
                    { 2L, "T-Shirt", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.", "https://github.com/ivanclay/GeekShopping/blob/main/images/2_no_internet.jpg", "T-Shirt No Internet", 49.9m },
                    { 3L, "Lamp", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.", "https://github.com/ivanclay/GeekShopping/blob/main/images/3_vader.jpg", "Vader Lamp", 139.9m },
                    { 4L, "Collection", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.", "https://github.com/ivanclay/GeekShopping/blob/main/images/4_storm_tropper.jpg", "Storm Tropper", 339.9m },
                    { 5L, "T-Shirt", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.", "https://github.com/ivanclay/GeekShopping/blob/main/images/5_100_gamer.jpg", "100% Gamer", 39.9m },
                    { 6L, "T-Shirt", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.", "https://github.com/ivanclay/GeekShopping/blob/main/images/6_spacex.jpg", "SpaceX", 39.9m },
                    { 7L, "T-Shirt", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.", "https://github.com/ivanclay/GeekShopping/blob/main/images/7_coffee.jpg", "Coffee", 39.9m },
                    { 8L, "T-Shirt", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.", "https://github.com/ivanclay/GeekShopping/blob/main/images/8_moletom_cobra_kay.jpg", "Cobra Kay", 99.9m },
                    { 9L, "Book", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.", "https://github.com/ivanclay/GeekShopping/blob/main/images/9_neil.jpg", "Star Talk", 59.9m },
                    { 10L, "Play", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.", "https://github.com/ivanclay/GeekShopping/blob/main/images/10_milennium_falcon.jpg", "Millenium Falcon", 539.9m },
                    { 11L, "T-Shirt", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.", "https://github.com/ivanclay/GeekShopping/blob/main/images/11_mars.jpg", "Mars", 39.9m },
                    { 12L, "T-Shirt", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.", "https://github.com/ivanclay/GeekShopping/blob/main/images/12_gnu_linux.jpg", "GNU LINUX", 39.9m },
                    { 13L, "T-Shirt", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.", "https://github.com/ivanclay/GeekShopping/blob/main/images/13_dragon_ball.jpg", "Dragon Ball", 39.9m },
                    { 14L, "Patch", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.", "https://github.com/ivanclay/GeekShopping/blob/main/images/14_patch_nasa.jpg", "NASA", 19.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 14L);
        }
    }
}
