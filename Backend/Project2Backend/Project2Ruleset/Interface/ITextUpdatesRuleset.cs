using Project2Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2Ruleset.Interface
{
    public interface ITextUpdatesRuleset
    {
        Task<TextUpdates> SaveTextUpdateAsync(TextUpdates textUpdate);
        Task<TextUpdates> DeleteTextUpdateByIdAsync(int id);
        Task<List<TextUpdates>> GetAllTextUpdatesAsync();
        Task<TextUpdates> GetTextUpdatesByIdAsync(int id);
    }
}
