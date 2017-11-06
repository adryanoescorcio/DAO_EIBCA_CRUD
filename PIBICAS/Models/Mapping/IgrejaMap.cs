using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PIBICAS.Models.Mapping
{
    public class IgrejaMap : EntityTypeConfiguration<Igreja>
    {
        public IgrejaMap()
        {
            // Primary Key
            this.HasKey(t => t.IgrejaId);

            // Properties
            this.Property(t => t.IgrejaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.IgrejaNome)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.IgrejaTelefone)
                .HasMaxLength(100);

            this.Property(t => t.IgrejaSlogan)
                .HasMaxLength(200);

            this.Property(t => t.IgrejaSigla)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.IgrejaEndereco)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.IgrejaBairro)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.IgrejaMunicipio)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.IgrejaEstado)
                .IsRequired()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("Igreja");
            this.Property(t => t.IgrejaId).HasColumnName("IgrejaId");
            this.Property(t => t.IgrejaDenominacaoId).HasColumnName("IgrejaDenominacaoId");
            this.Property(t => t.IgrejaNome).HasColumnName("IgrejaNome");
            this.Property(t => t.IgrejaTelefone).HasColumnName("IgrejaTelefone");
            this.Property(t => t.IgrejaSlogan).HasColumnName("IgrejaSlogan");
            this.Property(t => t.IgrejaSigla).HasColumnName("IgrejaSigla");
            this.Property(t => t.IgrejaEndereco).HasColumnName("IgrejaEndereco");
            this.Property(t => t.IgrejaBairro).HasColumnName("IgrejaBairro");
            this.Property(t => t.IgrejaLogo).HasColumnName("IgrejaLogo");
            this.Property(t => t.IgrejaMunicipio).HasColumnName("IgrejaMunicipio");
            this.Property(t => t.IgrejaEstado).HasColumnName("IgrejaEstado");

            // Relationships
            this.HasRequired(t => t.Denominacao)
                .WithMany(t => t.Igrejas)
                .HasForeignKey(d => d.IgrejaDenominacaoId);

        }
    }
}
