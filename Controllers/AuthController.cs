using Microsoft.AspNetCore.Mvc;
using ProyectoFinalTecWeb.Entities.Dtos.Auth;
using ProyectoFinalTecWeb.Entities.Dtos.DriverDto;
using ProyectoFinalTecWeb.Entities.Dtos.PassengerDto;
using ProyectoFinalTecWeb.Services;

namespace ProyectoFinalTecWeb.Controllers
{
    [ApiController]
    [Route("api/auth/[Controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _service;
        public AuthController(IAuthService service)
        {
            _service = service;
        }
        // POST: api/auth/driver

        [HttpPost("register/driver")]
        public async Task<IActionResult> RegisterDriver([FromBody] RegisterDriverDto dto)
        {
            var id = await _service.RegisterDriverAsync(dto);
            return CreatedAtAction(nameof(RegisterDriver), new { id }, null);
        }
        [HttpPost("register/passenger")]
        public async Task<IActionResult> RegisterPassenger([FromBody] RegisterPassengerDto dto)
        {
            var id = await _service.RegisterPassengerAsync(dto);
            return CreatedAtAction(nameof(RegisterPassenger), new { id }, null);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            var (ok, response) = await _service.LoginAsync(dto);
            if (!ok || response is null) return Unauthorized();
            return Ok(response);
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh([FromBody] RefreshRequestDto dto)
        {
            var (ok, response) = await _service.RefreshAsync(dto);
            if (!ok || response is null) return Unauthorized();
            return Ok(response);
        }
    }
}
