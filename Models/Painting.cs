using System;

namespace MarionSpijkerman.Website.Models
{
    public class Painting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool ForSale { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Year { get; set; }
        public int Order { get; set; }
        public string ImageFile { get; set; }
        public string ThumbnailFile { get; set; }
        public string Material { get; set; }
    }
}