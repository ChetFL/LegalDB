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
    
    public partial class ICCallLogRL
    {
        public long IDRL { get; set; }
        public long ID { get; set; }
        public Nullable<System.DateTime> CurDateTime { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> SignedBy { get; set; }
        public Nullable<System.DateTime> SignedByDte { get; set; }
        public Nullable<int> SignUp { get; set; }
        public string PCLawID { get; set; }
        public Nullable<System.DateTime> PCLawDte { get; set; }
        public Nullable<System.DateTime> Tickler3 { get; set; }
        public string Detail3 { get; set; }
        public Nullable<bool> Filed { get; set; }
        public Nullable<System.DateTime> FileDte { get; set; }
    }
}
