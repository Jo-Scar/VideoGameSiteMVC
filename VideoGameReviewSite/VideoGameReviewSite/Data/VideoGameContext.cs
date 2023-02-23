using Microsoft.EntityFrameworkCore;
using VideoGameReviewSite.Models;

namespace VideoGameReviewSite.Data
{
    public class VideoGameContext : DbContext
    {
        DbSet<ProductVideoGameModel> VideoGameReview { get; set; }
    }
}
