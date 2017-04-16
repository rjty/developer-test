using OrangeBricks.Web.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace OrangeBricks.Web.Controllers.Property.ViewModels
{
    public class BookViewingViewModel
    {
        public int PropertyId { get; set; }
        public string PropertyType { get; set; }
        public string StreetName { get; set; }
        public Status Status { get; set; }
        public bool IsListedForSale { get; set; } // -
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime UpdatedAt { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime RequestedViewingDateTime { get; set; } // -
    }
}
