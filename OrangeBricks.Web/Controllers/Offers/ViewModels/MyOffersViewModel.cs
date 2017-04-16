using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrangeBricks.Web.Controllers.Property.ViewModels
{
    public class MyOffersOnPropertyViewModel
    {
        public List<PropertyViewModel> Properties { get; set; }
        public bool HasOffers { get; set; } // - could be zero
        public IEnumerable<MyOffersOnPropertyViewModel> Offers { get; set; }

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
        public bool IsAccepted { get; set; } // -

        public int Id;
        public int Amount { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }
        public bool IsPending { get; set; }
        public string Status { get; set; }
    }
}