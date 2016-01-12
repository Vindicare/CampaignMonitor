using CampaignMonitor.Dependency;
using CampaignMonitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CampaignMonitor.Controllers
{
    public class DotNetController : Controller
    {
        private IDotNetManager _dotNetManager;
        protected IDotNetManager DotNetManager
        {
            get
            {
                return _dotNetManager = _dotNetManager ?? UnityHelper.Resolve<IDotNetManager>();
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPositiveDivisors(int number)
        {
            var result = DotNetManager.GetPositiveDivisors(number);
            var resultText = string.Join(", ", result);
            return Json(resultText, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetSurfaceArea(int sideA, int sideB, int sideC)
        {
            var result = DotNetManager.GetSurfaceArea(sideA, sideB, sideC);
            return Json(result.ToString(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult FindCommonElements(string intArrayValues)
        {
            var numberTextArray = intArrayValues.Split(',').Select(x => x);
            int[] numberArray = numberTextArray.Select(int.Parse).ToArray();
            var result = DotNetManager.FindCommonElements(numberArray);
            var resultText = string.Join(", ", result);
            return Json(resultText, JsonRequestBehavior.AllowGet);
        }
    }
}
