using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PIBICAS.Models.Mapping
{
    public class AcessoMap : EntityTypeConfiguration<Acesso>
    {
        public AcessoMap()
        {
            // Primary Key
            this.HasKey(t => t.AcessoId);

            // Properties
            this.Property(t => t.AcessoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("Acesso");
            this.Property(t => t.AcessoId).HasColumnName("AcessoId");
            this.Property(t => t.AcessoUsuarioID).HasColumnName("AcessoUsuarioID");
            this.Property(t => t.AcessoDataEntrada).HasColumnName("AcessoDataEntrada");
            this.Property(t => t.AcessoDataSaida).HasColumnName("AcessoDataSaida");

            // Relationships
            this.HasRequired(t => t.Usuario)
                .WithMany(t => t.Acessoes)
                .HasForeignKey(d => d.AcessoUsuarioID);

        }
    }
}
