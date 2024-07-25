using ApiAnon.Domain.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
//using ApiAnon.Infra.Services;

//controllers de anoninimizacao
namespace ApiAnon.Api.Controllers 
{

[ApiController]
[Route("api/")]

public class UserController : ControllerBase
{
    //log pra testes:
    private readonly ILogger<UserController> logger;

    public UserController(ILogger<UserController> logger)
    {
        this.logger = logger;
    }
    
    [HttpPost("anonymizeduser")]
     public IActionResult GenerateFakeName([FromBody] User user, UserAnonymized userAnonymized)
     {
        
     }

    //pra retornar o nome original atraves da anonimizacao
    [HttpGet("getoriginalname")]
    
}
    
}
