using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication21.Models
{
    public class ImageModel
    {

        [Key]
        public int imageId { get; set; }
        public String title { get; set; }
        public string ImageName { get; set; }

        [NotMapped]
        
        public IFormFile ImageFile { get; set; }



    }
}
