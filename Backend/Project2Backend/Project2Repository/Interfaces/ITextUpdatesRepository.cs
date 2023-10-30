using Project2Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2Repository.Interfaces
{
    public interface ITextUpdatesRepository
    {
        Task<TextUpdates> SaveTextUpdateAsync(TextUpdates textUpdate);
        Task<TextUpdates> DeleteTextUpdateByIdAsync(int id);
        Task<List<TextUpdates>> GetAllTextUpdatesAsync();
        Task<TextUpdates> GetTextUpdatesByIdAsync(int id);
    }
}
