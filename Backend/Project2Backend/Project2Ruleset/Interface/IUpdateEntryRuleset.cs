using Project2Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2Ruleset.Interface
{
    public interface IUpdateEntryRuleset
    {
        Task<List<UpdateEntry>> GetAllEntriesAsync();
        Task<UpdateEntry> GetUpdateEntryByIdAsync(int uEId);
        Task<UpdateEntry> SaveUpdateEntryAsync(UpdateEntry updateEntry);
        Task<UpdateEntry> DeleteUpdateEntryByIdAsync(int uEId);
    }
}
