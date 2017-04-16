using System;
using System.ComponentModel.DataAnnotations;

namespace OrangeBricks.Web.Models
{
    // - not used
    public interface IRequestableEntity
    {
        [Key]
        int Id { get; set; }

        Status Status { get; set; }

        DateTime CreatedAt { get; set; }

        DateTime UpdatedAt { get; set; }

        int Amount { get; set; }

        int UserId { get; set; }

        DateTime RequestedViewingDateTime { get; set; }

    }
}