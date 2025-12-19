using ProyectoFinalTecWeb.Entities.Dtos.Auth;
using ProyectoFinalTecWeb.Entities.Dtos.DriverDto;
using ProyectoFinalTecWeb.Entities.Dtos.PassengerDto;

namespace ProyectoFinalTecWeb.Services
{
    public interface IAuthService
    {
        Task<(bool ok, LoginResponseDto? response)> LoginAsync(LoginDto dto);
        Task<string> RegisterDriverAsync(RegisterDriverDto dto);
        Task<string> RegisterPassengerAsync(RegisterPassengerDto dto);
        Task<(bool ok, LoginResponseDto? response)> RefreshAsync(RefreshRequestDto dto);

        Task<(bool ok, string? response)> ForgotPasswordAsync(ForgotPasswordDto dto);
        Task<(bool ok, string? response)> ResetPasswordAsync(ResetPasswordDto dto);
    }
}
