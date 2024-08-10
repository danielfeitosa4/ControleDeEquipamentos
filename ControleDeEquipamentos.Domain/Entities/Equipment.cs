using ControleDeEquipamentos.Domain.SeedWork;

namespace ControleDeEquipamentos.Domain.Entities
{
    public class Equipment : BaseEntity
    {
        public Equipment()
        {
            
        }

        public Equipment(string name, string numberIdentifier, Brand brand, Identifier identifier, Model model, TypeOfEquipment typeOfEquipment, int locationId)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("O nome não pode ser vazio");

            if (name.Length < 4) 
                throw new Exception("O nome o equipamento deve ser maior que 4 caracteres");

            if (string.IsNullOrWhiteSpace(numberIdentifier))
                throw new Exception("O número identificador não pode ser vazio");

            Name = name;
            NumberIdentifier = numberIdentifier;
            Brand = brand;
            Identifier = identifier;
            Model = model;
            TypeOfEquipment = typeOfEquipment;
            LocationId = locationId;

            IsEnabled = true;
            CreatedAt = DateTimeOffset.UtcNow;
            UpdatedAt = CreatedAt;
        }

        public string Name { get; private set; } = null!;
        public string NumberIdentifier { get; private set; } = null!;
        public Brand Brand { get; private set; } = null!;
        public Identifier Identifier { get; private set; } = null!;
        public Model Model { get; private set; } = null!;
        public TypeOfEquipment TypeOfEquipment { get; set; } = null!;

        public bool IsEnabled { get; private set; }
        public DateTimeOffset CreatedAt { get; private set; }
        public string? CreatedBy { get; private set; }
        public DateTimeOffset UpdatedAt { get; private set; }
        public string? UpdatedBy { get; private set; }
        public DateTimeOffset? DeletedAt { get; private set; }
        public string? DeletedBy { get; private set; }

        public int LocationId { get; private set; }
        public Location Location { get; private set; } = null!;

        public void Delete()
        {
            IsEnabled = false;
            DeletedAt = DateTimeOffset.UtcNow;
            UpdatedAt = DeletedAt.Value;
        }
    }
}
