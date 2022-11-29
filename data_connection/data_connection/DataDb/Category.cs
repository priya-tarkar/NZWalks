using System;
using System.Collections.Generic;

namespace data_connection.DataDb
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int DisplayOrder { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
