﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LegalDB.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LegalDBWebEntities : DbContext
    {
        public LegalDBWebEntities()
            : base("name=LegalDBWebEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BestCaseLogin> BestCaseLogins { get; set; }
        public virtual DbSet<CaseType> CaseTypes { get; set; }
        public virtual DbSet<chkCityName> chkCityNames { get; set; }
        public virtual DbSet<ChkNmSfx> ChkNmSfxes { get; set; }
        public virtual DbSet<CivilLetter> CivilLetters { get; set; }
        public virtual DbSet<CivilWkMnth> CivilWkMnths { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<CrashRpt> CrashRpts { get; set; }
        public virtual DbSet<CrashRptAgency> CrashRptAgencies { get; set; }
        public virtual DbSet<CrashRptMotorist> CrashRptMotorists { get; set; }
        public virtual DbSet<CrashRptOccInjury> CrashRptOccInjuries { get; set; }
        public virtual DbSet<CrashRptOccSeatPos> CrashRptOccSeatPos { get; set; }
        public virtual DbSet<CrashRptOccup> CrashRptOccups { get; set; }
        public virtual DbSet<CrashRptSeverity> CrashRptSeverities { get; set; }
        public virtual DbSet<CrashRptVeh> CrashRptVehs { get; set; }
        public virtual DbSet<CrashRptVehBody> CrashRptVehBodies { get; set; }
        public virtual DbSet<CrashRptVehDamScale> CrashRptVehDamScales { get; set; }
        public virtual DbSet<CrashRptVehSpecFunc> CrashRptVehSpecFuncs { get; set; }
        public virtual DbSet<CrashRptVehTypeUse> CrashRptVehTypeUses { get; set; }
        public virtual DbSet<CrashRptVehUnitType> CrashRptVehUnitTypes { get; set; }
        public virtual DbSet<DefaultSchedule> DefaultSchedules { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DNSAddr> DNSAddrs { get; set; }
        public virtual DbSet<DNSName> DNSNames { get; set; }
        public virtual DbSet<EmpType> EmpTypes { get; set; }
        public virtual DbSet<Jurisdiction> Jurisdictions { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LegalDBLogin> LegalDBLogins { get; set; }
        public virtual DbSet<NeedlesLogin> NeedlesLogins { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<PCLawLogin> PCLawLogins { get; set; }
        public virtual DbSet<PoliceDept> PoliceDepts { get; set; }
        public virtual DbSet<QuickBookLogin> QuickBookLogins { get; set; }
        public virtual DbSet<RptList> RptLists { get; set; }
        public virtual DbSet<RptMailingList> RptMailingLists { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tickler> Ticklers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ICCallLog> ICCallLogs { get; set; }
        public virtual DbSet<ICSource> ICSources { get; set; }
        public virtual DbSet<ICStatu> ICStatus { get; set; }
        public virtual DbSet<ICTask> ICTasks { get; set; }
        public virtual DbSet<Lawyer> Lawyers { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<WBCT12> WBCT12 { get; set; }
        public virtual DbSet<v_Attny> v_Attny { get; set; }
        public virtual DbSet<v_CallSource> v_CallSource { get; set; }
        public virtual DbSet<v_CaseType> v_CaseType { get; set; }
        public virtual DbSet<v_CivilEmp> v_CivilEmp { get; set; }
        public virtual DbSet<v_ICLkUp> v_ICLkUp { get; set; }
        public virtual DbSet<v_ICOffice> v_ICOffice { get; set; }
        public virtual DbSet<v_ICStat> v_ICStat { get; set; }
        public virtual DbSet<v_Lawyers> v_Lawyers { get; set; }
        public virtual DbSet<v_LetterInfo> v_LetterInfo { get; set; }
    }
}
