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
    public class UpdateEntryRepository : IUpdateEntryRepository
    {
        private Project2DbContext _projet2DbContext;

        public UpdateEntryRepository(Project2DbContext projet2DbContext)
        {
            _projet2DbContext = projet2DbContext;
        }

        public async Task<UpdateEntry> DeleteUpdateEntryAsync(UpdateEntry updateEntry)
        {
            try
            {
                var query = from e in _projet2DbContext.UpdateEntries where e.Id == updateEntry.Id select e;
                var result = await query.FirstOrDefaultAsync();
                if(query.Count() > 0)
                {
                    this._projet2DbContext.UpdateEntries.Remove(updateEntry);
                    await this._projet2DbContext.SaveChangesAsync();
                }
                return result;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<List<UpdateEntry>> GetAllEntriesAsync()
        {
            try
            {
                var query = from e in _projet2DbContext.UpdateEntries select e;
                var results = await query.ToListAsync();
                return results;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<UpdateEntry> GetUpdateEntryByIdAsync(int uEId)
        {
            try
            {
                var query = from e in _projet2DbContext.UpdateEntries where e.Id == uEId select e;
                var result = await query.FirstOrDefaultAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<UpdateEntry> SaveUpdateEntryAsync(UpdateEntry updateEntry)
        {
            try
            {
                if (updateEntry.Id == 0) //il est nouveau, alors on va créer un nouvel enregistrement
                {
                    await this._projet2DbContext.UpdateEntries.AddAsync(updateEntry);
                }
                else //il n'est pas nouveau, alors on modifie un enregisrement existant
                {
                    this._projet2DbContext.UpdateEntries.Update(updateEntry);
                }
                await _projet2DbContext.SaveChangesAsync();
                return updateEntry;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
