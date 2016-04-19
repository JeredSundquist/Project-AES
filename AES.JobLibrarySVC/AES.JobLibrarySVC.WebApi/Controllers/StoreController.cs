using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using AES.Entities.Shared.Net45.Models;
using TrackableEntities;
using TrackableEntities.Common;
using TrackableEntities.EF6;

namespace AES.JobLibrarySVC.WebApi.Controllers
{
    public class StoreController : ApiController
    {
        private readonly AESEntitiesModel _dbContext = new AESEntitiesModel();

        // GET api/Store
        [ResponseType(typeof(IEnumerable<Store>))]
        public async Task<IHttpActionResult> GetStores()
        {
            IEnumerable<Store> entities = await _dbContext.Stores
                // TODO: Add Includes for reference and/or collection properties
                .ToListAsync();

            return Ok(entities);
        }

        // GET api/Store/5
        [ResponseType(typeof(Store))]
        public async Task<IHttpActionResult> GetStore(int id)
        {
            Store entity = await _dbContext.Stores
                // TODO: Add Includes for reference and/or collection properties
                .SingleOrDefaultAsync(e => e.StoreId == id);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        // POST api/Store
        [ResponseType(typeof(Store))]
        public async Task<IHttpActionResult> PostStore(Store entity)
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
                if (_dbContext.Stores.Any(e => e.StoreId == entity.StoreId))
                {
                    return Conflict();
                }
                throw;
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return CreatedAtRoute("DefaultApi", new { id = entity.StoreId }, entity);
        }

        // PUT api/Store
        [ResponseType(typeof(Store))]
        public async Task<IHttpActionResult> PutStore(Store entity)
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
                if (!_dbContext.Stores.Any(e => e.StoreId == entity.StoreId))
                {
                    return Conflict();
                }
                throw;
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return Ok(entity);
        }

        // DELETE api/Store/5
        public async Task<IHttpActionResult> DeleteStore(int id)
        {
            Store entity = await _dbContext.Stores
                // TODO: Include child entities if any
                .SingleOrDefaultAsync(e => e.StoreId == id);
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
                if (!_dbContext.Stores.Any(e => e.StoreId == entity.StoreId))
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
