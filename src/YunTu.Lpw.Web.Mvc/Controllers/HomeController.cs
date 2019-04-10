using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using YunTu.Lpw.Controllers;

namespace YunTu.Lpw.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : LpwControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
