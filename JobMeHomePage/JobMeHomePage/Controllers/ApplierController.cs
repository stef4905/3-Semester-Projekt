using JobMeHomePage.ApplierServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobMeHomePage.JobPostServiceReference;
using JobMeHomePage.Models;
using JobMeHomePage.JobCVServiceReference;
using JobMeHomePage.JobApplicationServiceReference;

namespace JobMeHomePage.Controllers
{
    public class ApplierController : Controller
    {

        ApplierServiceClient client = new ApplierServiceClient();
        JobPostServiceClient jobClient = new JobPostServiceClient();
        JobCVServiceClient jobCVClient = new JobCVServiceClient();
        JobApplicationServiceClient jobApplicationClient = new JobApplicationServiceClient();


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
            if (Password == PasswordControl)
            {
                client.Create(applier);
                Session["applier"] = applier;
                return RedirectToAction("Index");
            }
            else
            {
                //Giv fejl omkring at password ikke stemmer overens!
            }

            return null;
        }

        public ActionResult JobCV()
        {
            return View();
            //Get the jobcv from the profile currently logged in
            //Return view with the JobCV object
            //If button "Gem oplysninger" is pressed get all information from the site
            //Assign the infomation to the JobCV object for the profile
            //Update in database

            //If button "Annuler/Gå tilbage" is pressed, dispose all changes
            //Return user to profile site
        }


        public ActionResult FindJobPosts()
        {
            VMJobPostWorkHoursJobCategory VM = new VMJobPostWorkHoursJobCategory();

            VM.JobPostList = jobClient.GetAllJobPost().ToList();
            VM.JobCategoryList = jobClient.GetAllJobCategories().ToList();
            VM.WorkHoursList = jobClient.GetlAllWorkHours().ToList();

            return View(VM);
        }

        [HttpPost]
        public ActionResult FindJobPosts(string search, int km, int category, int workHours)
        {
            VMJobPostWorkHoursJobCategory VM = new VMJobPostWorkHoursJobCategory();
            VM.JobPostList = jobClient.GetAllJobPost().ToList();
            List<JobPost> JobPostsList = new List<JobPost>();

            foreach (var jobPosts in VM.JobPostList.Where(f => f.Title.ToLower().Contains(search.ToLower()) ||
            f.company.CompanyName.ToLower().Contains(search.ToLower())))
            {

                if (workHours == 0 && category == 0 && km == 0)
                {
                    JobPostsList.Add(jobPosts);

                }
                if (km != 0 || workHours != 0 || category != 0)
                {
                    if (jobPosts.workHours.Id == workHours || jobPosts.jobCategory.Id == category)
                    {
                        JobPostsList.Add(jobPosts);
                    }
                }
            }
            VM.JobPostList = JobPostsList.ToList();
            VM.JobCategoryList = jobClient.GetAllJobCategories().ToList();
            VM.WorkHoursList = jobClient.GetlAllWorkHours().ToList();
            ViewBag.SearchField = "Søgeord:" + search;
            return View(VM);
        }




        #region JobApplication
        public ActionResult JobApplication(int id)
        {
            //Hovedside til jobapplikation og cv of the applier
            Applier applier = client.GetApplier(id);
            JobCV jobCV = jobCVClient.Get(applier.Id);


            VMJobCVAndApplication vmJobCVAndApplication = new VMJobCVAndApplication
            {
                Applier = applier,
                jobApplication = jobApplicationClient.Get(applier.Id),
                JobCV = jobCV
            };
            return View(vmJobCVAndApplication);
        }

        public ActionResult _JobApplication(VMJobCVAndApplication vMJobAndApplication)
        {
            //Job applikation siden kun ikke lavet endnu i WCF
            return PartialView(vMJobAndApplication);
        }

        public ActionResult _JobCV(JobCV jobCV)
        {
            //Job CV sien kun
            return View(jobCV);
        }
        #endregion





        public ActionResult ApplierProfile(int id)
        {
            Applier applier = client.GetApplier(id);
            return View(applier);
        }

        public ActionResult _Login()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult _Login(string email, string password)
        {
            //sende password ned med Hashing!!!
            Applier applier = client.Login(email, password);
            Session["applier"] = applier;
            return RedirectToAction("Index");
        }

        public ActionResult _CurrentUser()
        {
            Applier applier = new Applier();

            //Mangler fagterm.
            applier = Session["applier"] as Applier;

            return PartialView(applier);
        }
    }
}