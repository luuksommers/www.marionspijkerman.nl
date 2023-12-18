using System;
using System.Collections.Generic;

namespace MarionSpijkerman.Website.Models
{
    public class PaintingsList : List<Painting>
    {
        private static PaintingsList _current;
        public static PaintingsList Get()
        {
            if(_current == null)
            {
                _current = new PaintingsList();
            }
            return _current;
        }

        private PaintingsList()
        {
            Initialize();
        }

        public void Initialize()
        {
            int newId = 1;
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 30,
                ImageFile = "black_and_white_2008_30x30.jpg",
                Material = "",
                Name = "Black and white",
                Order = 1,
                ThumbnailFile = "black_and_white_2008_30x30_1.jpg",
                Width = 30,
                Year = 2008
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 30,
                ImageFile = "freedom_flowers_2008_24x30.jpg",
                Material = "",
                Name = "Freedom flowers",
                Order = 2,
                ThumbnailFile = "freedom_flowers_2008_24x30_1.jpg",
                Width = 24,
                Year = 2008
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 40,
                ImageFile = "security_2009.jpg",
                Material = "",
                Name = "Security",
                Order = 3,
                ThumbnailFile = "security_2009_1.jpg",
                Width = 30,
                Year = 2009
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 30,
                ImageFile = "fish_swimming_in_the_sea_2009_30x30.jpg",
                Material = "",
                Name = "Fish",
                Order = 4,
                ThumbnailFile = "fish_swimming_in_the_sea_2009_30x30_1.jpg",
                Width = 30,
                Year = 2009
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 30,
                ImageFile = "drowning_in_sorrow_2009_30x30.jpg",
                Material = "",
                Name = "Drowning in sorrow",
                Order = 10,
                ThumbnailFile = "drowning_in_sorrow_2009_30x30_1.jpg",
                Width = 30,
                Year = 2009
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 50,
                ImageFile = "the_beauty_of_nature_2009.jpg",
                Material = "",
                Name = "The Beauty Of Nature",
                Order = 11,
                ThumbnailFile = "the_beauty_of_nature_2009_1.jpg",
                Width = 60,
                Year = 2009
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 50,
                ImageFile = "tulpen_2012.jpg",
                Material = "",
                Name = "Tullips",
                Order = 101,
                ThumbnailFile = "tulpen_2012_1.jpg",
                Width = 100,
                Year = 2012
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 60,
                ImageFile = "blowball_2012-90x60.jpg",
                Material = "",
                Name = "Blowball",
                Order = 96,
                ThumbnailFile = "blowball_2012-90x60_1.jpg",
                Width = 90,
                Year = 2012
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 50,
                ImageFile = "tunnel_2011_60x50.jpg",
                Material = "",
                Name = "Tunnel Vision",
                Order = 93,
                ThumbnailFile = "tunnel_2011_60x50_1.jpg",
                Width = 60,
                Year = 2011
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 70,
                ImageFile = "talens_palet_2011_70x70.jpg",
                Material = "",
                Name = "NoTitle",
                Order = 90,
                ThumbnailFile = "talens_palet_2011_70x70_1.jpg",
                Width = 70,
                Year = 2011
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 40,
                ImageFile = "liminal_space_2010_30x40.jpg",
                Material = "",
                Name = "NoTitle",
                Order = 87,
                ThumbnailFile = "liminal_space_2010_30x40_1.jpg",
                Width = 30,
                Year = 2010
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 40,
                ImageFile = "compromising_2010_30x30.jpg",
                Material = "",
                Name = "Compromising",
                Order = 80,
                ThumbnailFile = "compromising_2010_30x30_1.jpg",
                Width = 30,
                Year = 2010
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 40,
                ImageFile = "affinity_2010_30x40.jpg",
                Material = "",
                Name = "Affinity",
                Order = 77,
                ThumbnailFile = "affinity_2010_30x40_1.jpg",
                Width = 30,
                Year = 2010
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 40,
                ImageFile = "water_lilies_2010_120x40.jpg",
                Material = "",
                Name = "Water Lilies",
                Order = 75,
                ThumbnailFile = "water_lilies_2010_120x40_1.jpg",
                Width = 120,
                Year = 2010
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 70,
                ImageFile = "new_life_2010_90x70.jpg",
                Material = "",
                Name = "New Life",
                Order = 70,
                ThumbnailFile = "new_life_2010_90x70_1.jpg",
                Width = 90,
                Year = 2010
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 150,
                ImageFile = "passionate_love_2010_100x150.jpg",
                Material = "",
                Name = "Passionate Love",
                Order = 68,
                ThumbnailFile = "passionate_love_2010_100x150_1.jpg",
                Width = 100,
                Year = 2010
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 50,
                ImageFile = "secrets_and_mystery_2009.jpg",
                Material = "",
                Name = "Secrets And Mystery",
                Order = 65,
                ThumbnailFile = "secrets_and_mystery_2009_1.jpg",
                Width = 60,
                Year = 2009
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 30,
                ImageFile = "sweet_dreams_2009_30x30.jpg",
                Material = "",
                Name = "Sweet Dreams",
                Order = 63,
                ThumbnailFile = "sweet_dreams_2009_30x30_1.jpg",
                Width = 30,
                Year = 2009
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 40,
                ImageFile = "balletdancers.jpg",
                Material = "",
                Name = "Dance couple",
                Order = 103,
                ThumbnailFile = "balletdancers_mini.jpg",
                Width = 30,
                Year = 2012
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 40,
                ImageFile = "the_vulnerable_human_being_2009_50x40.jpg",
                Material = "",
                Name = "The vulnerable human being",
                Order = 63,
                ThumbnailFile = "the_vulnerable_human_being_2009_50x40-mini.jpg",
                Width = 50,
                Year = 2009
            });
            Add(new Painting()
            {
                Id = newId++,
                ForSale = false,
                Height = 40,
                ImageFile = "daisy_web_1.JPG",
                Material = "",
                Name = "Daisy",
                Order = 104,
                ThumbnailFile = "daisy_web_2.JPG",
                Width = 50,
                Year = 2013
            });
        }
    }
}