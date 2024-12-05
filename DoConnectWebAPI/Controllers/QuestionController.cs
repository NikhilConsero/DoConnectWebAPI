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
        public IActionResult AskQuestion(Questions question)
        {
            _questionService.AskQuestion(question);
            object result = "Question Submitted";
            return Ok(result);
        }
        [HttpDelete("DeleteQuestion")]
        public IActionResult DeleteQuestion(int questionId)
        {
            _questionService.DeleteQuestion(questionId);
            object result = "Question Deleted Successfully";
            return Ok(result);
        }
        [HttpGet("GetQuestionByID")]
        public IActionResult GetQuestionByID(int questionId)
        {
            var result =_questionService.GetQuestionByID(questionId);
            return Ok(result);
        }
        [HttpGet("GetQuestionOfUser")]
        public IActionResult GetUsersQuestions(string username)
        {
            var result = _questionService.GetUsersQuestion(username);
            return Ok(result);
        }

    }
}
