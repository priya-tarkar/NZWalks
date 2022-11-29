namespace WebApplication1.Model
{
    public class Book
    {
        public int Id  { get; set; }
        public String Name { get; set; }
        
        public IFormFile Imageurl { get; set; }
    }
}
