using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project2Models;
using Project2Ruleset.Interface;

namespace Project2API.Controllers
{
    [Route("api/journal/v1/text-updates")]
    [ApiController]
    public class TextUpdatesController : ControllerBase
    {
        private ITextUpdatesRuleset _tur;

        public TextUpdatesController(ITextUpdatesRuleset tur)
        {
            this._tur = tur;
        }

        [HttpGet("get-all-text-updates")]
        [ProducesResponseType(typeof(List<TextUpdates>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllTextUpdatesAsync()
        {
            try
            {
                var results = await this._tur.GetAllTextUpdatesAsync();
                return Ok(results);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet("get-text-update-by-id")]
        [ProducesResponseType(typeof(TextUpdates), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetTextUpdateByIdAsync(int id)
        {
            try
            {
                var result = await this._tur.GetTextUpdatesByIdAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpDelete("delete-text-udate-by-id")]
        [ProducesResponseType(typeof(TextUpdates), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteTextUpdateById(int id)
        {
            try
            {
                var result = await this._tur.DeleteTextUpdateByIdAsync(id);
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        [HttpPost("save-text-update")]
        [ProducesResponseType(typeof(TextUpdates), StatusCodes.Status200OK)]
        public async Task<IActionResult> SaveTextUpdateAsync([FromBody] TextUpdates textUpdate)
        {
            try
            {
                var result = await this._tur.SaveTextUpdateAsync(textUpdate);
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
