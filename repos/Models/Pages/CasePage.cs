using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System.ComponentModel.DataAnnotations;

namespace repos.Models.Pages
{
    [ContentType(
        DisplayName = "Portal page",
        GUID = "00f6f6b9-7048-478b-8e43-e1ec1992d4c9",
        Description = "The Case page.",
        AvailableInEditMode = true)]
    [ImageUrl("~/styles/images/page_type.png")]
    public class CasePage : SitePageData
    {

    }
}
