using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project2Models;
using Project2Ruleset.Interface;

namespace Project2API.Controllers
{
    [Route("api/journal/v1/entries")]
    [ApiController]
    public class UpdateEntriesController : ControllerBase
    {
        private IUpdateEntryRuleset _updateEntriesRuleset;

        public UpdateEntriesController(IUpdateEntryRuleset updateEntryRuleset)
        {
            this._updateEntriesRuleset = updateEntryRuleset;
        }

        [HttpGet("getAllEntries")]
        [ProducesResponseType(typeof(List<UpdateEntry>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllUpdateEntriesAsync()
        {
            var entries = await this._updateEntriesRuleset.GetAllEntriesAsync();
            return Ok(entries);
        }

        [HttpGet("getEntryById")]
        [ProducesResponseType(typeof(UpdateEntry), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetUpdateEntryByIdAsync(int id)
        {
            var entry = await this._updateEntriesRuleset.GetUpdateEntryByIdAsync(id);
            return Ok(entry);
        }

        [HttpDelete("deleteEntryById")]
        [ProducesResponseType(typeof(UpdateEntry), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteEntryById(int id)
        {
            var entry = await this._updateEntriesRuleset.DeleteUpdateEntryByIdAsync(id);
            return Ok(entry);
        }

        [HttpPost("saveEntry")]
        [ProducesResponseType(typeof(UpdateEntry), StatusCodes.Status200OK)]
        public async Task<IActionResult> SaveEntry([FromBody] UpdateEntry updateEnty)
        {
            var entry = await this._updateEntriesRuleset.SaveUpdateEntryAsync(updateEnty);
            return Ok(entry);
        }

    }
}
