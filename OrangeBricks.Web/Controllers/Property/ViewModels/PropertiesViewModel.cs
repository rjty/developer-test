using System.Collections.Generic;
namespace OrangeBricks.Web.Controllers.Property.ViewModels
{
    public class PropertiesViewModel
    {
        public List<PropertyViewModel> Properties { get; set; }
        public string Search { get; set; }
        public int BuyerUserId { get; set; }
        public int PropertyId { get; set; }
    }
}