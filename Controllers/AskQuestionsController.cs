//Jessie Lamzon
//10-25-22
//Ask Questions End point - allow user to input name and what time they woke up
//peer review: Elizar Garcia: Code works as intended. shows up on postman without a problem. the urls connect the words that i am inputing. great job!

using Microsoft.AspNetCore.Mvc;

namespace lamzonJ_AskQuestionsEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AskQuestionsController : ControllerBase
{
    [HttpGet]
    [Route("AskQuestions/{name}/{time}")]

    public string AskQuestions(string name, string time)
    {
        return $"Hello {name}!  Today you woke up at {time}. Carpe Diem {name}!";
    }
}