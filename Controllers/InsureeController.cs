using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstNAme,LastNAme,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CiverageTYpe,Quote")] Table table)
        {
            //initializing base monthly quote.
            int quotebase = 50;

            //calculat the age. 
            int age = DateTime.UtcNow.Year-table.DateOfBirth.Year;

            // check the age and add then assign monthly total in Quote.
            if (age <= 18)
            {
                table.Quote = quotebase + 100;
                
            }
            else if (age >= 19 && age<= 26)
            {
                table.Quote = quotebase + 200;
                

            }
            else if (age >= 19 && age < 26)
            {
                table.Quote = quotebase + 200;
                
            }
            else if (age >= 19 && age < 26)
            {
                table.Quote = quotebase + 200;


            }

            //check a car year and set the value in tempYear varaible .
            int tempYear = (table.CarYear < 2000 || table.CarYear> 2015) ? 25: 0;
            //add the tempYear value and quote then assign the sum in quote. 
            table.Quote += tempYear;

            //compare car make and assign the price in tempMake varavle .
            int tempMake = (String.Equals(table.CarMake,"Porsche")) ? 25 : 0; 
            //add tempMake value and quote then assign the result in quote. 
            table.Quote += tempMake;


            // check the car Model and add quot with the value then assign monthly total in Quote.
            if (String.Equals(table.CarModel, "Porsche"))
            {
                if (String.Equals(table.CarModel, "911 Carrera"))
                {
                    table.Quote += 50; 
                }
                else
                {
                    table.Quote += 25;
                }
            }

            // check Speed Tickets and multipl speed Tickets then assign into ticketFree variable.
            int ticketFee = table.SpeedingTickets > 0 ? 10 * table.SpeedingTickets: 0* table.SpeedingTickets;
            //add the ticketFee value and quote then assign monthly total in Quote.
            table.Quote += ticketFee;


            //check DUI and add 50% of quote and assign in quote.
            if (table.DUI == true)
            {
                table.Quote += (table.Quote * 50) / 100;

            }


            // add in to table list and save the change.
            db.Tables.Add(table);
            db.SaveChanges();

            if (ModelState.IsValid)
            {
                db.Tables.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstNAme,LastNAme,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CiverageTYpe,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
