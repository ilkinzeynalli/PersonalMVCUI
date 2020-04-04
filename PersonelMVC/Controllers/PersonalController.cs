using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PersonelMVC.Controllers
{
    public class PersonalController:Controller
    {
        public ActionResult Index()
        {
            return Content("Personal Controller in Index Action Method");
        }

        [Route("personal/liste/{siralama?}/{sayfa?}")]
        public ActionResult PersonalLitesiGetir(string siralama,int? sayfa)
        {
            return Content(siralama + " " + sayfa);
        }
    }
}