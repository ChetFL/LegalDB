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
    
    public partial class CrashRptAgency
    {
        public int ID { get; set; }
        public string NCIC { get; set; }
        public string Name { get; set; }
        public Nullable<int> County { get; set; }
        public string CityVillageTownship { get; set; }
    
        public virtual County County1 { get; set; }
    }
}