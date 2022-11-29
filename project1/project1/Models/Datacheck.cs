using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace project1.Models
{
    public partial class Datacheck
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        [DisplayName("uploadimage")]
        public string? Image { get; set; }

        [NotMapped]
        public  IFormFile ImageFile { get; set; }
    }
}
