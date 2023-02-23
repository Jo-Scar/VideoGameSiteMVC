using System.ComponentModel.DataAnnotations;

namespace VideoGameReviewSite.Models
{
    public class ReviewModel
    {
        [Key]
        public int Id { get; set; }
        public string Reviewer { get; set; }
        public string Description { get; set; }

    }
}
