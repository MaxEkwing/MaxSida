using repos.Models.Pages;

namespace repos.Navigation
{
    public class StandardPageViewModel
    {
        public IEnumerable<StandardPage> ListOfArticles { get; set; }
        public StandardPage CurrentPage { get; set; }
    }
}
 