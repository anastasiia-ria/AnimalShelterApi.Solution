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
        new Animal { AnimalId = 1, Name = "Bella", Sex = "Female", Breed = "Domestic Longhair", Species = "Cat", Age = 9, Color = "Orange" },
        new Animal { AnimalId = 2, Name = "Max", Sex = "Male", Breed = "Domestic Medium Hair", Species = "Cat", Age = 8, Color = "Black" },
        new Animal { AnimalId = 3, Name = "Luna", Sex = "Female", Breed = "Domestic Longhair", Species = "Cat", Age = 5, Color = "Grey" },
        new Animal { AnimalId = 4, Name = "Charlie", Sex = "Male", Breed = "Domestic Short Hair", Species = "Cat", Age = 6, Color = "White" },
        new Animal { AnimalId = 5, Name = "Lucy", Sex = "Female", Breed = "Chihuahua", Species = "Dog", Age = 1, Color = "Grey" },
        new Animal { AnimalId = 6, Name = "Milo", Sex = "Male", Breed = "Domestic Short Hair", Species = "Cat", Age = 4, Color = "Black" },
        new Animal { AnimalId = 7, Name = "Daizy", Sex = "Female", Breed = "French Bulldog", Species = "Dog", Age = 3, Color = "White" },
        new Animal { AnimalId = 8, Name = "Leo", Sex = "Male", Breed = "Domestic Short Hair", Species = "Cat", Age = 2, Color = "Orange" },
        new Animal { AnimalId = 9, Name = "Zoe", Sex = "Female", Breed = "Shepherd", Species = "Dog", Age = 10, Color = "Grey" },
        new Animal { AnimalId = 10, Name = "Teddy", Sex = "Male", Breed = "Hound", Species = "Dog", Age = 5, Color = "Orange" },
        new Animal { AnimalId = 11, Name = "Molly", Sex = "Female", Breed = "Domestic Medium Hair", Species = "Cat", Age = 4, Color = "Black" },
        new Animal { AnimalId = 12, Name = "Ollie", Sex = "Male", Breed = "Chihuahua", Species = "Dog", Age = 3, Color = "Black" }
      );
    }
    public DbSet<Animal> Animals { get; set; }
  }
}