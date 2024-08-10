using ControleDeEquipamentos.Domain.SeedWork;

namespace ControleDeEquipamentos.Domain.Entities
{
    public class Sector : BaseEntity
    {
        public Sector()
        {

        }

        public Sector(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("O nome do setor não pode ser vazio");

            Name = name;
        }
        public string Name { get; private set; } = null!;

        public ICollection<Location> Locations { get; set; } = new HashSet<Location>();
    }
}
