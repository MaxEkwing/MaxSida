using EPiServer.SpecializedProperties;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace repos.Models.Pages;

/// <summary>
/// Base class for all page types
/// </summary>
public abstract class SitePageData : PageData
{
    [CultureSpecific]
    [Display(
               Name = "Title",
               Description = "Title for the page",
               GroupName = SystemTabNames.Content,
               Order = 1)]
    public virtual string Title { get; set; }

    [CultureSpecific]
    [Display(
           Name = "Main body",
           Description = "Main body",
           GroupName = SystemTabNames.Content,
           Order = 2)]
    public virtual XhtmlString MainBody { get; set; }
    [CultureSpecific]
    public virtual LinkItemCollection RelatedContentLinks { get; set; }

    
}
