using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using(InsuranceEntities db = new InsuranceEntities())
            {
                var issuedPol = db.Insurees;
                var newPol = new List<Quotesvm>();
                foreach (var policies in issuedPol)
                {
                    var issNewPol = new Quotesvm();
                    issNewPol.FirstName = policies.FirstName;
                    issNewPol.LastName = policies.LastName;
                    issNewPol.EmailAddress = policies.EmailAddress;
                    issNewPol.Quote = policies.Quote;
                    newPol.Add(issNewPol);
                }
                return View(newPol);
            }
        }
    }
}