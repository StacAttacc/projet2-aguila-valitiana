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
    public class TextUpdatesRepository : ITextUpdatesRepository
    {
        private Project2DbContext _db;

        public TextUpdatesRepository(Project2DbContext db)
        {
            this._db = db;
        }

        public async Task<TextUpdates> DeleteTextUpdateByIdAsync(int id)
        {
            try
            {
                var query = from e in this._db.TextUpdates where e.Id == id select e;
                var result = await query.FirstOrDefaultAsync();
                if (query.Count() > 0)
                {
                    this._db.TextUpdates.Remove(query.First());
                    await this._db.SaveChangesAsync();
                }
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<TextUpdates>> GetAllTextUpdatesAsync()
        {
            try
            {
                var query = from e in this._db.TextUpdates select e;
                var result = await query.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<TextUpdates> GetTextUpdatesByIdAsync(int id)
        {
            try
            {
                var query = from e in this._db.TextUpdates where e.Id == id select e;
                var result = await query.FirstOrDefaultAsync();
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<TextUpdates> SaveTextUpdateAsync(TextUpdates textUpdate)
        {
            try
            {
                if (textUpdate.Id == 0)
                {
                    await this._db.TextUpdates.AddAsync(textUpdate);
                }
                else
                {
                    this._db.TextUpdates.Update(textUpdate);
                }
                await this._db.SaveChangesAsync();
                return textUpdate;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
