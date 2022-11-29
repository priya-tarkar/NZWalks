namespace container_upload.Model
{
    public class Book
    {
        public int? Id  { get; set; }
        public String? Name  { get; set; }

        public IFormFile? BookFile { get; set; }
    }
}
