using System.Web.Mvc;
using OrangeBricks.Web.Attributes;
using OrangeBricks.Web.Controllers.Offers.Builders;
using OrangeBricks.Web.Controllers.Offers.Commands;
using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Offers
{
    public class OffersController : Controller
    {
        private readonly IOrangeBricksContext _context;

        public OffersController(IOrangeBricksContext context)
        {
            _context = context;
        }

        [OrangeBricksAuthorize(Roles = "Seller")]
        public ActionResult OnProperty(int id)
        {
            var builder = new OffersOnPropertyViewModelBuilder(_context);
            var viewModel = builder.Build(id);

            return View(viewModel);
        }

        [OrangeBricksAuthorize(Roles = "Seller")]
        [HttpPost]        
        public ActionResult Accept(AcceptOfferCommand command)
        {
            var handler = new AcceptOfferCommandHandler(_context);

            handler.Handle(command);

            return RedirectToAction("OnProperty", new { id = command.PropertyId });
        }

        [OrangeBricksAuthorize(Roles = "Seller")]
        [HttpPost]
        public ActionResult Reject(RejectOfferCommand command)
        {
            var handler = new RejectOfferCommandHandler(_context);

            handler.Handle(command);

            return RedirectToAction("OnProperty", new { id = command.PropertyId });
        }

        [OrangeBricksAuthorize(Roles = "Buyer")]
        public ActionResult MyOffersOnProperty()
        {

            var builder = new OffersOnPropertyViewModelBuilder(_context);
            // Please Note: This is incomplete and returns only the first offer record
            var viewModel = builder.Build(1);

            return View(viewModel);
        }
    }
}