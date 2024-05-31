using ControleDeEquipamentos.Domain.SeedWork;

namespace ControleDeEquipamentos.Domain.Entities
{
    public class Equipment : BaseEntity
    {
        public string Name { get; private set; } = null!;
        public string NumberIdentifier { get; private set; } = null!;
        public Brand Brand { get; private set; } = null!;
        public Identifier Identifier { get; private set; } = null!;
        public Model Model { get; private set; } = null!;
        public TypeOfEquipment TypeOfEquipment { get; set; } = null!;

        public int SectorId { get; private set; }
        public Sector Sector { get; private set; } = null!;
    }
}
