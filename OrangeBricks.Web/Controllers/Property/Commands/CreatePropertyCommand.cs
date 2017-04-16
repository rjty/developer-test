using System.ComponentModel.DataAnnotations;

namespace OrangeBricks.Web.Controllers.Property.Commands
{
    public class CreatePropertyCommand
    {
        [Required]
        public string PropertyType { get; set; }

        [Required]
        public string StreetName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int NumberOfBedrooms { get; set; }

        [Required]
        public int AskingPrice { get; set; } // -

        [Required]
        public string City { get; set; } // -

        public string District { get; set; } // -

        public string County { get; set; } // -

        public string Country { get; set; } // -

        [DataType(DataType.PostalCode)]
        public virtual string Postalcode { get; set; } //-

        public byte ImageThumb { get; set; } // -

        public string SellerUserId { get; set; }

        public int BuyerUserId { get; set; }  // -

    }
}