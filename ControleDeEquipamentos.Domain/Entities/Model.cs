using ControleDeEquipamentos.Domain.SeedWork;

namespace ControleDeEquipamentos.Domain.Entities
{
    public class Model : BaseEntity
    {
        public Model()
        {
            
        }

        public Model(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("O nome modelo não pode ser vazio");

            Name = name;
        }

        public string Name { get; private set; } = null!;
    }
}
