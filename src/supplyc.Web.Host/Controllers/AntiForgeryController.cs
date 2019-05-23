using Microsoft.AspNetCore.Antiforgery;
using supplyc.Controllers;

namespace supplyc.Web.Host.Controllers
{
    public class AntiForgeryController : supplycControllerBase
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
