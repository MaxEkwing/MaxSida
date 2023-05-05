//using EPiServer.Core;
//using EPiServer.Web.Mvc;
//using EPiServer.Web.Routing;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using repos.Models.Pages;
//using repos.Navigation;

//namespace repos.Controllers
//{
//    public class StandardPageController : PageControllerBase<StandardPage>
//    {
//        [HttpGet]
//        public IActionResult Index(StandardPage currentPage)
//        {
//            return View(currentPage);
//        }
//        private readonly IContentLoader _contentLoader;

//        public StandardPageController(IContentLoader contentLoader)
//        {
//            _contentLoader = contentLoader;
//        }

//        public ActionResult NavIndex(StandardPage currentPage)
//        {
//            // Load all article pages that are direct children to the current page.
//            var pages = _contentLoader.GetChildren<StandardPage>(currentPage.ContentLink);

//            // TODO: Add filter to hide unpublished pages and apply access control. 

//            var model = new StandardPageViewModel
//            {
//                CurrentPage = currentPage,
//                ListOfArticles = pages
//            };

//            return View(model);
//        }
//    }
//}