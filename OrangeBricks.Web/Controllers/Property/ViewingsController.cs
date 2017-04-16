using System.Collections;
using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using OrangeBricks.Web.Attributes;
using OrangeBricks.Web.Controllers.Property.Builders;
using OrangeBricks.Web.Controllers.Property.Commands;
using OrangeBricks.Web.Controllers.Property.ViewModels;
using OrangeBricks.Web.Models;
using System.Collections.Generic;
using OrangeBricks.Web.Controllers.Offers.ViewModels;
using System.Data.Entity;
using OrangeBricks.Web.Controllers.Offers.Builders;

namespace OrangeBricks.Web.Controllers.Property
{
    public class ViewingsController : Controller
    {
        private readonly IOrangeBricksContext _context;

        //// GET: Viewings
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ViewingsController(IOrangeBricksContext context)
        {
            _context = context;
        }

        public ActionResult OnViewing(int id)
        {
            var builder = new ViewRequestsOnPropertyViewModelBuilder(_context);
            var viewModel = builder.Build(id);

            return View(viewModel);
        }
    }
}
