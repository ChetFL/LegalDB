using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using LegalDB.Models;
using Syncfusion.Linq;
using System.Web.UI.WebControls;



namespace LegalDB.Controllers
{
    public class ICCallLogsController : Controller
    {
        private LegalDBWebEntities db = new LegalDBWebEntities();
        private LegalDBWebEntities db2 = new LegalDBWebEntities();


        // GET: ICCallLogs
        public async Task<ActionResult> Index()
        {
            ViewBag.datasource = new LegalDBWebEntities().ICCallLogs.OrderBy(icCallLog => icCallLog.ID).ToList();
            //ViewBag.datasource = new LegalDBWebEntities().ICCallLogs.ToList();
            var detailData = new LegalDBWebEntities().ICCallLogs.Where(icDetail => icDetail.ID == 1).Take(1).ToList();
            ViewBag.datasource = detailData;
            LegalDBWebEntities dbEmp = new LegalDBWebEntities();
            ViewBag.AnswBy = new SelectList(dbEmp.v_CivilEmp, "EmployeeID", "FirstName");
            //ViewBag.datasource = new LegalDBWebEntities().v_CivilEmp.OrderBy(vCivilEmp => vCivilEmp.EmployeeID).ToList();
            LegalDBWebEntities dbLyr = new LegalDBWebEntities();
            ViewBag.Assigned = new SelectList(dbLyr.v_Lawyers, "LawyerID", "FirstName");
            ViewBag.ConOffice = new SelectList(dbLyr.v_Lawyers, "LawyerID", "FirstName");
            //ViewBag.Datasource = new SelectList(db2.v_Lawyers,"LawyerID","FirstName");
            LegalDBWebEntities dbClSrc = new LegalDBWebEntities();
            ViewBag.RefFrom = new SelectList(dbClSrc.v_CallSource, "ID", "Descr");
            //ViewBag.datasource = new LegalDBWebEntities().v_CallSource.OrderBy(vCallSource => vCallSource.ID).ToList();
            LegalDBWebEntities dbCsTyp = new LegalDBWebEntities();
            ViewBag.CaseType = new SelectList(dbCsTyp.v_CaseType, "CaseCode", "CaseDesc");
            //ViewBag.datasource = new LegalDBWebEntities().v_CaseType.OrderBy(vCaseType => vCaseType.CaseCode).ToList();
            LegalDBWebEntities dbIcSt = new LegalDBWebEntities();
            ViewBag.IcStat = new SelectList(dbIcSt.v_ICStat, "ID", "Descr");
            //ViewBag.datasource = new LegalDBWebEntities().v_ICStat.OrderBy(vICStat => vICStat.ID).ToList();
            LegalDBWebEntities dbAttny = new LegalDBWebEntities();
            ViewBag.ConAtty = new SelectList(dbAttny.v_Attny, "LawyerID", "FirstName");
            //ViewBag.datasource = new LegalDBWebEntities().v_Attny.OrderBy(vAttny => vAttny.LawyerID).ToList();
            LegalDBWebEntities dbIcOff = new LegalDBWebEntities();
            ViewBag.ApmOffice = new SelectList(dbIcOff.v_ICOffice, "OfficeID", "OfficeName");
            //ViewBag.datasource = new LegalDBWebEntities().v_ICOffice.OrderBy(vICOffice => vICOffice.OfficeID).ToList();


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
        public async Task<ActionResult> Create([Bind(Include = "ID,CallerName,FName,MName,LName,CallerPhone,Email,EmployeeID,CallSource,LtrID,DocketFrom,CaseNo,CaseType,ICStatus,Sched,SchedDate,SchedTime,ApmtLawyerID,ApmtOfficeID,ConAtty,ContactDate,Notes,Tickler")] ICCallLog iCCallLog)
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
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                id = 128;
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
        public async Task<ActionResult> Edit([Bind(Include = "ID,CallerName,FName,MName,LName,CallerPhone,Email,EmployeeID,CallSource,LtrID,DocketFrom,CaseNo,CaseType,ICStatus,Sched,SchedDate,SchedTime,ApmtLawyerID,ApmtOfficeID,ConAtty,ContactDate,Notes,Tickler")] ICCallLog iCCallLog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iCCallLog).State = System.Data.Entity.EntityState.Modified;
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

        //public static List<SelectListItem> AnswBy(int id)
        //{
        //    List<SelectListItem> ls = new List<SelectListItem>() { };
        //    var lm = new LegalDBWebEntities3().v_CivilEmp.ToList();
        //    foreach (var temp in lm)
        //    {
        //        ls.Add(new SelectListItem() { Text = temp.FirstName, Value = temp.EmployeeID.ToString() });
        //    }
        //    return ls;
        //}

        //public ActionResult NavFirstRec()
        //{
        //    var firstID = db.ICCallLogs.OrderBy(i => i,Pk).First(i => i.Pk > ICCallLog.Pk).Pk;
        //    ViewBag.firstID = firstID;
        //    return View(ICCallLog);
        //}

        //public ActionResult RecNav(int? recno)
        //{
        //    var detailData = new LegalDBWebEntities1().ICCallLogs.Where(icDetail => icDetail.ID == 1).Take(1).ToList();
        //    int max = detailData.Count;

        //    int currentIndex = recno.GetValueOrDefault();
        //    if (currentIndex != 0)
        //    {
        //        ViewBag.FirstRecno = 1;
        //    }
        //    else if (currentIndex == 0)
        //    {
        //        ViewBag.NextRecno = 1;
        //    }
        //    else if (currentIndex >= max)
        //    {
        //        currentIndex = max;
        //        ViewBag.PreviousIndex = currentIndex - 1;
        //    }
        //    else
        //    {
        //        ViewBag.PreviousIndex = currentIndex - 1;
        //        ViewBag.NextRecno = currentIndex + 1;
        //    }

        //    ICCallLog model = db.Database.SqlQuery<ICCallLog>("usp_studentdetails")
        //        .Skip(currentIndex).Take(1).FirstOrDefault();

        //    return View(model);
        //}

        //public ActionResult DisableTimeRange()
        //{
        //    TimePickerProperties propModel = new TimePickerProperties();
        //    List<DisableTimeRange> disableList = new List<Syncfusion.JavaScript.Models.DisableTimeRange>();
        //    disableList.Add(new DisableTimeRange { StartTime = "12:00 AM", EndTime = "8:30 AM" });
        //    disableList.Add(new DisableTimeRange { StartTime = "5:00 PM", EndTime = "12:00 AM" });
        //    //disableList.Add(new DisableTimeRange { StartTime = "8:00 PM", EndTime = "10:00 PM" });

        //    propModel.DisableTimeRanges = disableList;
        //    return View(propModel);
        //}

    }

