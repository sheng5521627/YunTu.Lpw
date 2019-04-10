using Microsoft.AspNetCore.Antiforgery;
using YunTu.Lpw.Controllers;

namespace YunTu.Lpw.Web.Host.Controllers
{
    public class AntiForgeryController : LpwControllerBase
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
