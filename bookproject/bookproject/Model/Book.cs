using System.ComponentModel.DataAnnotations.Schema;

namespace bookproject.Model
{
    public class Book
    {
        public int? Id { get; set; }
        public String? Title { get; set; }
        public String? Description { get; set; }
        public bool? Treding { get; set; }
        public String? ImageUrl { get; set; }
        public String? BookUrl { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public int? ISBNNumber { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        [NotMapped]
        public IFormFile? BookFile { get; set; }
        public int? BookWritterId1 { get; set; }
        public BookWritter? BookWritter1 { get; set; }
        public int? BookCoverId { get; set; }
        public BookCover? BookCover { get; set; }

    }
}
