using ControleDeEquipamentos.Domain.SeedWork;

namespace ControleDeEquipamentos.Domain.Entities
{
    public class Identifier : BaseEntity
    {
        public Identifier()
        {

        }

        public Identifier(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("O nome do identificador não pode ser vazio");

            Name = name;
        }

        public string Name { get; private set; } = null!;
    }
}
