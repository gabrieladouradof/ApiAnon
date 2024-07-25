using ApiAnon.Domain.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ApiAnon.Infra.Services;

namespace ApiAnon.Api.Controllers 
{
//specifying mvc namespace in route
[Microsoft.AspNetCore.Mvc.Route("api/[Controller]")]
[ApiController]


public class UserController : ControllerBase
{
    //log pra testes:
    private readonly ILogger<UserController> logger;

    public UserController(ILogger<UserController> logger)
    {
        this.logger = logger;
    }
  
}
    
}
