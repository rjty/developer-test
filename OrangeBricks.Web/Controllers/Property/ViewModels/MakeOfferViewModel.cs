namespace OrangeBricks.Web.Controllers.Property.ViewModels
{
    public class MakeOfferViewModel
    {
        public string PropertyType { get; set; }
        public string StreetName { get; set; }
        public int Offer { get; set; }
        public int PropertyId { get; set; }
        public int AskingPrice { get; set; }

        public string City { get; set; } // - may not be needed
        public string District { get; set; } // -
        public string County { get; set; } // -
        public string Country { get; set; } // -
        public virtual string Postalcode { get; set; } //-
        public byte ImageThumb { get; set; } // -
    }
}