using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DesignPatternsAsp.Controllers
{
    public class ProductDetailController : Controller
    {
        private EarnFactory _localEarnFactory;
        private ForeignEarnFactory _foreignEarnFactory;

        public ProductDetailController(LocalEarnFactory localEarnFactory,
            ForeignEarnFactory foreignEarnFactory)
        {
            _localEarnFactory = localEarnFactory;
            _foreignEarnFactory = foreignEarnFactory;
        }

        // GET: /<controller>/
        public IActionResult Index(decimal total)
        {
            //factories
            //LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.20m);
            ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.30m, 20);

            //products
            var localEarn = _localEarnFactory.GetEarn();
            var foreignEran = _foreignEarnFactory.GetEarn(); 

            //calculate earns
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEran.Earn(total);
            
            return View();
        }
    }
}

