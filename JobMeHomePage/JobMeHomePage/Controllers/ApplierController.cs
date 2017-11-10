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

        ApplierServiceClient client = new ApplierServiceClient();


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
            Applier applier = new Applier();
            applier.Password = Password;
            applier.Email = Email;

            //få de 2 passwords --- SKAL SIKRES!!!!
            if(Password == PasswordControl)
            {
                client.Create(applier);
                return RedirectToAction("Index");
            }
            else
            {
                //Giv fejl omkring at password ikke stemmer overens
            }
            
            return null;
        }
    }
}