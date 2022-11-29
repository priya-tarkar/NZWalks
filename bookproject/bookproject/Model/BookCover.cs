using System.ComponentModel.DataAnnotations.Schema;

namespace bookproject.Model
{
    public class BookCover
    {
        public int? id { get; set; }
        public String? Title { get; set; }
        public String? ImageUrl { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public ICollection<Book>? Books { get; set; }
        public int? BookWritterId { get; set; }

        public BookWritter? BookWritter { get; set; }

    }
}
