using Project2Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project2Repository.Interfaces
{
    public interface IUpdateEntryRepository
    {
        Task<List<UpdateEntry>> GetAllEntriesAsync();
        Task<UpdateEntry> GetUpdateEntryByIdAsync(int uEId);
        //Task<UpdateEntry> GetUpdateEntryAsync(UpdateEntry updateEntry);
        Task<UpdateEntry> SaveUpdateEntryAsync(UpdateEntry updateEntry);
        Task<UpdateEntry> DeleteUpdateEntryByIdAsync(int uEId);
    }
}
