using ControleDeEquipamentos.Domain.Entities;

namespace ControleDeEquipamentos.Domain.Interfaces
{
    public interface IEquipmentRepository
    {
        Task<Equipment> GetByIdAsync(int id);
        Task<IEnumerable<Equipment>> GetAllAsync();
        Task<Equipment> AddAsync(Equipment equipment);
        Task<Equipment> UpdateAsync(Equipment equipment);
        Task<Equipment> DeleteAsync(int id);
    }
}
