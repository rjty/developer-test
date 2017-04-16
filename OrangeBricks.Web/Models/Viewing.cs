using System;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Book a date and Time for the viewing of a property
/// </summary>
namespace OrangeBricks.Web.Models
{
    public class Viewing
    {
        [Key]

        public int Id { get; set; }

        public Status Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public System.DateTime RequestedViewingDateTime { get; set; }
    }
}