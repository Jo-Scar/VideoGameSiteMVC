using System.ComponentModel.DataAnnotations;

namespace VideoGameReviewSite.Models
{
    public class ProductVideoGameModel
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }

        public string Reviews { get; set; }
       
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public double Cost { get; set; }
        


    }
}
