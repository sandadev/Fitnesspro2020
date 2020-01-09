using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Fitnesspro.Dtos
{
    public class EntityDto
    {
        public int EntityId { get; set; }

        public string EntityName { get; set; }

        public string FirstName { get; set; }

       
        public string LastName { get; set; }

        public DateTime EnrollDate { get; set; }

       
        public string Email { get; set; }

        public long MobileNumber { get; set; }

        public long TelephoneNumber { get; set; }

        public int EstablishedYear { get; set; }

        public int ServiceType_ServiceTypeId { get; set; }

        public virtual ServiceTypeDto ServiceType { get; set; }
    }
}