using Microsoft.AspNetCore.Antiforgery;
using TrainCore.Controllers;

namespace TrainCore.Web.Host.Controllers
{
    public class AntiForgeryController : TrainCoreControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
