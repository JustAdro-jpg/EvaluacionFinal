using ProyectoFinalTecWeb.Entities;

namespace ProyectoFinalTecWeb.Repositories
{
    public interface IPassengerRepository
    {
        Task<Passenger?> GetByEmailAddress(string email);
        Task<Passenger?> GetByIdWithTripsAsync(Guid id);
        Task<Passenger?> GetByRefreshToken(string refreshToken);
        Task<Passenger?> GetTripsAsync(Guid id);
        Task<IEnumerable<Passenger>> GetAllWithTripsAsync();
        Task<bool> ExistsAsync(Guid id);
        Task<int> SaveChangesAsync();

        //CRUD
        Task AddAsync(Passenger passenger);
        Task<IEnumerable<Passenger>> GetAll();
        Task<Passenger> GetOne(Guid id);
        Task Update(Passenger passenger);
        Task Delete(Passenger passenger);

    }
}
