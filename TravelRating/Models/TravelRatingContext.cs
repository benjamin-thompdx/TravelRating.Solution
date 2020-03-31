using Microsoft.EntityFrameworkCore;

namespace TravelRating.Models
{
  public class TravelRatingContext : DbContext
  {
    public TravelRatingContext(DbContextOptions<TravelRatingContext> options)
      :base(options)
      {

      }

    public DbSet<Location> Locations { get; set; }
    public DbSet<Experience> Experiences { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Location>()
        .HasData(
          new Location { LocationId = 1, Name = "Ha Long Bay", City = "Hanoi", Country = "Vietnam"},
          new Location { LocationId = 2, Name = "Thingvellir Park", City = "Reykjavik", Country = "Iceland"},
          new Location { LocationId = 3, Name = "Killarney National Park", City = "Kerry", Country = "Ireland"},
          new Location { LocationId = 4, Name = "Clock Walk", City = "New York", Country = "United States"}
        );
      builder.Entity<Experience>()
        .HasData(
          new Experience { ExperienceId = 1, Author = "Ben's Mom", Review = "Hanoi", Rating = 2, LocationId = 3},
          new Experience { ExperienceId = 2, Author = "Matt's Mom", Review = "Reykjavik", Rating = 2, LocationId = 3},
          new Experience { ExperienceId = 3, Author = "Katy's Mom", Review = "Kerry", Rating = 2, LocationId = 3},
          new Experience { ExperienceId = 4, Author = "Katy's Kids' Mom", Review = "New York", Rating = 2, LocationId = 3}
        );
    }
  }
}