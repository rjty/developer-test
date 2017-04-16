using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrangeBricks.Web.Controllers.Property.Commands
{
    public class MyOffersCommand
    {
        public class ViewOfferCommand
        {
            public int PropertyId { get; set; }

            public int Offer { get; set; }

        }
    }
}