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
    
    public partial class CivilWkMnth
    {
        public long ID { get; set; }
        public int Year { get; set; }
        public int YearNo { get; set; }
        public int Mnth { get; set; }
        public Nullable<System.DateTime> MnthStrt { get; set; }
        public Nullable<System.DateTime> MnthEnd { get; set; }
        public Nullable<int> Wk { get; set; }
        public Nullable<System.DateTime> WkStrt { get; set; }
        public Nullable<System.DateTime> WkEnd { get; set; }
    }
}
