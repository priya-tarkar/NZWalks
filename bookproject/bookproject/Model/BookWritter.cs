using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bookproject.Model
{
    public class BookWritter
    {
        public int? Id { get; set; }
        [Required]
        public String? Name { get; set; }
        [Required]
        public String? Gender { get; set; }
        public String? ImageUrl { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public ICollection<Book>? Books { get; set; }
        public ICollection<BookCover>? BookCovers { get; set; }
    }
}
