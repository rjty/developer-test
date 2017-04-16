using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace OrangeBricks.Web.Controllers.Property.ViewModels
{
    public class CreatePropertyViewModel
    {
        [Required(ErrorMessage = "A Property Type is required.")]
        [Display(Name = "Property type" )]
        public string PropertyType { get; set; }

        [Required(ErrorMessage = "A Street Name is required.")]
        [Display(Name = "Street name")]
        public string StreetName { get; set; }

        [Required(ErrorMessage = "A Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Number of Bedrooms is required.")]
        [Display(Name = "Number of bedrooms")]
        public int NumberOfBedrooms { get; set; }
        public IEnumerable<SelectListItem> BedroomCount { get; set; }

        [Required(ErrorMessage = "Please supply an Asking Price")]
        [Display(Name = "Valuation")]
        public int AskingPrice { get; set; }

        [Display(Name = "City or Town")]
        public string City { get; set; } 
        public string District { get; set; }
        public string County { get; set; } 
        [Required]
        [Display(Name = "Post Code")]
        public virtual string Postalcode { get; set; }
        public string Country { get; set; }
        [Display(Name = "Photograph")]
        public byte ImageThumb { get; set; }
        public IEnumerable<SelectListItem> PossiblePropertyTypes { get; set; }
    }
}