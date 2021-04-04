namespace Example.Web.Areas.Default.Controllers
{
    using Example.Web.Infrastructure.Mvc;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class DashboardController : BaseDefaultController
    {
        // TODO delete
        [AllowAnonymous]
        [DefaultRoute]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
