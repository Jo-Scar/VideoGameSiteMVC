using Microsoft.EntityFrameworkCore;
using VideoGameReviewSite.Models;

namespace VideoGameReviewSite.Data
{
    public class VideoGameContext : DbContext
    {
        DbSet<ProductVideoGameModel> VideoGame { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String connectionString = "Server=(localdb)\\mssqllocaldb;Database=VideoGameReviews;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVideoGameModel>().HasData(new ProductVideoGameModel()
            {
                Id = 1,
                Name = "",
                ImageURL = "",
                Reviews = "",
                Description = "",
                Cost =1,
                ReleaseDate ="",
            }); ;
        }
    }
}
