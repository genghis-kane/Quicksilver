using EPiServer.Web.Mvc;
using System.Web.Mvc;
using EPiServer.Reference.Commerce.Site.Features.Standard.Pages;
using EPiServer.Reference.Commerce.Site.Features.Standard.ViewModels;

namespace EPiServer.Reference.Commerce.Site.Features.Standard.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {       
        [HttpGet]
        public ActionResult Index(StandardPage currentPage)
        {
            var model = new StandardPageViewModel
            {
                CurrentPage = currentPage
            };
            return View(model);
        }
    }
}