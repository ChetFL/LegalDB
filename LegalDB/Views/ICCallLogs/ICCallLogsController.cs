using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LegalDB.Models;

namespace LegalDB.Views.ICCallLogs
{
    public class ICCallLogsController : Controller
    {
        private LegalDBEntity db = new LegalDBEntity();

        // GET: ICCallLogs
        public async Task<ActionResult> Index()
        {
            return View(await db.ICCallLogs.ToListAsync());
        }

        // GET: ICCallLogs/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ICCallLog iCCallLog = await db.ICCallLogs.FindAsync(id);
            if (iCCallLog == null)
            {
                return HttpNotFound();
            }
            return View(iCCallLog);
        }

        // GET: ICCallLogs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ICCallLogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,CallerName,CallerPhone,EmployeeID,CallSource,CaseType,DocketFrom,CaseNo,ICStatus,SchedDate,SchedTime,LawyerID,Notes,ContactDate,SchedCall,Tickler1,ApmtOffice,FName,MName,LName,DucumentID,ConAtty,EmailAddr,ConAttyLoc")] ICCallLog iCCallLog)
        {
            if (ModelState.IsValid)
            {
                db.ICCallLogs.Add(iCCallLog);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(iCCallLog);
        }

        // GET: ICCallLogs/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ICCallLog iCCallLog = await db.ICCallLogs.FindAsync(id);
            if (iCCallLog == null)
            {
                return HttpNotFound();
            }
            return View(iCCallLog);
        }

        // POST: ICCallLogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,CallerName,CallerPhone,EmployeeID,CallSource,CaseType,DocketFrom,CaseNo,ICStatus,SchedDate,SchedTime,LawyerID,Notes,ContactDate,SchedCall,Tickler1,ApmtOffice,FName,MName,LName,DucumentID,ConAtty,EmailAddr,ConAttyLoc")] ICCallLog iCCallLog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iCCallLog).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(iCCallLog);
        }

        // GET: ICCallLogs/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ICCallLog iCCallLog = await db.ICCallLogs.FindAsync(id);
            if (iCCallLog == null)
            {
                return HttpNotFound();
            }
            return View(iCCallLog);
        }

        // POST: ICCallLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            ICCallLog iCCallLog = await db.ICCallLogs.FindAsync(id);
            db.ICCallLogs.Remove(iCCallLog);
            await db.SaveChangesAsync();
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
