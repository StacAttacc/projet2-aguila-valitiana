using Project2Models;
using Project2Repository.Interfaces;
using Project2Ruleset.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2Ruleset.Implementation
{
    public class UpdateEntryRuleset : IUpdateEntryRuleset
    {
        private IUpdateEntryRepository _updateEntryRep;
        public async Task<UpdateEntry> DeleteUpdateEntryAsync(UpdateEntry updateEntry)
        {
            try
            {
                var result = await this._updateEntryRep.DeleteUpdateEntryAsync(updateEntry);
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<UpdateEntry>> GetAllEntriesAsync()
        {
            try
            {
                var result = await this._updateEntryRep.GetAllEntriesAsync();
                return result;
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
                var result = await this._updateEntryRep.GetUpdateEntryByIdAsync(uEId);
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
                var result = await this._updateEntryRep.SaveUpdateEntryAsync(updateEntry);
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
