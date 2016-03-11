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
using JobLibrarySVC.Entities.Shared.Net45.Models;

// NOTE: Primary key name and/or type may need to be set manually.

namespace JobLibrarySVC.WebApi.Controllers
{
    public class PositionController : ApiController
    {
        private readonly EntitiesModel _dbContext = new EntitiesModel();

        // GET api/Position
        [ResponseType(typeof(IEnumerable<Position>))]
        public async Task<IHttpActionResult> GetPositions()
        {
            IEnumerable<Position> entities = await _dbContext.Positions
                // TODO: Add Includes for reference and/or collection properties
                .ToListAsync();

            return Ok(entities);
        }

        // GET api/Position/5
        [ResponseType(typeof(Position))]
        public async Task<IHttpActionResult> GetPosition(int id)
        {
            Position entity = await _dbContext.Positions
                // TODO: Add Includes for reference and/or collection properties
                .SingleOrDefaultAsync(e => e.PositionId == id);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        // POST api/Position
        [ResponseType(typeof(Position))]
        public async Task<IHttpActionResult> PostPosition(Position entity)
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
                if (_dbContext.Positions.Any(e => e.PositionId == entity.PositionId))
                {
                    return Conflict();
                }
                throw;
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return CreatedAtRoute("DefaultApi", new { id = entity.PositionId }, entity);
        }

        // PUT api/Position
        [ResponseType(typeof(Position))]
        public async Task<IHttpActionResult> PutPosition(Position entity)
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
                if (!_dbContext.Positions.Any(e => e.PositionId == entity.PositionId))
                {
                    return Conflict();
                }
                throw;
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return Ok(entity);
        }

        // DELETE api/Position/5
        public async Task<IHttpActionResult> DeletePosition(int id)
        {
            Position entity = await _dbContext.Positions
                // TODO: Include child entities if any
                .SingleOrDefaultAsync(e => e.PositionId == id);
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
                if (!_dbContext.Positions.Any(e => e.PositionId == entity.PositionId))
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
