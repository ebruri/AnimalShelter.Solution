using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Animal>()
            .HasData(
                new Animal { AnimalId = 1, Name = "Kopek", Species = "Dog", Age = 8, Gender = "Female" },
                new Animal { AnimalId = 2, Name = "Kedi", Species = "Cat", Age = 4, Gender = "Male" },
                new Animal { AnimalId = 3, Name = "Kus", Species = "Bird", Age = 2, Gender = "Male" },
                new Animal { AnimalId = 4, Name = "Kaplumbaga", Species = "Turtle", Age = 50, Gender = "Female" },
                new Animal { AnimalId = 5, Name = "Yilan", Species = "Snake", Age = 2, Gender = "Male" }
            );
        }
        public DbSet<Animal> Animals { get; set; }
    }
}