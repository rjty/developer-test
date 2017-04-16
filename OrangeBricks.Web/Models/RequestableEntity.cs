using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrangeBricks.Web.Models
{
    // - in development
    public class RequestableEntity<T> : Entity<T>, IRequestableEntity
    {
        [ScaffoldColumn(false)]
        public new int Id { get; set; }

        [ScaffoldColumn(false)]
        public int UserId { get; set; }

        [ScaffoldColumn(false)]
        public Status Status { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedAt { get; set; }

        [ScaffoldColumn(false)]
        public DateTime UpdatedAt { get; set; }

        [ScaffoldColumn(false)]
        public int Amount { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RequestedViewingDateTime { get; set; }

    }
}