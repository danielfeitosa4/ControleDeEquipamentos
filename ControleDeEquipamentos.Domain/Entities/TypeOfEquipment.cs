using ControleDeEquipamentos.Domain.SeedWork;

namespace ControleDeEquipamentos.Domain.Entities
{
    public class TypeOfEquipment : BaseEntity
    {
        public TypeOfEquipment()
        {
            
        }

        public TypeOfEquipment(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("O nome do tipo do equipamento não pode ser vazio");

            Name = name;
        }

        public string Name { get; private set; } = null!;
    }
}