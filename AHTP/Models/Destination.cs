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

    public partial class Destination
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Destination()
        {
            this.Deliveries = new HashSet<Delivery>();
            this.DeliveryPaysheets = new HashSet<DeliveryPaysheet>();
        }
        [Display(Name = "Destination")]
        public int DestinationId { get; set; }
        [Display(Name = "From")]
        public string DestinationFr { get; set; }
        [Display(Name = "To")]
        public string DestinationTo { get; set; }
        [Display(Name = "Cost")]
        public Nullable<double> DestinationCost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Delivery> Deliveries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryPaysheet> DeliveryPaysheets { get; set; }
    }
}
