using System.ComponentModel.DataAnnotations;

namespace repos.Models.Blocks
{
    [ContentType(DisplayName = "CaseBlock",
                  GUID = "30685434-33DE-42AF-88A7-3126B936AEAD",
                  Description = "Cases.")]
    public class AccordionBlock : SiteBlockData
    {
        [Display(
    GroupName = SystemTabNames.Content,
    Order = 1)]
        [CultureSpecific]
        public virtual string Heading { get; set; }

        [Display(
    GroupName = SystemTabNames.Content,
    Order = 2)]
        [CultureSpecific]
        public virtual string Description { get; set; }
    }
}
