using System;
using System.Linq;
using bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace bookstore.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private IBookstoreRepository repo { get; set; }

        public TypesViewComponent(IBookstoreRepository temp)
        {
            repo = temp;
        }

        // function to grab the distinct different categories to display on the home page
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["category"];

            var types = repo.Books.Select(x => x.Category).Distinct().OrderBy(x => x);
            return View(types);
        }

    }
}
