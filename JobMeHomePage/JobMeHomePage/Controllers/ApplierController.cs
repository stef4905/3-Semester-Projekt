using JobMeHomePage.ApplierServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace JobMeHomePage.Controllers
{
    public class ApplierController : Controller
    {
        IApplierService client = new IApplierService();


        // GET: Applier
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _CreateApplier()
        {
            return PartialView();

        }

        [HttpPost]
        public ActionResult _CreateApplier(string Email, string Password, string PasswordControl)
        {
            //få de 2 passwords --- SKAL SIKRES!!!!
            if(Password == PasswordControl)
            {
                client.
            }
            else
            {

            }
            //Tjekke om de er ens
            //Kalde WCF'en for at oprette bruger i Database
            return null;
        }
    }
}