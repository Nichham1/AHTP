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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Delivery()
        {
            this.DeliveryPaysheets = new HashSet<DeliveryPaysheet>();
        }

        [Display(Name = "Delivery")]
        public int DeliveryId { get; set; }
        [Display(Name = "Customer")]
        public Nullable<int> CustomerID { get; set; }
        [Display(Name = "Driver")]
        public Nullable<int> DriverID { get; set; }
        [Display(Name = "Order Date")]
        public Nullable<System.DateTime> OrderDate { get; set; }
        [Display(Name = "Shipped Date")]
        public Nullable<System.DateTime> ShippedDate_ { get; set; }
        [Display(Name = "Truck")]
        public Nullable<int> TruckDetailsID { get; set; }
       
        public Nullable<decimal> Weight { get; set; }
        [Display(Name = "Destination")]
        public Nullable<int> DestinationID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Destination Destination { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual TruckDetail TruckDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryPaysheet> DeliveryPaysheets { get; set; }
    }
}
