using ControleDeEquipamentos.Domain.SeedWork;
using System.Security.Claims;

namespace ControleDeEquipamentos.Domain.Entities
{
    public class Sector : BaseEntity
    {
        public string Name { get; private set; } = null!;
        public int LocationId { get; private set; }
        public Location Location { get; private set; } = null!;

        public ICollection<Equipment> Equipments { get; set; } = new HashSet<Equipment>();
    }
}
