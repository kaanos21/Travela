﻿using Travela.EntityLayer.Concrete;

namespace Travela.WebUI.Dtos
{
    public class ResultCategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }

        public List<Destination> Destinations { get; set; }
    }
}
