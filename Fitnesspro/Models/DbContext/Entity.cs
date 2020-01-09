namespace Fitnesspro.Models.DbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Entity
    {
        public int EntityId { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Entity Name")]
        public string EntityName { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Enrolled Date")]
        public DateTime EnrollDate { get; set; }

        [Required]
        [DisplayName("Entity Name")]
        public string Email { get; set; }

        public long MobileNumber { get; set; }

        public long TelephoneNumber { get; set; }

        public int EstablishedYear { get; set; }

        public int? ServiceType_ServiceTypeId { get; set; }

        public virtual ServiceType ServiceType { get; set; }
    }
}
