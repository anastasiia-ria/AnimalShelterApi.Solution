using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Color", "Image", "Name", "Sex", "Species" },
                values: new object[,]
                {
                    { 1, 9, "Domestic Longhair", "Orange", "https://www.ccspca.com/wp-content/uploads/2014/01/William.jpg", "Bella", "Female", "Cat" },
                    { 2, 8, "Domestic Medium Hair", "Black", "https://www.rover.com/blog/wp-content/uploads/2019/12/108164429_s.jpg", "Max", "Male", "Cat" },
                    { 3, 5, "Domestic Longhair", "Grey", "https://www.mycatsite.com/images/Grey-British_Longhair_by-StuBramley.jpg", "Luna", "Female", "Cat" },
                    { 4, 6, "Domestic Short Hair", "White", "https://www.hepper.com/wp-content/uploads/2021/08/white-american-shorthair_Oleksandr-Volchanskyi_Shutterstock.jpg", "Charlie", "Male", "Cat" },
                    { 5, 1, "Chihuahua", "Orange", "https://www.thesprucepets.com/thmb/Kh-xt27-hqeQzhyr9288cl_P64I=/1396x1396/smart/filters:no_upscale()/twenty20_f84c633e-705e-4bf8-a724-00cdea750d8d-590b51893df78c92837b18d6.jpg", "Lucy", "Female", "Dog" },
                    { 6, 4, "Domestic Short Hair", "Black", "https://images.fineartamerica.com/images/artworkimages/mediumlarge/1/1-portrait-of-a-black-shorthair-cat-the-cat-looks-at-the-camera-with-a-stern-look-aleksandr-tannagashev.jpg", "Milo", "Male", "Cat" },
                    { 7, 3, "French Bulldog", "White", "https://petskb.com/wp-content/uploads/2021/10/White-French-Bulldog-seated.jpg.webp", "Daizy", "Female", "Dog" },
                    { 8, 2, "Domestic Short Hair", "Orange", "https://allaboutcats.com/wp-content/uploads/2018/08/orange-tabby.jpg", "Leo", "Male", "Cat" },
                    { 9, 10, "Shepherd", "Grey", "https://thehappypuppysite.com/wp-content/uploads/2018/12/silver-german-shepherd-long.jpg", "Zoe", "Female", "Dog" },
                    { 10, 5, "Hound", "Orange", "https://nationalpurebreddogday.com/wp-content/uploads/2019/10/330.jpeg", "Teddy", "Male", "Dog" },
                    { 11, 4, "Domestic Medium Hair", "Brown", "https://i.pinimg.com/originals/07/5e/05/075e05a9ed1d3d225ced3b19e8b8ee00.jpg", "Molly", "Female", "Cat" },
                    { 12, 3, "Chihuahua", "Black", "https://www.dogster.com/wp-content/uploads/2015/05/shutterstock_1741426311.jpg", "Ollie", "Male", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12);
        }
    }
}
