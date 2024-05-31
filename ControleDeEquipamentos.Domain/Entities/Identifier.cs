using ControleDeEquipamentos.Domain.SeedWork;

namespace ControleDeEquipamentos.Domain.Entities
{
    public class Identifier : BaseEntity
    {
        public string Name { get; private set; } = null!;
    }
}
