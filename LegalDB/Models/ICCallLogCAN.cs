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
    
    public partial class ICCallLogCAN
    {
        public long IDCAN { get; set; }
        public long ID { get; set; }
        public Nullable<int> ApptCanReason { get; set; }
        public string Detail4 { get; set; }
        public Nullable<System.DateTime> ApptCanDate { get; set; }
        public Nullable<System.DateTime> CurDateTime { get; set; }
        public Nullable<int> EmployeeID { get; set; }
    }
}