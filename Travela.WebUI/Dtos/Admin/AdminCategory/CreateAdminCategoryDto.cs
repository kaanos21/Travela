using Travela.EntityLayer.Concrete;

namespace Travela.WebUI.Dtos.Admin.AdminCategory
{
    public class CreateAdminCategoryDto
    {
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }

        public List<Destination>? Destinations { get; set; }
    }
}
