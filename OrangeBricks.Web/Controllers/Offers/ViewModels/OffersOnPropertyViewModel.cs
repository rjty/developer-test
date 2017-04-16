using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrangeBricks.Web.Controllers.Offers.ViewModels
{
    public class OffersOnPropertyViewModel
    {
        public string PropertyType { get; set; }
        public int NumberOfBedrooms { get; set; }
        public string StreetName { get; set; }
        public bool HasOffers { get; set; }
        public IEnumerable<OfferViewModel> Offers { get; set; }
        public int PropertyId { get; set; }
        public int AskingPrice { get; set; }
        public string City { get; set; } // - may not be needed
        public string District { get; set; } // -
        public string County { get; set; } // -
        public string Country { get; set; } // -
        public virtual string Postalcode { get; set; } //-
        public byte ImageThumb { get; set; } // -
    }

    public class OfferViewModel
    {
        public int Id;
        public int Amount { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }
        public bool IsPending { get; set; }
        public string Status { get; set; }
    }
}