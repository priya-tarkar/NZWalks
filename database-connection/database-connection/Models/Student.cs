using System;
using System.Collections.Generic;

namespace database_connection.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Class { get; set; }
        public string? Country { get; set; }
        public string? Subject { get; set; }
        public string? FavouriteColor { get; set; }
    }
}
