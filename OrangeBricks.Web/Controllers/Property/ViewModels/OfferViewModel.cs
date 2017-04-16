using System;
using System.ComponentModel.DataAnnotations;

namespace OrangeBricks.Web.Controllers.Property.ViewModels
{
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