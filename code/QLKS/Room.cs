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
    
    public partial class Room
    {
        public Room()
        {
            this.CheckIns = new HashSet<CheckIn>();
        }
    
        public string RoomNoID { get; set; }
        public Nullable<int> Floor { get; set; }
        public Nullable<int> Position { get; set; }
        public string RoomTypeID { get; set; }
        public Nullable<int> RoomStatus { get; set; }
        public string RoomPhone { get; set; }
    
        public virtual ICollection<CheckIn> CheckIns { get; set; }
        public virtual RoomType RoomType { get; set; }
    }
}
