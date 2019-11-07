using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudDemo.Models;

namespace CrudDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            demodbEntities context = new demodbEntities();

            return View(context.DemotblEmployees.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            demodbEntities con = new demodbEntities();
            DemotblEmployee emp = con.DemotblEmployees.FirstOrDefault(x => x.Id.Equals(id));
            return View(emp);
        }

        [HttpPost]
        public ActionResult Create(DemotblEmployee emp)
        {
            demodbEntities con = new demodbEntities();
            con.DemotblEmployees.Add(emp);
            con.SaveChanges();
            return RedirectToAction("Index","Home");
        }

        public ActionResult Details(int id)
        {
            demodbEntities con = new demodbEntities();
            DemotblEmployee selectedEmployee = 
                con.DemotblEmployees.FirstOrDefault(x => x.Id == id);
                
            return View(selectedEmployee);
        }
        [HttpPost]
        public ActionResult Edit(DemotblEmployee demoemp)
        {
            demodbEntities con = new demodbEntities();
            //DemotblEmployee emp = con.DemotblEmployees.FirstOrDefault(x => x.Id.Equals(demoemp.Id));
            //emp.FullName = demoemp.FullName;
            //emp.Gender = demoemp.Gender;
            //emp.Age = demoemp.Age;
            //emp.EmailAddress = demoemp.EmailAddress;
            //emp.HireDate = demoemp.HireDate;
            //emp.Salary = demoemp.Salary;
            //emp.PersonalWebSite = demoemp.PersonalWebSite;
            con.Entry(demoemp).State = System.Data.Entity.EntityState.Modified;
            con.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            demodbEntities con = new demodbEntities();
            DemotblEmployee selectedEmployee =
                con.DemotblEmployees.FirstOrDefault(x => x.Id == id);
            return View(selectedEmployee);
        }
        [HttpPost]
        public ActionResult Delete(DemotblEmployee emp)
        {
            demodbEntities con = new demodbEntities();
            con.Entry(emp).State = System.Data.Entity.EntityState.Deleted;
            con.SaveChanges();
            return RedirectToAction("Index");
        }
        



    }
}