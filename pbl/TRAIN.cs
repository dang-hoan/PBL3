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
            this.TICKETs = new HashSet<TICKET>();
            this.TICKET_MANAGER = new HashSet<TICKET_MANAGER>();
        }
    
        public int TrainID { get; set; }
        public string TrainName { get; set; }
        public int NumberOfCarriages { get; set; }
        public string DriverUN { get; set; }
        public int ScheduleID { get; set; }
        public Nullable<decimal> BasicPrice { get; set; }
        public string State { get; set; }
    
        public virtual PEOPLE Person { get; set; }
        public virtual SCHEDULE SCHEDULE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TICKET> TICKETs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TICKET_MANAGER> TICKET_MANAGER { get; set; }
    }
}
