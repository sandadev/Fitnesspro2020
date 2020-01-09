using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Fitnesspro.Models.DbContext;
using System.Data.Entity;
using Fitnesspro.Dtos;
using AutoMapper;

namespace Fitnesspro.Controllers.Api.Admin
{
    [RoutePrefix("api/EntityAdmin")]
    public class EntityAdminController : ApiController
    {
        private FitnessproDbContext _context;
        public EntityAdminController()
        {
            _context = new FitnessproDbContext();
        }

        //Get /api/Entity
        public IEnumerable<EntityDto> GetEntities()
        {
            return _context.Entities.Include(S => S.ServiceType).ToList().Select(Mapper.Map<Entity, EntityDto>);
        }

        //Get /api/Entity/1
        public IHttpActionResult GetEntities(int id)
        {
            var entity = _context.Entities.Include("ServiceType").SingleOrDefault(e => e.EntityId == id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(Mapper.Map<Entity,EntityDto>(entity));
        }



        //Post /api/Entity
        [HttpPost]
        public IHttpActionResult CreateEntity(EntityDto entityDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var entity = Mapper.Map<EntityDto, Entity>(entityDto);
            _context.Entities.Add(entity);
            _context.SaveChanges();
            return Created(new Uri(Request.RequestUri + "/" + entity.EntityId), entity);
        }

        //Put /api/Enity/1
        [HttpPut]
        public void UpdateEntity(int id, EntityDto entityDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var dbentity = _context.Entities.SingleOrDefault(e => e.EntityId == id);
            Mapper.Map(entityDto, dbentity);
            _context.SaveChanges();
        }
        [HttpDelete]
        public void DeleteEntity(int id)
        {
            var dbentity = _context.Entities.SingleOrDefault(e => e.EntityId == id);
            if (dbentity == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Entities.Remove(dbentity);
            _context.SaveChanges();
        }
        [HttpGet]
        [Route("ServiceTypeList")]
        public IEnumerable<ServiceTypeDto> GetServiceTypeList()
        {
            return _context.ServiceTypes.ToList().Select(Mapper.Map<ServiceType,ServiceTypeDto>);
         }

    }
}
