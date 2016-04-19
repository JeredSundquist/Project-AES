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
    public class UserController : ApiController
    {
        private readonly AESEntitiesModel _dbContext = new AESEntitiesModel();

        // GET api/User
        [ResponseType(typeof(IEnumerable<User>))]
        public async Task<IHttpActionResult> GetUsers()
        {
            IEnumerable<User> entities = await _dbContext.Users
                // TODO: Add Includes for reference and/or collection properties
                .ToListAsync();

            return Ok(entities);
        }

        // GET api/User/5
        [ResponseType(typeof(User))]
        public async Task<IHttpActionResult> GetUser(int id)
        {
            User entity = await _dbContext.Users
                // TODO: Add Includes for reference and/or collection properties
                .SingleOrDefaultAsync(e => e.UserId == id);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        // POST api/User
        [ResponseType(typeof(User))]
        public async Task<IHttpActionResult> PostUser(User entity)
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
                if (_dbContext.Users.Any(e => e.UserId == entity.UserId))
                {
                    return Conflict();
                }
                throw;
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return CreatedAtRoute("DefaultApi", new { id = entity.UserId }, entity);
        }

        // PUT api/User
        [ResponseType(typeof(User))]
        public async Task<IHttpActionResult> PutUser(User entity)
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
                if (!_dbContext.Users.Any(e => e.UserId == entity.UserId))
                {
                    return Conflict();
                }
                throw;
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return Ok(entity);
        }

        // DELETE api/User/5
        public async Task<IHttpActionResult> DeleteUser(int id)
        {
            User entity = await _dbContext.Users
                // TODO: Include child entities if any
                .SingleOrDefaultAsync(e => e.UserId == id);
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
                if (!_dbContext.Users.Any(e => e.UserId == entity.UserId))
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
