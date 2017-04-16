using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using OrangeBricks.Web.Controllers.Offers.ViewModels;
using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Offers.Builders
{
    public class ViewRequestsOnPropertyViewModelBuilder
    {
        private readonly IOrangeBricksContext _context;

        public ViewRequestsOnPropertyViewModelBuilder(IOrangeBricksContext context)
        {
            _context = context;
        }

        public ViewRequestsOnPropertyViewModel Build(int id)
        {
            var property = _context.Properties
                .Where(p => p.Id == id)
                .Include(x => x.Viewings)
                .SingleOrDefault();

            var viewings = property.Viewings ?? new List<Viewing>();

            return new ViewRequestsOnPropertyViewModel
            {
                HasViewings = viewings.Any(),
                Viewings = viewings.Select(x => new ViewingViewModel
                {
                    PropertyId = x.Id,
                    RequestedViewingDateTime = x.RequestedViewingDateTime,
                    CreatedAt = x.CreatedAt,
                    IsPending = x.Status == Status.Pending,
                    Status = x.Status.ToString()
                }),
                PropertyId = property.Id, 
                PropertyType = property.PropertyType,
                StreetName = property.StreetName,
                NumberOfBedrooms = property.NumberOfBedrooms,
                AskingPrice = property.AskingPrice
            };
        }
    }
}