using DoConnectEntity;
using DoConnectService.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
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
            Qresponse qres = new Qresponse();
            await _questionService.AskQuestion(question);
            qres.statuscode = 200;
            qres.result = "Question Posted";
            qres.message = "Questions Obtained Successfully";
            return Ok(qres);
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
        [HttpGet("GetAllQuestion")]
        [Authorize]
        public async Task<IActionResult> GetAllQuestions()
        {
            var result = await _questionService.GetAllQuestion();
            return Ok(result);
        }   

    }
    class Qresponse
    {
        public object statuscode { get; set; }
        public object result { get; set; }
        public object message { get; set; }
    }
}
