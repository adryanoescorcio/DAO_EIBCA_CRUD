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
            this.ToTable("municipio");
            this.Property(t => t.MunicipioId).HasColumnName("municipioid");
            this.Property(t => t.MunicipioIdUf).HasColumnName("municipioufid");
            this.Property(t => t.MunicipioNome).HasColumnName("municipionome");

            // Relationships
            this.HasRequired(t => t.Uf)
                .WithMany(t => t.Municipios)
                .HasForeignKey(d => d.MunicipioIdUf);

        }
    }
}
