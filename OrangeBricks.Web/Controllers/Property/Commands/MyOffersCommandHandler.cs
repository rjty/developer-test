using System;
using System.Collections.Generic;
using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Property.Commands
{
    public class MyOffersCommandHandler
    {
        private readonly IOrangeBricksContext _context;

        public MyOffersCommandHandler(IOrangeBricksContext context)
        {
            _context = context;
        }

        public void Handle(ViewOfferCommand command)
        {
            var property = _context.Properties.Find(command.PropertyId);

            var offer = new Offer
            {
                Amount = command.Offer,
                PropertyId = command.PropertyId
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            //if (property.Offers == null)
            //{
            //    property.Offers = new List<Offer>();
            //}

            //property.Offers.Add(offer);

            //_context.SaveChanges();
        }

    }
}