//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pbl
{
    using System;
    using System.Collections.Generic;
    
    public partial class TRAIN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRAIN()
        {
            this.TRIPs = new HashSet<TRIP>();
        }
    
        public int TrainID { get; set; }
        public string TrainName { get; set; }
        public int NumberOfCarriages { get; set; }
        public Nullable<bool> State { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIP> TRIPs { get; set; }
    }
}
