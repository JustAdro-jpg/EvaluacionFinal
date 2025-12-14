using Microsoft.EntityFrameworkCore;
using ProyectoFinalTecWeb.Data;
using ProyectoFinalTecWeb.Entities;

namespace ProyectoFinalTecWeb.Repositories
{
    public class DriverRepository : IDriverRepository
    {
        private readonly AppDbContext _ctx;
        public DriverRepository(AppDbContext ctx) { _ctx = ctx; }

        public async Task AddAsync(Driver driver)
        {
            _ctx.Driveres.Add(driver);
            await _ctx.SaveChangesAsync();
        }

        public async Task Delete(Driver driver)
        {
            _ctx.Driveres.Remove(driver);
            await _ctx.SaveChangesAsync();
        }

        public Task<bool> ExistsAsync(Guid id) =>
            _ctx.Driveres.AnyAsync(s => s.Id == id);

        public async Task<IEnumerable<Driver>> GetAll()
        {
            return await _ctx.Driveres.ToListAsync();
        }

        public Task<Driver?> GetByEmailAddress(string email) =>
            _ctx.Driveres.FirstOrDefaultAsync(u => u.Email == email);

        public Task<Driver?> GetByRefreshToken(string refreshToken)=>
            _ctx.Driveres.FirstOrDefaultAsync(d => d.RefreshToken == refreshToken);

        public async Task<Driver?> GetOne(Guid id)
        {
            return await _ctx.Driveres
            .Include(c => c.Trips)
            .Include(c => c.Vehicles)
            .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Driver?> GetTripsAsync(Guid id)
        {
            return await _ctx.Driveres
                .Include(c => c.Trips)
                .Include(c => c.Vehicles)
                .FirstOrDefaultAsync(c => c.Id == id);
        }


        public Task<int> SaveChangesAsync() => _ctx.SaveChangesAsync();

        public async Task Update(Driver driver)
        {
            _ctx.Driveres.Update(driver);
            await _ctx.SaveChangesAsync();
        }
    }
}
