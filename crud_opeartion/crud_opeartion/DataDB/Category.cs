using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud_opeartion.DataDB
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int DisplayOrder { get; set; }
        public DateTime CreatedDate { get; set; }
        [Display(Name ="Font Image")]
       
        [NotMapped]
        public IFormFile? Imageurl  { get; set; }
    }
}
