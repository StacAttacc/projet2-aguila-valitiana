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
    public class UpdateEntryRuleset : IUpdateEntryRulese
    {
        private IUpdateEntryRepository _updateEntry;
        public Task<UpdateEntry> DeleteUpdateEntryAsync(UpdateEntry updateEntry)
        {
            throw new NotImplementedException();
        }

        public Task<List<UpdateEntry>> GetAllEntriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UpdateEntry> GetUpdateEntryAsync(UpdateEntry updateEntry)
        {
            throw new NotImplementedException();
        }

        public Task<UpdateEntry> SaveUpdateEntryAsync(UpdateEntry updateEntry)
        {
            throw new NotImplementedException();
        }
    }
}
