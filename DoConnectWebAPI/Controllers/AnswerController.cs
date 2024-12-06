using DoConnectEntity;
using DoConnectService.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoConnectWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AnswerController : ControllerBase
    {
        IAnswersService _service;
        public AnswerController(IAnswersService service)
        {
            _service = service;
        }
        [HttpPost("Post Answer")]
        public async Task<IActionResult> AddAnswer(Answers answers)
        {
            await _service.AddAnswer(answers);
            var obj = "Answer Added Sucessfully";
            return Ok(obj);
        }   
        [HttpDelete("DeleteAnswerByID")]
        public async Task<IActionResult> DeleteAnswerByID(int id)
        {
            await _service.DeleteAnswer(id);
            var obj = "Answer Deleted Successfully";
            return Ok(obj);
        }
        [HttpGet("GetAnswerByID")]
        public async Task<IActionResult> GetAnswerByID(int id)
        {
            var obj = await _service.GetAnswersById(id);
            return Ok(obj);
        }
        [HttpGet("GetUsersAnswer")]
        public async Task<IActionResult> GetUsersAnswer(string username)
        {
            var obj= await _service.GetUsersAnswer(username);
            return Ok(obj);
        }
    }

}
