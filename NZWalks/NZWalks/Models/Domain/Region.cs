﻿namespace NZWalks.Models.Domain
{
    public class Region
    {
        public Guid id { get; set; }

        public String Code { get; set; }

        public String Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long Population { get; set; }

        public IEnumerable<Walk> Walk { get; set; }

    }
}
