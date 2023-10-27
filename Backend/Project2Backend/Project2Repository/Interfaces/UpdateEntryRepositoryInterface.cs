using Project2Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project2Repository.Interfaces
{
    public interface UpdateEntryRepositoryInterface
    {
        Task<List<UpdateEntry>> GetAllEntriesAsync();
        Task<UpdateEntry> GetUpdateEntryAsync(UpdateEntry updateEntry);
        Task<UpdateEntry> SaveUpdateEntryAsync(UpdateEntry updateEntry);
        Task<UpdateEntry> DeleteUpdateEntryAsync(UpdateEntry updateEntry);
    }
}
