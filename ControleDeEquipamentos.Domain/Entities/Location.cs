using ControleDeEquipamentos.Domain.SeedWork;

namespace ControleDeEquipamentos.Domain.Entities
{
    public class Location : BaseEntity
    {
        public string Name { get; private set; } = null!;
        public int SectorId { get; private set; }
        public Sector Sector { get; private set; } = null!;

        public ICollection<Equipment> Equipments { get; set; } = new HashSet<Equipment>();
    }
}
