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
    
    public partial class Office
    {
        public int OfficeID { get; set; }
        public Nullable<int> OfficeGroup { get; set; }
        public string Abbrev { get; set; }
        public string OfficeName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string StateOrProvince { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Notes { get; set; }
        public Nullable<bool> Inlist { get; set; }
        public Nullable<int> StateID { get; set; }
        public Nullable<bool> StateDef { get; set; }
        public Nullable<int> AreaGrp1 { get; set; }
        public Nullable<int> AreaGrp2 { get; set; }
        public Nullable<int> AreaGrp3 { get; set; }
    }
}
