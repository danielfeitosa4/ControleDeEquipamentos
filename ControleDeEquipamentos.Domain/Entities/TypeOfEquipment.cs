using ControleDeEquipamentos.Domain.SeedWork;

namespace ControleDeEquipamentos.Domain.Entities
{
    public class TypeOfEquipment : BaseEntity
    {
        public string Name { get; private set; } = null!;
    }
}