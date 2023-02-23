using Microsoft.EntityFrameworkCore;

namespace VideoGameReviewSite.Data
{
    public class VideoGameContext : DbContext
    {
        DbSet<VideoGameReviewModel> VideoGameReview { get; set; }
    }
}
