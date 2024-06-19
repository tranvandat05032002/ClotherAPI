using Microsoft.AspNetCore.Mvc;

namespace ClotherAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> Register()
        {
            return Ok(new
            {
                status = 200,
                message = "Register success!!!"
            });
        }
        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login()
        {
            return Ok(new
            {
                status = 200,
                message = "Login success!!!"
            });
        }

        // private readonly IAuthService _authService;

        // public UserController(IAuthService authService, ILogger<UserController> logger)
        // {
        //     _authService = authService;
        // }
        //// [HttpPost("register")]
        // [Route("register")]
        // [HttpPost]
        // public async Task<IActionResult> Register([FromBody] RegisterDTO registerDto)
        // {
        //     var userDto = await _authService.RegisterAsync(registerDto);
        //     if (userDto != null)
        //     {
        // return Ok(new
        // {
        //     status = 200,
        //     message = "Register success!!!"
        // });
        //     }
        //     else
        //     {
        //         return BadRequest(new
        //         {
        //             status = 400,
        //             message = "Không thành công"
        //         });
        //     }
        // }
    }
}