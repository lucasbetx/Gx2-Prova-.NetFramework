using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProvaTecGx2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Questao1()
        {
            var j = 0;
            string msg = "";

            while (j <= 100)
            {

                if (j % 2 == 0)
                {

                    if (j == 100)
                    {

                        msg += j + ". ";

                    }
                    else
                    {

                        msg += j + ", ";

                    }

                }

                j++;
            }

            ViewBag.Numbers = msg;

            return View();
        }

        public ActionResult Questao2()
        {

            return View();
        }

        public ActionResult Questao3()
        {

            return View();
        }

        public ActionResult Questao4()
        {
            return View();
        }

        public ActionResult Questao5()
        {

            return View();
        }

    }
}