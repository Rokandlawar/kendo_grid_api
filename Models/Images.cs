using System;
using System.Collections.Generic;

namespace kendo_grid_api.Models
{
    public partial class Images
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
    }
}
