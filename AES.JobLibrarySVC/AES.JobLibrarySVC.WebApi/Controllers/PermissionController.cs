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
    public class PermissionController : ApiController
    {
        private readonly AESEntitiesModel _dbContext = new AESEntitiesModel();

        // GET api/UserPermission
        [ResponseType(typeof(IEnumerable<UserPermission>))]
        public async Task<IHttpActionResult> GetUserPermissions()
        {
            IEnumerable<UserPermission> entities = await _dbContext.UserPermissions
                // TODO: Add Includes for reference and/or collection properties
                .Include(u => u.User)
                .ToListAsync();

            return Ok(entities);
        }

        // GET api/UserPermission/5
        [ResponseType(typeof(UserPermission))]
        public async Task<IHttpActionResult> GetUserPermission(int id)
        {
            UserPermission entity = await _dbContext.UserPermissions
                // TODO: Add Includes for reference and/or collection properties
                .SingleOrDefaultAsync(u => u.UserId == id);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        // POST api/UserPermission
        [ResponseType(typeof(UserPermission))]
        public async Task<IHttpActionResult> PostUserPermission(UserPermission entity)
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
                if (_dbContext.UserPermissions.Any(u => u.UserId == entity.UserId))
                {
                    return Conflict();
                }
                throw;
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return CreatedAtRoute("DefaultApi", new { id = entity.UserId }, entity);
        }

        // PUT api/UserPermission
        [ResponseType(typeof(UserPermission))]
        public async Task<IHttpActionResult> PutUserPermission(UserPermission entity)
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
                if (!_dbContext.UserPermissions.Any(u => u.UserId == entity.UserId))
                {
                    return Conflict();
                }
                throw;
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return Ok(entity);
        }

        // DELETE api/UserPermission/5
        public async Task<IHttpActionResult> DeleteUserPermission(int id)
        {
            UserPermission entity = await _dbContext.UserPermissions
                // TODO: Include child entities if any
                .SingleOrDefaultAsync(u => u.UserId == id);
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
                if (!_dbContext.UserPermissions.Any(u => u.UserId == entity.UserId))
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
