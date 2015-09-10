using PhotoFundao.App;
using PhotoFundao.Configuration.Factories;
using System.Web.Mvc;

namespace PhotoFundao.Controllers
{
    public class CustomerController : Controller
    {
        public CustomerManager Manager { get; set; }

        public CustomerController()
        {
            Manager = Factory.Get<CustomerManager>();
        }

        // GET: Customer
        public JsonResult Index()
        {
            var customers = Manager.GetAllActive();
            return Json(customers, JsonRequestBehavior.AllowGet);
        }
    }
}