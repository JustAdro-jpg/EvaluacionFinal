using ProyectoFinalTecWeb.Entities;
using ProyectoFinalTecWeb.Entities.Dtos.DriverDto;

namespace ProyectoFinalTecWeb.Services
{
    public interface IDriverService
    {
        //Authentication
        Task<string> RegisterAsync(RegisterDriverDto dto);

        //CRUD
        Task<Guid> CreateAsync(CreateDriverDto dto);


        Task<IEnumerable<Driver>> GetAll();
        Task<Driver> GetOne(Guid id);
        Task<Driver> UpdateDriver(UpdateDriverDto dto, Guid id);
        Task DeleteDriver(Guid id);
    }
}
