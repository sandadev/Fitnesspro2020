using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fitnesspro.Dtos;
using Fitnesspro.Models.DbContext;

namespace Fitnesspro.Models.ViewModels.Web
{
    public class EntityViewModel
    {
        public List<ServiceTypeDto> lstserviceTypes { get; set; }
        public EntityDto Entity { get; set; }

        public ServiceTypeDto ServiceType { get; set; }
        
    }
}