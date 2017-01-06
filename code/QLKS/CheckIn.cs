//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKS
{
    using System;
    using System.Collections.Generic;
    
    public partial class CheckIn
    {
        public CheckIn()
        {
            this.Invoices = new HashSet<Invoice>();
            this.UsedServiceCodes = new HashSet<UsedServiceCode>();
            this.checkin_Custommer = new HashSet<checkin_Custommer>();
        }
    
        public int CheckInID { get; set; }
        public Nullable<int> GroupID { get; set; }
        public string RoomNoID { get; set; }
        public Nullable<System.DateTime> DateIn { get; set; }
        public Nullable<int> Discount { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<System.DateTime> DateOut { get; set; }
        public Nullable<int> OutofTime { get; set; }
        public string Comment { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<decimal> RoomCharge { get; set; }
        public Nullable<bool> CheckInStatus { get; set; }
    
        public virtual Room Room { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<UsedServiceCode> UsedServiceCodes { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<checkin_Custommer> checkin_Custommer { get; set; }
    }
}
