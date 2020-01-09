using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Fitnesspro.Dtos;
using Fitnesspro.Models.DbContext;

namespace Fitnesspro.App_Start
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Entity, EntityDto>();
            Mapper.CreateMap<EntityDto,Entity>();
            Mapper.CreateMap<ServiceType, ServiceTypeDto>();
            Mapper.CreateMap<ServiceTypeDto, ServiceType>();
        }
    }
}