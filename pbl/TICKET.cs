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
    
    public partial class TICKET
    {
        public string TicketID { get; set; }
        public string TrainID { get; set; }
        public string SeatNo { get; set; }
        public decimal TicketPrice { get; set; }
        public Nullable<bool> Booked { get; set; }
        public string CustomerUN { get; set; }
    
        public virtual PEOPLE Person { get; set; }
        public virtual TRAIN TRAIN { get; set; }
    }
}
