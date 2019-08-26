//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AHTP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Delivery
    {
        public int DeliveryId { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> DriverID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> TruckLicNum { get; set; }
        public Nullable<decimal> Freight { get; set; }
        public Nullable<int> DestinationID { get; set; }
        public Nullable<int> WaitingId { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Destination Destination { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual Order Order { get; set; }
        public virtual Waiting Waiting { get; set; }
    }
}