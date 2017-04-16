using OrangeBricks.Web.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace OrangeBricks.Web.Controllers.Property.ViewModels
{
    public class ViewingViewModel
    {
        public int PropertyId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime RequestedViewingDateTime { get; set; }
        public bool IsPending { get; set; }
        public string Status { get; set; }
    }
}