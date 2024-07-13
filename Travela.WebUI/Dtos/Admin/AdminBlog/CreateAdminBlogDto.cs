using Travela.EntityLayer.Concrete;

namespace Travela.WebUI.Dtos.Admin.AdminBlog
{
    public class CreateAdminBlogDto
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string ImageUrl { get; set; }
        public int CountDay { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }

        // Navigation Property


        public Category? Category { get; set; }
    }
}
