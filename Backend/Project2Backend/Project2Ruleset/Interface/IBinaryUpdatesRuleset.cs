using Project2Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2Ruleset.Interface
{
    public interface IBinaryUpdatesRuleset
    {
        Task<BinaryUpdates> SaveBinaryUpdateAsync(BinaryUpdates binaryUpdate);
        Task<BinaryUpdates> DeleteBinaryUpdateByIdAsync(int id);
        Task<List<BinaryUpdates>> GetAllBinaryUpdatesAsync();
        Task<BinaryUpdates> GetBinaryUpdatesByIdAsync(int id);
    }
}
