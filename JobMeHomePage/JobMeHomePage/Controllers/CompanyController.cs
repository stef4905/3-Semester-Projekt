using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobMeHomePage.CompanyServiceReference;
using JobMeHomePage.Models;

namespace JobMeHomePage.Controllers
{
    public class CompanyController : Controller
    {
        CompanyServiceClient client = new CompanyServiceClient();

        // GET: Company
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _CreateCompany()
        {
            return PartialView();
        }   

        [HttpPost]
        public ActionResult _CreateCompany(string Email, string Password, string PasswordControl)
        {
            Company company = new Company();
            company.Email = Email;
            company.Password = Password;

            if(Password == PasswordControl)
            {
                client.Create(company);
                return RedirectToAction("Index");
            }
            else
            {
                //Giv fejl omkring at password ikke stemmer overens
            }
            
            return null;
        }

        public ActionResult CreateJobPost()
        {
            VMWorkHoursJobCategory VM = new VMWorkHoursJobCategory();
            VM.WorkHoursList = client.GetlAllWorkHours().ToList();
            return View(VM);
        }
    }
}