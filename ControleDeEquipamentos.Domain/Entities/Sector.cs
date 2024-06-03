using ControleDeEquipamentos.Domain.SeedWork;
using System.Security.Claims;

namespace ControleDeEquipamentos.Domain.Entities
{
    public class Sector : BaseEntity
    {
        public string Name { get; private set; } = null!;

        public ICollection<Location> Locations { get; set; } = new HashSet<Location>();
    }
}
