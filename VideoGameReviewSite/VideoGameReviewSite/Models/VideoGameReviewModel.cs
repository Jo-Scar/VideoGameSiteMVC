using System.ComponentModel.DataAnnotations;

namespace VideoGameReviewSite.Models
{
    public class VideoGameReviewModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }

        public string Reviews { get; set; }
        public string Description { get; set; }

    }
}
