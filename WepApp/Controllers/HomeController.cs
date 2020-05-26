using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WepApp.Models;

namespace WepApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Search()
        {
            ViewBag.Message = "Job Search";

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Search(SearchModel model)
        {

            if (ModelState.IsValid)
            {
        

                return RedirectToAction("SearchResults", new {description = model.description, location = model.location });
            }

            return View();
        }

        public async Task<ActionResult> SearchResults(string description, string location)
        {

            if (description.IsNullOrWhiteSpace())
            {
                return RedirectToAction("Search");
            }

            String url = $"https://jobs.github.com/positions.json?description={description}&page=0";
            String results = await RequestsModel.GetRequest(url);
            List<ResultModel> resultsModel = JsonConvert.DeserializeObject<List<ResultModel>>(results);

            return View(resultsModel);
        }
    }
}