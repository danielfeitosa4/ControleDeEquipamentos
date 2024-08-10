using ControleDeEquipamentos.Domain.SeedWork;

namespace ControleDeEquipamentos.Domain.Entities
{
    public class Location : BaseEntity
    {
        public Location()
        {
            
        }
        public Location(string name, int sectorId)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("O nome da localização não pode ser vazio");

            Name = name;
            SectorId = sectorId;
        }

        public string Name { get; private set; } = null!;
        public int SectorId { get; private set; }
        public Sector Sector { get; private set; } = null!;

        public ICollection<Equipment> Equipments { get; set; } = new HashSet<Equipment>();
    }
}
