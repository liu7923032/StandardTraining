using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using TrainCore.Controllers;

namespace TrainCore.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : TrainCoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
