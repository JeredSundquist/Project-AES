using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TrackableEntities;
using TrackableEntities.EF6;
using TrackableEntities.Common;
using AES.Entities.Shared.Net45.Models;

// NOTE: Primary key name and/or type may need to be set manually.

namespace AES.JobLibrarySVC.WebApi.Controllers
{
    public class ApplicationController : ApiController
    {
        private readonly AESEntitiesModel _dbContext = new AESEntitiesModel();

        // GET api/Application
        [ResponseType(typeof(IEnumerable<Application>))]
        public async Task<IHttpActionResult> GetApplications()
        {
            IEnumerable<Application> entities = await _dbContext.Applications
                // TODO: Add Includes for reference and/or collection properties
                .ToListAsync();

            return Ok(entities);
        }

        // GET api/Application/5
        [ResponseType(typeof(Application))]
        public async Task<IHttpActionResult> GetApplication(int id)
        {
            Application entity = await _dbContext.Applications
                // TODO: Add Includes for reference and/or collection properties
                .SingleOrDefaultAsync(e => e.ApplicationId == id);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        // POST api/Application
        [ResponseType(typeof(Application))]
        public async Task<IHttpActionResult> PostApplication(Application entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            entity.TrackingState = TrackingState.Added;
            _dbContext.ApplyChanges(entity);


            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (_dbContext.Applications.Any(e => e.ApplicationId == entity.ApplicationId))
                {
                    return Conflict();
                }
                throw;
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return CreatedAtRoute("DefaultApi", new { id = entity.ApplicationId }, entity);
        }

        // PUT api/Application
        [ResponseType(typeof(Application))]
        public async Task<IHttpActionResult> PutApplication(Application entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _dbContext.ApplyChanges(entity);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_dbContext.Applications.Any(e => e.ApplicationId == entity.ApplicationId))
                {
                    return Conflict();
                }
                throw;
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return Ok(entity);
        }

        // DELETE api/Application/5
        public async Task<IHttpActionResult> DeleteApplication(int id)
        {
            Application entity = await _dbContext.Applications
                // TODO: Include child entities if any
                .SingleOrDefaultAsync(e => e.ApplicationId == id);
            if (entity == null)
            {
                return Ok();
            }

            entity.TrackingState = TrackingState.Deleted;
            _dbContext.ApplyChanges(entity);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_dbContext.Applications.Any(e => e.ApplicationId == entity.ApplicationId))
                {
                    return Conflict();
                }
                throw;
            }

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
            base.Dispose(disposing);
        }
    }
}
