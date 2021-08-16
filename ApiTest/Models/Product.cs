using System;
using System.Collections.Generic;

#nullable disable

namespace ApiTest.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string ProductPicDataUrl { get; set; }
    }
}
