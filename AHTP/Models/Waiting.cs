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


    public partial class Waiting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Waiting()
        {
            this.Deliveries = new HashSet<Delivery>();
        }
        [Display(Name = "Waiting")]
        public int WaitingId { get; set; }

        [Display(Name = "Time Waited")]
        public Nullable<int> ExtraTimePerWait { get; set; }

        [Display(Name = "Cost")]
        public Nullable<double> CostPerWait { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Delivery> Deliveries { get; set; }
    }
}
