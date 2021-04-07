using System;
using MummyProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MummyProject.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private MummyDbContext context;

        public NavigationMenuViewComponent(MummyDbContext m)
        {
            context = m;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];



            return View(context.Burial
                .Select(x => x.AgeEstimate)
                .Distinct()
                .OrderBy(x => x));
        }

    }
}
