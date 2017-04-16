using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrangeBricks.Web.Models
{
    public class Property
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string PropertyType { get; set; }

        [Required]
        public string StreetName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int NumberOfBedrooms { get; set; }

        [Required]
        public string SellerUserId { get; set; }

        public bool IsListedForSale { get; set; }

        public ICollection<Offer> Offers { get; set; }

        [Required]
        public int AskingPrice { get; set; }    // -

        [Required]
        public string City { get; set; }        // -

        public string District { get; set; }    // -

        public string County { get; set; }      // -

        public string Country { get; set; }     // -

        [DataType(DataType.PostalCode)]
        public virtual string Postalcode { get; set; } // -

        public byte ImageThumb { get; set; } // -

        public ICollection<Viewing> Viewings { get; set; }

        public Boolean HasOffers { get; set; } // - has 1 or more offers
        public object IsAccepted { get; internal set; }
    }

}