using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PIBICAS.Models.Mapping
{
    public class PerfilMap : EntityTypeConfiguration<Perfil>
    {
        public PerfilMap()
        {
            // Primary Key
            this.HasKey(t => t.PerfilId);

            // Properties
            this.Property(t => t.PerfilId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PerfilNome)
                .IsRequired()
                .HasMaxLength(45);

            // Table & Column Mappings
            this.ToTable("perfil");
            this.Property(t => t.PerfilId).HasColumnName("perfilid");
            this.Property(t => t.PerfilNome).HasColumnName("perfilnome");
            this.Property(t => t.PerfilNivel).HasColumnName("perfilnivel");
        }
    }
}
