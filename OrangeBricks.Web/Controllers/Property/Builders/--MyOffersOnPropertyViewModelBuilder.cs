using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using OrangeBricks.Web.Controllers.Offers.ViewModels;
using OrangeBricks.Web.Models;
using OrangeBricks.Web.Controllers.Property.ViewModels;

namespace OrangeBricks.Web.Controllers.Offers.Builders
{
    public class MyOffersOnPropertyViewModelBuilder
    {
        private readonly IOrangeBricksContext _context;

        public MyOffersOnPropertyViewModelBuilder(IOrangeBricksContext context)
        {
            _context = context;
        }

        //public MyOffersOnPropertyViewModel Build(string buyerId)
        //{
        //    return new MyOffersOnPropertyViewModel
        //    {
        //        Properties = _context.Properties
        //            .Where(p => p.SellerUserId == buyerId)
        //            .Select(p => new MyOfferViewModel
        //            {
        //                Id = p.Id,
        //                Amount = p.AskingPrice,
        //                //CreatedAt = p.Cr,
        //                IsPending = p.,
        //                Status = p.S,


        //                //StreetName = p.StreetName,
        //                //Description = p.Description,
        //                //NumberOfBedrooms = p.NumberOfBedrooms,
        //                //PropertyType = p.PropertyType,
        //                //IsListedForSale = p.IsListedForSale,
        //                // AskingPrice = p.AskingPrice,
        //                //City = p.City,
        //                //District = p.District,
        //                //County = p.County,
        //                //Country = p.Country,
        //                //Postalcode = p.Postalcode,
        //                //ImageThumb = p.ImageThumb
        //            })
        //            .ToList()
        //    };
        //}


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
                Offers = offers.Select(x => new MyOfferViewModel
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

        //public MyOffersOnPropertyViewModel Build(int id)
        //{
        //    var property = _context.Properties
        //        .Where(p => p.Id == id)
        //        .Include(x => x.Offers)
        //        .SingleOrDefault();

        //    var offers = property.Offers ?? new List<Offer>();

        //    return new MyOffersOnPropertyViewModel
        //    {
        //        HasOffers = offers.Any(),
        //        Offers = offers.Select(x => new MyOfferViewModel
        //        {
        //            Id = x.Id,
        //            Amount = x.Amount,
        //            CreatedAt = x.CreatedAt,
        //            IsPending = x.Status == OfferStatus.Pending,
        //            Status = x.Status.ToString()
        //        }),
        //        PropertyId = property.Id,
        //        PropertyType = property.PropertyType,
        //        StreetName = property.StreetName,
        //        AskingPrice = property.AskingPrice
        //    };
        //}
    }
}