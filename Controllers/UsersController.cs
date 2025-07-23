// Controllers/UsersController.cs
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using ApiHangMail.Services;

namespace ApiHangMail.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IBackgroundJobClient _backgroundJobs;
    private readonly EmailService _emailService;

    public UsersController(IBackgroundJobClient backgroundJobs, EmailService emailService)
    {
        _backgroundJobs = backgroundJobs;
        _emailService = emailService;
    }

    public record UserRequest(string Nome, string Email);

    [HttpPost("cadastrar")]
    public IActionResult CadastrarUsuario([FromBody] UserRequest request)
    {
        Console.WriteLine($"Usuário cadastrado: {request.Nome} <{request.Email}>");
        _backgroundJobs.Enqueue(() =>
            _emailService.SendWelcome(request.Email, request.Nome));

        return Ok("Usuário cadastrado com sucesso!");
    }
}

