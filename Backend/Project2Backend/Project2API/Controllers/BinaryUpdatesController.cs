using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project2Models;
using Project2Ruleset.Interface;

namespace Project2API.Controllers
{
    [Route("api/journal/v1/binary-updates")]
    [ApiController]
    public class BinaryUpdatesController : ControllerBase
    {
        private IBinaryUpdatesRuleset _bur;

        public BinaryUpdatesController(IBinaryUpdatesRuleset bur)
        {
            this._bur = bur;
        }

        [HttpGet("get-all-binary-updates")]
        [ProducesResponseType(typeof(List<BinaryUpdates>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllBinaryUpdatesAsync()
        {
            try
            {
                var results = await this._bur.GetAllBinaryUpdatesAsync();
                return Ok(results);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        [HttpGet("get-binary-updattes-by-id")]
        [ProducesResponseType(typeof(BinaryUpdates), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetBinaryUpdatesByIdAsync(int id)
        {
            try
            {
                var result = await this._bur.GetBinaryUpdatesByIdAsync(id);
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        [HttpDelete("delete-binary-update-by-id")]
        [ProducesResponseType(typeof(BinaryUpdates), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteBinaryUpdateByIdAsync(int id)
        {
            try
            {
                var result = await this._bur.DeleteBinaryUpdateByIdAsync(id);
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        /*[HttpPost("save-binary-update")]
        [ProducesResponseType(typeof(BinaryUpdates), StatusCodes.Status200OK)]
        public async Task<IActionResult> SaveBinaryUpdateAsync(IFormFile binaryUpdate)
        {
            try
            {
                BinaryUpdates binUp = new BinaryUpdates();
                binUp.Title = binaryUpdate.Name;
                binUp.Date = DateTime.Now;
                binUp.File = binaryUpdate.FileName;
            }
        }*/
    }
}
