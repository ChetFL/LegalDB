using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using System.Web.UI;
using LegalDB.Models;
using Syncfusion.Linq;
using System.Web.UI.WebControls;
using PagedList.Mvc;
using LegalDB.Models;
using LegalDB.Repositories;
using PagedList;


namespace LegalDB.Controllers
{
    public class ICCallLogsController : Controller
    {
        private Models.LegalDBWebEntities db = new Models.LegalDBWebEntities();
        private Models.LegalDBWebEntities db2 = new Models.LegalDBWebEntities();
        //Property of the type IRepository <TEnt, in TPk>
        //private IRepository<ICCallLog, int> _repository;


        // GET: ICCallLogs
        public async Task<ActionResult> Index(int? page)
        {
            int pageSize = 1;
            int pageNumber = (page ?? 1);
            ViewBag.datasource = new LegalDBWebEntities().ICCallLogs.OrderBy(icCallLog => icCallLog.ID).ToList();
            //ViewBag.datasource = new LegalDBWebEntities().ICCallLogs.ToList();
            var detailData = new LegalDBWebEntities().ICCallLogs.Where(icDetail => icDetail.ID == pageNumber).Take(1).ToList();
            ViewBag.datasource1 = detailData;
            Models.LegalDBWebEntities dbEmp = new Models.LegalDBWebEntities();
            ViewBag.AnswBy = new SelectList(dbEmp.v_CivilEmp, "EmployeeID", "FirstName");
            //ViewBag.datasource = new LegalDBWebEntities().v_CivilEmp.OrderBy(vCivilEmp => vCivilEmp.EmployeeID).ToList();
            Models.LegalDBWebEntities dbLyr = new Models.LegalDBWebEntities();
            ViewBag.Assigned = new SelectList(dbLyr.v_Lawyers, "LawyerID", "FirstName");
            ViewBag.ConOffice = new SelectList(dbLyr.v_Lawyers, "LawyerID", "FirstName");
            //ViewBag.Datasource = new SelectList(db2.v_Lawyers,"LawyerID","FirstName");
            Models.LegalDBWebEntities dbClSrc = new Models.LegalDBWebEntities();
            ViewBag.RefFrom = new SelectList(dbClSrc.v_CallSource, "ID", "Descr");
            //ViewBag.datasource = new LegalDBWebEntities().v_CallSource.OrderBy(vCallSource => vCallSource.ID).ToList();
            Models.LegalDBWebEntities dbCsTyp = new Models.LegalDBWebEntities();
            ViewBag.CaseType = new SelectList(dbCsTyp.v_CaseType, "CaseCode", "CaseDesc");
            //ViewBag.datasource = new LegalDBWebEntities().v_CaseType.OrderBy(vCaseType => vCaseType.CaseCode).ToList();
            Models.LegalDBWebEntities dbIcSt = new Models.LegalDBWebEntities();
            ViewBag.IcStat = new SelectList(dbIcSt.v_ICStat, "ID", "Descr");
            //ViewBag.datasource = new LegalDBWebEntities().v_ICStat.OrderBy(vICStat => vICStat.ID).ToList();
            Models.LegalDBWebEntities dbAttny = new Models.LegalDBWebEntities();
            ViewBag.ConAtty = new SelectList(dbAttny.v_Attny, "LawyerID", "FirstName");
            //ViewBag.datasource = new LegalDBWebEntities().v_Attny.OrderBy(vAttny => vAttny.LawyerID).ToList();
            Models.LegalDBWebEntities dbIcOff = new Models.LegalDBWebEntities();
            ViewBag.ApmOffice = new SelectList(dbIcOff.v_ICOffice, "OfficeID", "OfficeName");
            ViewBag.ConOffice = new SelectList(dbIcOff.v_ICOffice, "OfficeID", "OfficeName");
            //ViewBag.datasource = new LegalDBWebEntities().v_ICOffice.OrderBy(vICOffice => vICOffice.OfficeID).ToList();
            var tp = new LegalDBWebEntities().ICCallLogs;
            //Used the following two formulas so that it doesn't round down on the returned integer
            decimal totalPages = ((decimal)(tp.Count() / (decimal)pageSize));
            ViewBag.TotalPages = System.Math.Ceiling(totalPages);
            //ViewModel.ICCallLogs = IndexViewModel.ICCallLogs.ToPagedList(pageNumber, pageSize);
            //ViewBag.OnePageofTeachers = viewModel.Teachers;
            ViewBag.PageNumber = pageNumber;


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
            id = 1;
            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                id =128;
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
    //    public Models.LegalDBWebEntities db = new Models.LegalDBWebEntities();
    //    public Models.LegalDBWebEntities _context;
    //    PageService service = new PageService(db);

    //    public PageService(Models.LegalDBWebEntities context)
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

    //public class LegalDBWebEntities : DbContext
    //{
    //    public LegalDBWebEntities(string nameOrConnectionString)
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

    //        Property(m => m.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    //        Property(m => m.CallerName);
    //        Property(m => m.CallerPhone);
    //        Property(m => m.EmployeeID);
    //        Property(m => m.CallSource);
    //        Property(m => m.CaseType);
    //        Property(m => m.DocketFrom);
    //        Property(m => m.CaseNo);
    //        Property(m => m.ICStatus);
    //        Property(m => m.SchedDate);
    //        Property(m => m.SchedTime);
    //        Property(m => m.LawyerID);
    //        Property(m => m.Notes);
    //        Property(m => m.ContactDate);
    //        Property(m => m.SchedCall);
    //        Property(m => m.Tickler1);
    //        Property(m => m.ApmtOffice);
    //        Property(m => m.FName);
    //        Property(m => m.MName);
    //        Property(m => m.LName);
    //        Property(m => m.DucumentID);
    //        Property(m => m.ConAtty);
    //        Property(m => m.EmailAddr);
    //        Property(m => m.ConAttyLoc);
    //    }

    //}

    //public class Page
    //{
    //    //DbSet<ICCallLog> ICCallLogs { get; set; }
    //    public int ID { get; set; }
    //    public string CallerName { get; set; }
    //    public string CallerPhone { get; set; }
    //    public int EmployeeID { get; set; }
    //    public int CallSource { get; set; }
    //    public string CaseType { get; set; }
    //    public string DocketFrom { get; set; }
    //    public string CaseNo { get; set; }
    //    public int ICStatus { get; set; }
    //    public System.DateTime SchedDate { get; set; }
    //    public System.TimeSpan SchedTime { get; set; }
    //    public int LawyerID { get; set; }
    //    public string Notes { get; set; }
    //    public System.DateTime ContactDate { get; set; }
    //    public bool SchedCall { get; set; }
    //    public System.DateTime Tickler1 { get; set; }
    //    public int ApmtOffice { get; set; }
    //    public string FName { get; set; }
    //    public string MName { get; set; }
    //    public string LName { get; set; }
    //    public int DucumentID { get; set; }
    //    public int ConAtty { get; set; }
    //    public string EmailAddr { get; set; }
    //    public string ConAttyLoc { get; set; }
    //}.

    //public class Navigation
    //{
        //private Models.LegalDBWebEntities db = new Models.LegalDBWebEntities();

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="page"></param>
        ///// <returns></returns>
        //public LegalDBWebEntities(). Page(int? page)
        //{
        //    var Calls = from s in db.ICCallLogs
        //                select s;
        //    if (page != null)
        //    {
        //        Calls = Calls.Where(s => s.ID.Equals(page));
        //    }
        //    int pageSize = 1;
        //    int pageNumber = (page ?? 1);
        //    //IPagedList<Calls> lst = data.ToPagedList(pageSize, pageNumber);
        //    return Calls;

        //}
    //}
}
