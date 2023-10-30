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
    public class BinaryUpdatesRuleset: IBinaryUpdatesRuleset
    {
        private IBinaryUpdatesRepository _bur;

        public BinaryUpdatesRuleset(IBinaryUpdatesRepository bur)
        {
            this._bur = bur;
        }

        public async Task<BinaryUpdates> DeleteBinaryUpdateByIdAsync(int id)
        {
            try
            {
                var result = await this._bur.DeleteBinaryUpdateByIdAsync(id);
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<BinaryUpdates>> GetAllBinaryUpdatesAsync()
        {
            try
            {
                var results = await this._bur.GetAllBinaryUpdatesAsync();
                return results;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<BinaryUpdates> GetBinaryUpdatesByIdAsync(int id)
        {
            try
            {
                var result = await this._bur.GetBinaryUpdatesByIdAsync(id);
                return result;
            }
            catch(Exception e)
            {
                throw;
            }
        }

        public async Task<BinaryUpdates> SaveBinaryUpdateAsync(BinaryUpdates binaryUpdate)
        {
            try
            {
                var result = await this._bur.SaveBinaryUpdateAsync(binaryUpdate);
                return result;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
