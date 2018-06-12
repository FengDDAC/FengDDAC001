//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FengDDAC1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schedule()
        {
            this.Vessels = new HashSet<Vessel>();
        }
    
        public int scheduleID { get; set; }

        [Display(Name = "Sailing Begin Route:")]
        [Required]
        public string sailingRoute { get; set; }

        [Display(Name = "Sailing Destination:")]
        [Required]
        public string sailingDestination { get; set; }

        [Display(Name ="Sailing Departure:")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public Nullable<System.DateTime> sailingDepartureDate { get; set; }

        [Display(Name = "Sailing Arrival:")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public Nullable<System.DateTime> sailingArrivalDate { get; set; }

        [Display(Name = "Available Space:")]
        [Required]
        public Nullable<int> spaceAvailable { get; set; }

        [Display(Name = "Space Size:")]
        [Required]
        public Nullable<double> spaceSize { get; set; }

        [Display(Name = "Sail Captain:")]
        [Required]
        public string sailingCaptain { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vessel> Vessels { get; set; }
    }
}
