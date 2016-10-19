using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EPiServer.Reference.Commerce.Site.Features.Standard.Pages
{
    [ContentType(
       DisplayName = "Standard page",
       GUID = "1D25FC4F-BE5D-441B-9499-68FAD3528C52",
       Description = "A standard page which allows you to define general content.",
       AvailableInEditMode = true)]
    [ImageUrl("~/styles/images/page_type.png")]
    public class StandardPage : PageData
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

        [Display(
           GroupName = SystemTabNames.Content,
           Order = 320)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}