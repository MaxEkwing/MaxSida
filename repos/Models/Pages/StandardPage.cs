using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace repos.Models.Pages
{
    [ContentType(
        DisplayName = "Standard page",
        GUID = "934E7266-FB8C-4DEA-B033-3B4E6AE6CBCF",
        Description = "The standard page.",
        AvailableInEditMode = true)]
    [ImageUrl("~/styles/images/page_type.png")]
    public class StandardPage : SitePageData
    {


    }
}