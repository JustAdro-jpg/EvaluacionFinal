using ProyectoFinalTecWeb.Entities;

namespace ProyectoFinalTecWeb.Repositories
{
    public interface IDriverRepository
    {
        Task<Driver?> GetByEmailAddress(string email);
        Task<Driver?> GetByRefreshToken(string refreshToken);
        Task<Driver?> GetTripsAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
        Task<int> SaveChangesAsync();

        //CRUD
        Task AddAsync(Driver driver);
        Task<IEnumerable<Driver>> GetAll();
        Task<Driver?> GetOne(Guid id);
        Task Update(Driver driver);
        Task Delete(Driver driver);
    }
}
