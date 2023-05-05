using repos.Models.Pages;

namespace repos.Navigation
{
    public class PortalPageViewModel
    {
        public IEnumerable<PortalPage> ListOfArticles { get; set; }
        public PortalPage CurrentPage { get; set; }
    }
}
