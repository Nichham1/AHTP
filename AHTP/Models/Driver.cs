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

    [MetadataType(typeof(Driver))]
    public partial class Driver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Driver()
        {
            this.Deliveries = new HashSet<Delivery>();
            this.DeliveryPaysheets = new HashSet<DeliveryPaysheet>();
        }
        [Display(Name = "Driver")]
        public int DriverId { get; set; }

        [Display(Name = " Driver First Name ")]
        public string FirstName { get; set; }

        [Display(Name = "Driver Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Phone Number")]
        public string ContactNum { get; set; }

        [Display(Name = "Email Address")]
        public string ContactEmail { get; set; }

        [Display(Name = "DOB")]
        public System.DateTime BirthDate { get; set; }

        [Display(Name = "Hired Date")]
        public System.DateTime HireDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Delivery> Deliveries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryPaysheet> DeliveryPaysheets { get; set; }
    }
}
