using System;
using System.Collections.Generic;

namespace database_connection.Models
{
    public partial class Customerdetail
    {
        public int CustId { get; set; }
        public string? Custname { get; set; }
        public string? Custgender { get; set; }
        public int? Custphone { get; set; }
        public string? Custaddress { get; set; }
    }
}
