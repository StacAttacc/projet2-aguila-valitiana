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
    public class TextUpdatesRuleset : ITextUpdatesRuleset
    {
        private ITextUpdatesRepository _tur;

        public TextUpdatesRuleset(ITextUpdatesRepository tur)
        {
            this._tur = tur;
        }

        public async Task<TextUpdates> DeleteTextUpdateByIdAsync(int id)
        {
            try
            {
                var result = await this._tur.DeleteTextUpdateByIdAsync(id);
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<TextUpdates>> GetAllTextUpdatesAsync()
        {
            try
            {
                var results = await this._tur.GetAllTextUpdatesAsync();
                return results;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<TextUpdates> GetTextUpdatesByIdAsync(int id)
        {
            try
            {
                var result = await this._tur.GetTextUpdatesByIdAsync(id);
                return result;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<TextUpdates> SaveTextUpdateAsync(TextUpdates textUpdate)
        {
            try
            {
                var result = await this._tur.SaveTextUpdateAsync(textUpdate);
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
