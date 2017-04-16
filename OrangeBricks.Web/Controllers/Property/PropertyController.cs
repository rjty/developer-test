using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using OrangeBricks.Web.Attributes;
using OrangeBricks.Web.Controllers.Property.Builders;
using OrangeBricks.Web.Controllers.Property.Commands;
using OrangeBricks.Web.Controllers.Property.ViewModels;
using OrangeBricks.Web.Models;
using System.Collections.Generic;
using OrangeBricks.Web.Controllers.Offers.Builders;

namespace OrangeBricks.Web.Controllers.Property
{
    public class PropertyController : Controller
    {
        private readonly IOrangeBricksContext _context;

        public PropertyController(IOrangeBricksContext context)
        {
            _context = context;
        }

        [Authorize]
        public ActionResult Index(PropertiesQuery query)
        {
            var builder = new PropertiesViewModelBuilder(_context);
            var viewModel = builder.Build(query);

            return View(viewModel);
        }


        [OrangeBricksAuthorize(Roles = "Seller")]
        public ActionResult Create()
        {
            var viewModel = new CreatePropertyViewModel();

            viewModel.BedroomCount = new List<SelectListItem> {
             new SelectListItem { Value = "0", Text = "None"},
             new SelectListItem { Value = "1", Text = "One"},
             new SelectListItem { Value = "2", Text = "Two"},
             new SelectListItem { Value = "3", Text = "Three"},
             new SelectListItem { Value = "4", Text = "Four"},
             new SelectListItem { Value = "5", Text = "Five"},
             new SelectListItem { Value = "6", Text = "Six"},
             new SelectListItem { Value = "7", Text = "Seven"},
             new SelectListItem { Value = "8", Text = "Eight"},
            };

            viewModel.PossiblePropertyTypes = new string[] { "House", "Flat", "Bungalow" }
                .Select(x => new SelectListItem { Value = x, Text = x })
                .AsEnumerable();

            return View(viewModel);
        }

        [OrangeBricksAuthorize(Roles = "Seller")]
        [HttpPost]
        public ActionResult Create(CreatePropertyCommand command)
        {
            var handler = new CreatePropertyCommandHandler(_context);

            command.SellerUserId = User.Identity.GetUserId();

            handler.Handle(command);

            return RedirectToAction("MyProperties");
        }


        [OrangeBricksAuthorize(Roles = "Seller")]
        public ActionResult MyProperties()
        {
            var builder = new MyPropertiesViewModelBuilder(_context);
            var viewModel = builder.Build(User.Identity.GetUserId());

            return View(viewModel);
        }


        [HttpPost]
        [OrangeBricksAuthorize(Roles = "Seller")]
        public ActionResult ListForSale(ListPropertyCommand command)
        {
            var handler = new ListPropertyCommandHandler(_context);

            handler.Handle(command);

            return RedirectToAction("MyProperties");
        }


        [OrangeBricksAuthorize(Roles = "Buyer")]
        public ActionResult MakeOffer(int id)
        {
            var builder = new MakeOfferViewModelBuilder(_context);
            var viewModel = builder.Build(id);
            return View(viewModel);
        }

        [HttpPost]
        [OrangeBricksAuthorize(Roles = "Buyer")]
        public ActionResult MakeOffer(MakeOfferCommand command)
        {
            var messagePass = "Your Offer has been Saved";
            var messageFail = "Your Offer has not been Saved. Please try Again";
            var handler = new MakeOfferCommandHandler(_context);

            handler.Handle(command);

            if (ModelState.IsValid)
            {
                TempData["message"] = messagePass; 
            }
            else
            {
                TempData["message"] = messageFail; 
            }

            return RedirectToAction("Index");
        }


        [OrangeBricksAuthorize(Roles = "Buyer")]
        public ActionResult BookViewing(int id)
        {
            var builder = new BookViewingViewModelBuilder(_context);
            var viewModel = builder.Build(id);
            return View(viewModel);
        }

        [HttpPost]
        [OrangeBricksAuthorize(Roles = "Buyer")]
        public ActionResult BookViewing(BookViewingCommand command)
        {
            var messageFail = "Your Booking Request has not been Saved. Please try Again";
            var messagePass = "Your Booking Request has been made. You will recieve an e-mail to confirm the appointment time.";

            var handler = new BookViewingCommandHandler(_context);
            handler.Handle(command);

            if (ModelState.IsValid)
            {
                TempData["message"] = messagePass; 
            }
            else
            {
                TempData["message"] = messageFail; 
            }

            return RedirectToAction("Index");
        }
    }
}