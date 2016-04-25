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
    public class PositionRequestController : ApiController
    {
        private readonly AESEntitiesModel _dbContext = new AESEntitiesModel();

        // GET api/PositionRequest
        [ResponseType(typeof(IEnumerable<PositionRequest>))]
        public async Task<IHttpActionResult> GetPositionRequests()
        {
            IEnumerable<PositionRequest> entities = await _dbContext.PositionRequests
                // TODO: Add Includes for reference and/or collection properties
                .ToListAsync();

            return Ok(entities);
        }

        // GET api/PositionRequest/5
        [ResponseType(typeof(PositionRequest))]
        public async Task<IHttpActionResult> GetPositionRequest(int id)
        {
            PositionRequest entity = await _dbContext.PositionRequests
                // TODO: Add Includes for reference and/or collection properties
                .SingleOrDefaultAsync(e => e.RequestId == id);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        // POST api/PositionRequest
        [ResponseType(typeof(PositionRequest))]
        public async Task<IHttpActionResult> PostPositionRequest(PositionRequest entity)
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
                if (_dbContext.PositionRequests.Any(e => e.RequestId == entity.RequestId))
                {
                    return Conflict();
                }
                throw;
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return CreatedAtRoute("DefaultApi", new { id = entity.RequestId }, entity);
        }

        // PUT api/PositionRequest
        [ResponseType(typeof(PositionRequest))]
        public async Task<IHttpActionResult> PutPositionRequest(PositionRequest entity)
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
                if (!_dbContext.PositionRequests.Any(e => e.RequestId == entity.RequestId))
                {
                    return Conflict();
                }
                throw;
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return Ok(entity);
        }

        // DELETE api/PositionRequest/5
        public async Task<IHttpActionResult> DeletePositionRequest(int id)
        {
            PositionRequest entity = await _dbContext.PositionRequests
                // TODO: Include child entities if any
                .SingleOrDefaultAsync(e => e.RequestId == id);
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
                if (!_dbContext.PositionRequests.Any(e => e.RequestId == entity.RequestId))
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
