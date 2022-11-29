using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tryweblist.Model
{
    public class Category
    {
      
        public int  Id { get; set; }
        [Required]
        public String? Title { get; set; }
        [Required]
        public int? DisplayOrder { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
       
        [NotMapped]

        public IFormFile? CategoryImage { get; set; }
        public String? CategoryImagePath { get; set; }
    }
}
