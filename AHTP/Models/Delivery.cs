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
    using System.ComponentModel.DataAnnotations;

    public partial class Delivery
    {
        public int DeliveryId { get; set; }

        [Display(Name = "Customer Name")]
        public Nullable<int> CustomerID { get; set; }

       [Display(Name = "Driver Name")]
        public Nullable<int> DriverID { get; set; }

        [Display(Name = "Order number")]
        public Nullable<int> OrderID { get; set; }

        [Display(Name = "Truck plate number")]
        public Nullable<int> TruckLicNum { get; set; }

        public Nullable<decimal> Freight { get; set; }

        [Display(Name = "Destination")]
        public Nullable<int> DestinationID { get; set; }

        [Display(Name = "Waiting Period")]
        public Nullable<int> WaitingId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Destination Destination { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual Order Order { get; set; }
        public virtual Waiting Waiting { get; set; }
    }
}
