using ControleDeEquipamentos.Domain.Entities;
using ControleDeEquipamentos.Domain.Interfaces;
using ControleDeEquipamentos.Infra.Data;

namespace ControleDeEquipamentos.Infra.Repositories
{
    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly AppDbContext _context;

        public EquipmentRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<Equipment> AddAsync(Equipment equipment)
        {
            throw new NotImplementedException();
        }

        public Task<Equipment> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Equipment>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Equipment> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Equipment> UpdateAsync(Equipment equipment)
        {
            throw new NotImplementedException();
        }
    }
}
