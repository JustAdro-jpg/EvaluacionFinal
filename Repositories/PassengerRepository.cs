using Microsoft.EntityFrameworkCore;
using ProyectoFinalTecWeb.Data;
using ProyectoFinalTecWeb.Entities;

namespace ProyectoFinalTecWeb.Repositories
{
    public class PassengerRepository : IPassengerRepository
    {
        private readonly AppDbContext _ctx;
        public PassengerRepository(AppDbContext ctx) { _ctx = ctx; }
        public async Task AddAsync(Passenger passenger)
        {
            _ctx.Passengers.Add(passenger);
            await _ctx.SaveChangesAsync();
        }

        public async Task Delete(Passenger passenger)
        {
            _ctx.Passengers.Remove(passenger);
            await _ctx.SaveChangesAsync();
        }

        public Task<bool> ExistsAsync(Guid id) =>
            _ctx.Passengers.AnyAsync(s => s.Id == id);

        public async Task<IEnumerable<Passenger>> GetAll()
        {
            return await _ctx.Passengers.ToListAsync();
        }

        public Task<Passenger?> GetByEmailAddress(string email) =>
            _ctx.Passengers.FirstOrDefaultAsync(u => u.Email == email);

        public Task<Passenger?> GetByRefreshToken(string refreshToken) =>
            _ctx.Passengers.FirstOrDefaultAsync(d => d.RefreshToken == refreshToken);

        public async Task<Passenger> GetOne(Guid id)
        {
            return await _ctx.Passengers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<Passenger?> GetTripsAsync(Guid id) =>
            _ctx.Passengers
                .Include(s => s.Trips)
                .FirstOrDefaultAsync(s => s.Id == id);

        public Task<int> SaveChangesAsync() => _ctx.SaveChangesAsync();

        public async Task Update(Passenger passenger)
        {
            _ctx.Passengers.Update(passenger);
            await _ctx.SaveChangesAsync();
        }
    }
}
