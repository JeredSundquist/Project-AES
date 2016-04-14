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
    public class myController : ApiController
    {
        private readonly AESEnititiesModel _dbContext = new AESEnititiesModel();

        // GET api/JobHistory
        [ResponseType(typeof(IEnumerable<JobHistory>))]
        public async Task<IHttpActionResult> GetJobHistory()
        {
            IEnumerable<JobHistory> entities = await _dbContext.JobHistory
                // TODO: Add Includes for reference and/or collection properties
                .ToListAsync();

            return Ok(entities);
        }

        // GET api/JobHistory/5
        [ResponseType(typeof(JobHistory))]
        public async Task<IHttpActionResult> GetJobHistory(int id)
        {
            JobHistory entity = await _dbContext.JobHistory
                // TODO: Add Includes for reference and/or collection properties
                .SingleOrDefaultAsync(e => e.JobHistoryId == id);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        // POST api/JobHistory
        [ResponseType(typeof(JobHistory))]
        public async Task<IHttpActionResult> PostJobHistory(JobHistory entity)
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
                if (_dbContext.JobHistory.Any(e => e.JobHistoryId == entity.JobHistoryId))
                {
                    return Conflict();
                }
                throw;
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return CreatedAtRoute("DefaultApi", new { id = entity.JobHistoryId }, entity);
        }

        // PUT api/JobHistory
        [ResponseType(typeof(JobHistory))]
        public async Task<IHttpActionResult> PutJobHistory(JobHistory entity)
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
                if (!_dbContext.JobHistory.Any(e => e.JobHistoryId == entity.JobHistoryId))
                {
                    return Conflict();
                }
                throw;
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return Ok(entity);
        }

        // DELETE api/JobHistory/5
        public async Task<IHttpActionResult> DeleteJobHistory(int id)
        {
            JobHistory entity = await _dbContext.JobHistory
                // TODO: Include child entities if any
                .SingleOrDefaultAsync(e => e.JobHistoryId == id);
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
                if (!_dbContext.JobHistory.Any(e => e.JobHistoryId == entity.JobHistoryId))
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
