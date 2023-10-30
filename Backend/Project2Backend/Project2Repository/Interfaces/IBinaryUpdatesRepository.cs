using Project2Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2Repository.Interfaces
{
    public interface IBinaryUpdatesRepository
    {
        Task<BinaryUpdates> SaveBinaryUpdateAsync(BinaryUpdates binaryUpdate);
        Task<BinaryUpdates> DeleteBinaryUpdateByIdAsync(int id);
        Task<List<BinaryUpdates>> GetAllBinaryUpdatesAsync();
        Task<BinaryUpdates> GetBinaryUpdatesByIdAsync(int id);
    }
}
