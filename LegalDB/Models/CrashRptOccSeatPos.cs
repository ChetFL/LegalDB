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
    
    public partial class CrashRptOccSeatPos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CrashRptOccSeatPos()
        {
            this.CrashRptMotorists = new HashSet<CrashRptMotorist>();
            this.CrashRptOccups = new HashSet<CrashRptOccup>();
        }
    
        public int ID { get; set; }
        public string SeatPos { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CrashRptMotorist> CrashRptMotorists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CrashRptOccup> CrashRptOccups { get; set; }
    }
}