    //public class PageService
    //{
    //    public LegalDBWebEntities db = new LegalDBWebEntities();
    //    public LegalDBWebEntities _context;

    //    public PageService(LegalDBWebEntities context)
    //    {
    //        _context = context;
    //    }

    //    public NavigationDetails GetNavigationFor(int pageId)
    //    {
    //        var previousPage = _context.Pages.OrderByDescending(p => p.Created).Where(p => p.Id < pageId).FirstOrDefault();
    //        var nextPage = _context.Pages.OrderBy(p => p.Created).Where(p => p.Id > pageId).FirstOrDefault();
    //        var currentPage = _context.Pages.FirstOrDefault(p => p.Id == pageId);

    //        return new NavigationDetails()
    //        {
    //            PreviousPage = previousPage,
    //            NextPage = nextPage,
    //            CurrentPage = currentPage
    //        };
    //    }

    //}
    //public class NavigationDetails
    //{
    //    public Page FirstPage { get; set; }
    //    public Page PreviousPage { get; set; }
    //    public Page CurrentPage { get; set; }
    //    public Page NextPage { get; set; }
    //    public Page LastPage { get; set; }

    //    public bool HasPreviousPage()
    //    {
    //        return (PreviousPage != null);
    //    }

    //    public bool HasNextPage()
    //    {
    //        return (NextPage != null);
    //    }
    //}

    //public class MyDbContext : DbContext
    //{
    //    public MyDbContext(string nameOrConnectionString)
    //        : base(nameOrConnectionString)
    //    {
    //    }

    //    public DbSet<Page> Pages { get; set; }

    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Configurations.Add(new PageMap());
    //    }

    //}

    //public class PageMap : EntityTypeConfiguration<Page>
    //{

    //    public PageMap()
    //    {
    //        ToTable("ICCallLogs");

    //        //Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    //        //Property(m => m.CallerName);
    //        //Property(m => m.Created);
    //    }

    //}

    //public class Page
    //{
    //    DbSet<ICCallLog> ICCallLogs { get; set; }
    //    //public int Id { get; set; }
    //    //public string CallerName { get; set; }
    //    //public DateTime Created { get; set; }
    //}

}
