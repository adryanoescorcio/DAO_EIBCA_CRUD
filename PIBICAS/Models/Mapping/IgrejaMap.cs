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
            this.ToTable("igreja");
            this.Property(t => t.IgrejaId).HasColumnName("igrejaid");
            this.Property(t => t.IgrejaDenominacaoId).HasColumnName("igrejadenominacaoid");
            this.Property(t => t.IgrejaNome).HasColumnName("igrejanome");
            this.Property(t => t.IgrejaTelefone).HasColumnName("igrejatelefone");
            this.Property(t => t.IgrejaSlogan).HasColumnName("igrejaslogan");
            this.Property(t => t.IgrejaSigla).HasColumnName("igrejasigla");
            this.Property(t => t.IgrejaEndereco).HasColumnName("igrejaendereco");
            this.Property(t => t.IgrejaBairro).HasColumnName("igrejabairro");
            this.Property(t => t.IgrejaLogo).HasColumnName("igrejalogo");
            this.Property(t => t.IgrejaMunicipio).HasColumnName("igrejamunicipio");
            this.Property(t => t.IgrejaEstado).HasColumnName("igrejaestado");

            // Relationships
            this.HasRequired(t => t.Denominacao)
                .WithMany(t => t.Igrejas)
                .HasForeignKey(d => d.IgrejaDenominacaoId);

        }
    }
}
