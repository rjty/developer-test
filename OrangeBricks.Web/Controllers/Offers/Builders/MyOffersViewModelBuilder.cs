using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using OrangeBricks.Web.Controllers.Offers.ViewModels;
using OrangeBricks.Web.Models;
using OrangeBricks.Web.Controllers.Property.ViewModels;

namespace OrangeBricks.Web.Controllers.Property.Builders
{
    public class MyOffersOnPropertyViewModelBuilder
    {
        private readonly IOrangeBricksContext _context;

        public MyOffersOnPropertyViewModelBuilder(IOrangeBricksContext context)
        {
            _context = context;
        }

        public MyOffersOnPropertyViewModel Build(int id)
        {
            var property = _context.Properties
                .Where(p => p.Id == id)
                .Include(x => x.Offers)
                .SingleOrDefault();

            var offers = property.Offers ?? new List<Offer>();

            return new MyOffersOnPropertyViewModel
            {
                HasOffers = offers.Any(),
                Offers = offers.Select(x => new MyOffersOnPropertyViewModel
                {
                    Id = x.Id,
                    Amount = x.Amount,
                    CreatedAt = x.CreatedAt,
                    IsPending = x.Status == OfferStatus.Pending,
                    Status = x.Status.ToString()
                }),
                PropertyId = property.Id,
                PropertyType = property.PropertyType,
                StreetName = property.StreetName,
                AskingPrice = property.AskingPrice
            };
        }
    }
}