using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Property.ViewModels
{
    public class MakeOfferViewModel
    {
        public string PropertyType { get; set; }
        public int Offer { get; set; }
        public string StreetName { get; set; }
        public int PropertyId { get; set; }
        public int AskingPrice { get; set; }
        public int BuyerUserId { get; set; } // -
    }
}