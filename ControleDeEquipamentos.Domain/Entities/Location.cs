using ControleDeEquipamentos.Domain.SeedWork;

namespace ControleDeEquipamentos.Domain.Entities
{
    public class Location : BaseEntity
    {
        public string Name { get; private set; } = null!;

        public ICollection<Sector> Sectors { get; set; } = new HashSet<Sector>();
    }
}
