using DoConnectEntity;
using DoConnectService.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoConnectWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        IQuestionService _questionService;
        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }
        [HttpPost("AskQuestion")]
        [Authorize]
        public async Task<IActionResult> AskQuestion(Questions question)
        {
            await _questionService.AskQuestion(question);
            object result = "Question Submitted";
            return Ok(result);
        }
        [HttpDelete("DeleteQuestion")]
        [Authorize]
        public async Task<IActionResult> DeleteQuestion(int questionId)
        {
            await _questionService.DeleteQuestion(questionId);
            object result = "Question Deleted Successfully";
            return Ok(result);
        }
        [HttpGet("GetQuestionByID")]
        [Authorize]
        public async Task<IActionResult> GetQuestionByID(int questionId)
        {
            var result =await _questionService.GetQuestionByID(questionId);
            return Ok(result);
        }
        [HttpGet("GetQuestionOfUser")]
        [Authorize]
        public async Task<IActionResult> GetUsersQuestions(string username)
        {
            var result = await _questionService.GetUsersQuestion(username);
            return Ok(result);
        }

    }
}
