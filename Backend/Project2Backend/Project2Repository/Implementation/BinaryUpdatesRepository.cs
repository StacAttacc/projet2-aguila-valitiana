using Microsoft.EntityFrameworkCore;
using Project2Models;
using Project2Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2Repository.Implementation
{
    public class BinaryUpdatesRepository : IBinaryUpdatesRepository
    {
        private Project2DbContext _db;

        public BinaryUpdatesRepository(Project2DbContext db)
        {
            this._db = db;
        }

        public async Task<BinaryUpdates> DeleteBinaryUpdateByIdAsync(int id)
        {
            try
            {
                var query = from e in this._db.BinaryUpdates where e.Id == id select e;
                var result = await query.FirstOrDefaultAsync();
                if (query.Count() > 0)
                {
                    this._db.BinaryUpdates.Remove(result);
                    await this._db.SaveChangesAsync();
                }
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<BinaryUpdates>> GetAllBinaryUpdatesAsync()
        {
            try
            {
                var query = from e in this._db.BinaryUpdates select e;
                var result = await query.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<BinaryUpdates> GetBinaryUpdatesByIdAsync(int id)
        {
            try
            {
                var query = from e in this._db.BinaryUpdates where e.Id == id select e;
                var result = await query.FirstOrDefaultAsync();
                return result;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<BinaryUpdates> SaveBinaryUpdateAsync(BinaryUpdates binaryUpdate)
        {
            try
            {
                if(binaryUpdate.Id == 0)
                {
                    await this._db.BinaryUpdates.AddAsync(binaryUpdate);
                }
                else
                {
                    this._db.BinaryUpdates.Update(binaryUpdate);
                }
                await this._db.SaveChangesAsync();
                return binaryUpdate;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
