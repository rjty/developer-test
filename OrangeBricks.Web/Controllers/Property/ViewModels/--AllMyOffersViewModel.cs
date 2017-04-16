using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace OrangeBricks.Web.Controllers.Property.ViewModels
{
    public class AllMyOffersViewModel
    {
        //public Property Property { get; set; }
        //public Offers Offers { get; set; }
        public Models.Property Property { get; set; }

        public Models.Offer Offer { get; set; }
        //public List<PropertyViewModel> Properties { get; set; }
        //public IEnumerable<OfferViewModel> Offer { get; set; }
        public IEnumerable<MyOffersOnPropertyViewModel> Offers { get; set; }

        public bool HasOffers { get; set; }

        public bool Accepted { get; set; }
        public string PropertyType { get; set; }

        public string PropertyId { get; set; }
        public string StreetName { get; set; }
        public string Description { get; set; }
        public int NumberOfBedrooms { get; set; }
        public int AskingPrice { get; set; } // -
        public string City { get; set; } // -
        public string District { get; set; } // -
        public string County { get; set; } // -
        public string Country { get; set; } // -
        public virtual string Postalcode { get; set; } //-
        public byte ImageThumb { get; set; } // -
        public string SellerUserId { get; set; }
        public string BuyerUserId { get; set; }  // -
    }
}