using ControleDeEquipamentos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleDeEquipamentos.Infra.EntitiesConfigurations
{
    internal sealed class EquipmentEntityConfiguration : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.ToTable("Equipments", "Equipments");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder.Property(s => s.Name)
                .HasColumnName("Name")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(s => s.NumberIdentifier)
                .HasColumnName("NumberIdentifier")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(s => s.Brand)
                .HasColumnName("Brand")
                .IsRequired();

            builder.Property(s => s.Identifier)
                .HasColumnName("Identifier")
                .IsRequired();

            builder.Property(s => s.Model)
                .HasColumnName("Model")
                .IsRequired();

            builder.Property(s => s.TypeOfEquipment)
                .HasColumnName("TypeOfEquipment")
                .IsRequired();

            builder.HasOne(s => s.Location)
                .WithMany(c => c.Equipments)
                .HasForeignKey(c => c.LocationId);
        }
    }
}