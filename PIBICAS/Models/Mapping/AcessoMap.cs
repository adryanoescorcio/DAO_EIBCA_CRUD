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
            this.ToTable("acesso");

            this.Property(t => t.AcessoId).HasColumnName("acessoid");
            this.Property(t => t.AcessoUsuarioID).HasColumnName("acessousuarioid");
            this.Property(t => t.AcessoDataEntrada).HasColumnName("acessodataentrada");
            this.Property(t => t.AcessoDataSaida).HasColumnName("acessodatasaida");

            // Relationships
            this.HasRequired(t => t.Usuario)
                .WithMany(t => t.Acessoes)
                .HasForeignKey(d => d.AcessoUsuarioID);

        }
    }
}
