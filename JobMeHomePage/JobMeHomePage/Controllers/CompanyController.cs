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
        JobPostServiceReference.JobPostServiceClient jobClient = new JobPostServiceReference.JobPostServiceClient();

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

            if (Password == PasswordControl)
            {
                client.Create(company);
                // Creates session on creation of user
                Session["company"] = company;
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
            VM.JobCategoryList = client.GetAllJobCategories().ToList();
            return View(VM);
        }

        [HttpPost]
        public ActionResult CreateJobPost(string Title, string Description, DateTime StartDate, DateTime EndDate, string JobTitle, int WorkHours, string Address, Company Company, int JobCategory)
        {
            WorkHours workHours = new WorkHours { Id = WorkHours };

            JobCategory jobCategory = new JobCategory { Id = JobCategory };
            Company company = new Company { Id = 1 };

            JobPost jobPost = new JobPost
            {
                Title = Title,
                Description = Description,
                StartDate = StartDate.Date,
                EndDate = EndDate.Date,
                JobTitle = JobTitle,
                workHours = workHours,
                Address = Address,
                company = company,
                jobCategory = jobCategory


            };
            try
            {
                client.CreateJobPost(jobPost);
                return RedirectToAction("Index");
            }




            catch (Exception)
            {

                throw;
            }

        }


        public ActionResult JobPost(int id)
        {
            JobPostServiceReference.JobPost jobPost = jobClient.Get(id);
            return View(jobPost);
        }

        [HttpPost]
        public ActionResult _Login(string email, string password)
        {
            Company company = client.Login(email, password);

            // Creates sessions for company login
            Session["company"] = company;

            return RedirectToAction("Index");
        }

        public ActionResult _CurrentCompany() {
            Company company = new Company();
            // Mangler fagterm på as
            company = Session["company"] as Company;
            return PartialView(company);
        }
    }
}