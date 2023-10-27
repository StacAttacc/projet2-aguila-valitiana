using Project2Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2Ruleset.Interface
{
    public interface IUpdateEntryRulese
    {
        Task<List<UpdateEntry>> GetAllEntriesAsync();
        Task<UpdateEntry> GetUpdateEntryAsync(UpdateEntry updateEntry);
        Task<UpdateEntry> SaveUpdateEntryAsync(UpdateEntry updateEntry);
        Task<UpdateEntry> DeleteUpdateEntryAsync(UpdateEntry updateEntry);
    }
}
