using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PIBICAS.Models.Mapping
{
    public class MunicipioMap : EntityTypeConfiguration<Municipio>
    {
        public MunicipioMap()
        {
            // Primary Key
            this.HasKey(t => t.MunicipioId);

            // Properties
            this.Property(t => t.MunicipioId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.MunicipioNome)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Municipio");
            this.Property(t => t.MunicipioId).HasColumnName("MunicipioId");
            this.Property(t => t.MunicipioUdIf).HasColumnName("MunicipioUfId");
            this.Property(t => t.MunicipioNome).HasColumnName("MunicipioNome");

            // Relationships
            this.HasRequired(t => t.Uf)
                .WithMany(t => t.Municipios)
                .HasForeignKey(d => d.MunicipioUdIf);

        }
    }
}
