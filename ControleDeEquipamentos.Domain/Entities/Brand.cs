using ControleDeEquipamentos.Domain.SeedWork;

namespace ControleDeEquipamentos.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public Brand()
        {
            
        }

        public Brand(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("O nome da marca não pode ser vazio");

            Name = name;
        }

        public string Name { get; private set; } = null!;
    }
}
