using Microsoft.EntityFrameworkCore;
using System;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {

    }
    protected override async void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
      .HasData(
        new Animal { AnimalId = 1, Name = "Bella", Sex = "Female", Breed = "Domestic Longhair", Species = "Cat", Age = 9, Color = "Orange", Image = "https://www.ccspca.com/wp-content/uploads/2014/01/William.jpg" },
        new Animal { AnimalId = 2, Name = "Max", Sex = "Male", Breed = "Domestic Medium Hair", Species = "Cat", Age = 8, Color = "Black", Image = "https://www.rover.com/blog/wp-content/uploads/2019/12/108164429_s.jpg" },
        new Animal { AnimalId = 3, Name = "Luna", Sex = "Female", Breed = "Domestic Longhair", Species = "Cat", Age = 5, Color = "Grey", Image = "https://www.mycatsite.com/images/Grey-British_Longhair_by-StuBramley.jpg" },
        new Animal { AnimalId = 4, Name = "Charlie", Sex = "Male", Breed = "Domestic Short Hair", Species = "Cat", Age = 6, Color = "White", Image = "https://www.hepper.com/wp-content/uploads/2021/08/white-american-shorthair_Oleksandr-Volchanskyi_Shutterstock.jpg" },
        new Animal { AnimalId = 5, Name = "Lucy", Sex = "Female", Breed = "Chihuahua", Species = "Dog", Age = 1, Color = "Orange", Image = "https://www.thesprucepets.com/thmb/Kh-xt27-hqeQzhyr9288cl_P64I=/1396x1396/smart/filters:no_upscale()/twenty20_f84c633e-705e-4bf8-a724-00cdea750d8d-590b51893df78c92837b18d6.jpg" },
        new Animal { AnimalId = 6, Name = "Milo", Sex = "Male", Breed = "Domestic Short Hair", Species = "Cat", Age = 4, Color = "Black", Image = "https://images.fineartamerica.com/images/artworkimages/mediumlarge/1/1-portrait-of-a-black-shorthair-cat-the-cat-looks-at-the-camera-with-a-stern-look-aleksandr-tannagashev.jpg" },
        new Animal { AnimalId = 7, Name = "Daizy", Sex = "Female", Breed = "French Bulldog", Species = "Dog", Age = 3, Color = "White", Image = "https://petskb.com/wp-content/uploads/2021/10/White-French-Bulldog-seated.jpg.webp" },
        new Animal { AnimalId = 8, Name = "Leo", Sex = "Male", Breed = "Domestic Short Hair", Species = "Cat", Age = 2, Color = "Orange", Image = "https://allaboutcats.com/wp-content/uploads/2018/08/orange-tabby.jpg" },
        new Animal { AnimalId = 9, Name = "Zoe", Sex = "Female", Breed = "Shepherd", Species = "Dog", Age = 10, Color = "Grey", Image = "https://thehappypuppysite.com/wp-content/uploads/2018/12/silver-german-shepherd-long.jpg" },
        new Animal { AnimalId = 10, Name = "Teddy", Sex = "Male", Breed = "Hound", Species = "Dog", Age = 5, Color = "Orange", Image = "https://nationalpurebreddogday.com/wp-content/uploads/2019/10/330.jpeg" },
        new Animal { AnimalId = 11, Name = "Molly", Sex = "Female", Breed = "Domestic Medium Hair", Species = "Cat", Age = 4, Color = "Brown", Image = "https://i.pinimg.com/originals/07/5e/05/075e05a9ed1d3d225ced3b19e8b8ee00.jpg" },
        new Animal { AnimalId = 12, Name = "Ollie", Sex = "Male", Breed = "Chihuahua", Species = "Dog", Age = 3, Color = "Black", Image = "https://www.dogster.com/wp-content/uploads/2015/05/shutterstock_1741426311.jpg" }
      );
    }
    public DbSet<Animal> Animals { get; set; }
  }
}