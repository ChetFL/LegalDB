//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ICCallLogSgn
    {
        public long ID { get; set; }
        public long ICID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> SignedAtty { get; set; }
        public Nullable<System.DateTime> SignedDte { get; set; }
        public Nullable<int> CaseType { get; set; }
        public string PCLawID { get; set; }
        public Nullable<System.DateTime> PCLawDte { get; set; }
        public string Notes { get; set; }
        public Nullable<bool> Filed { get; set; }
        public Nullable<System.DateTime> FileDte { get; set; }
    }
}