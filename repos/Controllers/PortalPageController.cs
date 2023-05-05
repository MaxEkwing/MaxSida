//using EPiServer.Core;
//using EPiServer.Web.Mvc;
//using EPiServer.Web.Routing;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using repos.Models.Pages;
//using repos.Navigation;

//namespace repos.Controllers
//{
//    public class PortalPageController : PageControllerBase<PortalPage>
//    {
//        [HttpGet]
//        public IActionResult Index(PortalPage currentPage)
//        {
//            return View(currentPage);
//        }
//        private readonly IContentLoader _contentLoader;

//        public PortalPageController(IContentLoader contentLoader)
//        {
//            _contentLoader = contentLoader;
//        }

//        public ActionResult NavIndex(PortalPage currentPage)
//        {
//            // Load all article pages that are direct children to the current page.
//            var pages = _contentLoader.GetChildren<PortalPage>(currentPage.ContentLink);

//            // TODO: Add filter to hide unpublished pages and apply access control. 

//            var model = new PortalPageViewModel
//            {
//                CurrentPage = currentPage,
//                ListOfArticles = pages
//            };

//            return View(model);
//        }
//    }
//}

