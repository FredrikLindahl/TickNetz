//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketNetz
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public Customer()
        {
            this.Booking = new HashSet<Booking>();
        }
    
        public int customerNbr { get; set; }
        public string customerName { get; set; }
        public string phoneNbr { get; set; }
        public string email { get; set; }
        public string address { get; set; }
    
        public virtual ICollection<Booking> Booking { get; set; }
    }
}
