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
    
    public partial class CrashRptVehTypeUse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CrashRptVehTypeUse()
        {
            this.CrashRptVehs = new HashSet<CrashRptVeh>();
        }
    
        public int ID { get; set; }
        public string TypeUse { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CrashRptVeh> CrashRptVehs { get; set; }
    }
}
